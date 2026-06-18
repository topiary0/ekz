using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DemoMebel
{
    public partial class AddGoodWindow : Form
    {
        private string selectedImagePath;

        public AddGoodWindow()
        {
            InitializeComponent();
            Program.ApplyFormStyle(this);
            Program.ApplyHeaderStyle(headerPanel);
            Program.ApplyAccentButton(saveButton);
            Program.ApplyPlainButton(cancelButton);
            Program.ApplySecondaryButton(selectImageButton);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить данные формы товара.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
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
                return string.Empty;
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

            MainDataSet.goodsDataTable goods = new MainDataSetTableAdapters.goodsTableAdapter().GetData();
            foreach (DataRow row in goods.Rows)
            {
                if (Convert.ToString(row["article"]) == articleTextBox.Text.Trim())
                {
                    return Warning("Товар с таким артикулом уже существует.", articleTextBox);
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
