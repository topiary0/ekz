using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DemoMebel
{
    public partial class AddGoodWindow : Form
    {
        private readonly string editingArticle;
        private string selectedImagePath;
        private string currentPictureName;

        public AddGoodWindow()
        {
            InitializeComponent();
            Program.ApplyFormStyle(this);
            Program.ApplyHeaderStyle(headerPanel);
            Program.ApplyAccentButton(saveButton);
            Program.ApplyPlainButton(cancelButton);
            Program.ApplySecondaryButton(selectImageButton);
        }

        public AddGoodWindow(string article)
            : this()
        {
            editingArticle = article;
        }

        private void AddGoodWindow_Load(object sender, EventArgs e)
        {
            try
            {
                categoryComboBox.DataSource = new MainDataSetTableAdapters.categoriesTableAdapter().GetData();
                categoryComboBox.DisplayMember = "name";
                categoryComboBox.ValueMember = "id";

                manufacturerComboBox.DataSource = new MainDataSetTableAdapters.manufacturersTableAdapter().GetData();
                manufacturerComboBox.DisplayMember = "name";
                manufacturerComboBox.ValueMember = "id";

                supplierComboBox.DataSource = new MainDataSetTableAdapters.suppliersTableAdapter().GetData();
                supplierComboBox.DisplayMember = "name";
                supplierComboBox.ValueMember = "id";

                Program.SetPlaceholder(productPictureBox);
                pictureNameLabel.Text = "Изображение не выбрано";
                measurementTextBox.Text = "шт.";

                if (IsEditMode)
                {
                    LoadGoodForEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить данные формы товара.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }


        private bool IsEditMode
        {
            get { return !string.IsNullOrWhiteSpace(editingArticle); }
        }

        private void LoadGoodForEdit()
        {
            MainDataSet.goodsDataTable goods = new MainDataSetTableAdapters.goodsTableAdapter().GetData();
            foreach (DataRow row in goods.Rows)
            {
                if (Convert.ToString(row["article"]) == editingArticle)
                {
                    titleLabel.Text = "Редактирование товара";
                    Text = "Редактирование товара";
                    saveButton.Text = "Сохранить изменения";
                    articleTextBox.Text = Convert.ToString(row["article"]);
                    articleTextBox.ReadOnly = true;
                    nameTextBox.Text = Convert.ToString(row["name"]);
                    measurementTextBox.Text = Convert.ToString(row["measurment"]);
                    priceNumericUpDown.Value = Convert.ToDecimal(row["price"]);
                    supplierComboBox.SelectedValue = Convert.ToInt32(row["supplier"]);
                    manufacturerComboBox.SelectedValue = Convert.ToInt32(row["manufacturer"]);
                    categoryComboBox.SelectedValue = Convert.ToInt32(row["category"]);
                    saleNumericUpDown.Value = Convert.ToInt32(row["sale"]);
                    warehouseNumericUpDown.Value = Convert.ToInt32(row["warehouse"]);
                    descriptionTextBox.Text = Convert.ToString(row["describe"]);
                    currentPictureName = Convert.ToString(row["picture"]);
                    pictureNameLabel.Text = string.IsNullOrWhiteSpace(currentPictureName) ? "Изображение не выбрано" : currentPictureName;

                    string picturePath = Program.GetAssetPath(currentPictureName);
                    if (File.Exists(picturePath))
                    {
                        productPictureBox.Image = Program.LoadImage(picturePath);
                    }

                    return;
                }
            }

            throw new InvalidOperationException("Товар для редактирования не найден.");
        }

        private void UpdateGood(string pictureName)
        {
            MainDataSetTableAdapters.goodsTableAdapter adapter = new MainDataSetTableAdapters.goodsTableAdapter();
            MainDataSet.goodsDataTable goods = adapter.GetData();

            foreach (DataRow row in goods.Rows)
            {
                if (Convert.ToString(row["article"]) == editingArticle)
                {
                    row["name"] = nameTextBox.Text.Trim();
                    row["measurment"] = measurementTextBox.Text.Trim();
                    row["price"] = Convert.ToDouble(priceNumericUpDown.Value);
                    row["supplier"] = Convert.ToInt32(supplierComboBox.SelectedValue);
                    row["manufacturer"] = Convert.ToInt32(manufacturerComboBox.SelectedValue);
                    row["category"] = Convert.ToInt32(categoryComboBox.SelectedValue);
                    row["sale"] = Convert.ToInt32(saleNumericUpDown.Value);
                    row["warehouse"] = Convert.ToInt32(warehouseNumericUpDown.Value);
                    row["describe"] = descriptionTextBox.Text.Trim();
                    row["picture"] = pictureName;
                    adapter.Update(goods);
                    return;
                }
            }

            throw new InvalidOperationException("Товар для редактирования не найден.");
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp|Все файлы|*.*";
                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                selectedImagePath = dialog.FileName;
                pictureNameLabel.Text = Path.GetFileName(selectedImagePath);
                productPictureBox.Image = Program.LoadImage(selectedImagePath);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateGood())
            {
                return;
            }

            try
            {
                string pictureName = SaveImage();

                if (IsEditMode)
                {
                    UpdateGood(pictureName);
                }
                else
                {
                    MainDataSetTableAdapters.goodsTableAdapter adapter = new MainDataSetTableAdapters.goodsTableAdapter();
                    adapter.Insert(
                        articleTextBox.Text.Trim(),
                        nameTextBox.Text.Trim(),
                        measurementTextBox.Text.Trim(),
                        Convert.ToDouble(priceNumericUpDown.Value),
                        Convert.ToInt32(supplierComboBox.SelectedValue),
                        Convert.ToInt32(manufacturerComboBox.SelectedValue),
                        Convert.ToInt32(categoryComboBox.SelectedValue),
                        Convert.ToInt32(saleNumericUpDown.Value),
                        Convert.ToInt32(warehouseNumericUpDown.Value),
                        descriptionTextBox.Text.Trim(),
                        pictureName);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить товар.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SaveImage()
        {
            if (string.IsNullOrWhiteSpace(selectedImagePath) || !File.Exists(selectedImagePath))
            {
                return currentPictureName ?? string.Empty;
            }

            string fileName = "good_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + Path.GetExtension(selectedImagePath);
            File.Copy(selectedImagePath, Program.GetAssetPath(fileName), true);
            return fileName;
        }

        private bool ValidateGood()
        {
            if (string.IsNullOrWhiteSpace(articleTextBox.Text))
            {
                return Warning("Введите артикул товара.", articleTextBox);
            }

            if (!IsEditMode)
            {
                MainDataSet.goodsDataTable goods = new MainDataSetTableAdapters.goodsTableAdapter().GetData();
                foreach (DataRow row in goods.Rows)
                {
                    if (Convert.ToString(row["article"]) == articleTextBox.Text.Trim())
                    {
                        return Warning("Товар с таким артикулом уже существует.", articleTextBox);
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                return Warning("Введите наименование товара.", nameTextBox);
            }

            if (string.IsNullOrWhiteSpace(measurementTextBox.Text))
            {
                return Warning("Введите единицу измерения.", measurementTextBox);
            }

            if (categoryComboBox.SelectedValue == null ||
                manufacturerComboBox.SelectedValue == null ||
                supplierComboBox.SelectedValue == null)
            {
                return Warning("Выберите категорию, производителя и поставщика.", null);
            }

            return true;
        }

        private static bool Warning(string text, Control control)
        {
            MessageBox.Show(text, "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (control != null)
            {
                control.Select();
            }

            return false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
