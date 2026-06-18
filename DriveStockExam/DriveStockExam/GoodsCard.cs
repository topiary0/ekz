using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DemoMebel
{
    public partial class GoodsCard : UserControl
    {
        private readonly DataRow productRow;
        private readonly bool canManage;
        private readonly Action<string> editAction;
        private readonly Action<string> deleteAction;

        public GoodsCard()
        {
            InitializeComponent();
            Program.ApplySecondaryButton(editButton);
            Program.ApplyPlainButton(deleteButton);
            Program.SetPlaceholder(productPictureBox);
        }

        public GoodsCard(DataRow row, bool showManageButtons, Action<string> editProduct, Action<string> deleteProduct)
            : this()
        {
            productRow = row;
            canManage = showManageButtons;
            editAction = editProduct;
            deleteAction = deleteProduct;
            FillCard();
        }

        private void FillCard()
        {
            string article = Convert.ToString(productRow["article"]);
            string name = Convert.ToString(productRow["name"]);
            string category = Convert.ToString(productRow["category_name"]);
            string manufacturer = Convert.ToString(productRow["manufacturer_name"]);
            string supplier = Convert.ToString(productRow["supplier_name"]);
            string measurement = Convert.ToString(productRow["measurment"]);
            string description = Convert.ToString(productRow["describe"]);
            int sale = Convert.ToInt32(productRow["sale"]);
            int warehouse = Convert.ToInt32(productRow["warehouse"]);
            double price = Convert.ToDouble(productRow["price"]);

            titleLabel.Text = name;
            articleLabel.Text = "Артикул: " + article;
            categoryLabel.Text = "Категория: " + category;
            manufacturerLabel.Text = "Производитель: " + manufacturer;
            supplierLabel.Text = "Поставщик: " + supplier;
            measurementLabel.Text = "Ед. изм.: " + measurement;
            warehouseLabel.Text = "Остаток: " + warehouse;
            descriptionLabel.Text = "Описание: " + description;
            saleLabel.Text = "Скидка " + sale + "%";

            string pictureName = Convert.ToString(productRow["picture"]);
            string picturePath = Program.GetAssetPath(pictureName);
            productPictureBox.Image = File.Exists(picturePath) ? Program.LoadImage(picturePath) : Program.LoadImage(Program.GetAssetPath("picture.png"));

            if (sale > 0)
            {
                double finalPrice = price * (100 - sale) / 100;
                oldPriceLabel.Text = price.ToString("N2") + " руб.";
                oldPriceLabel.Visible = true;
                priceLabel.Text = finalPrice.ToString("N2") + " руб.";
            }
            else
            {
                oldPriceLabel.Visible = false;
                priceLabel.Text = price.ToString("N2") + " руб.";
            }

            if (sale > 15)
            {
                BackColor = Program.HighSaleColor;
                ApplyTextColor(Color.White);
            }
            else
            {
                ApplyTextColor(ForeColor);
            }

            editButton.Visible = canManage;
            deleteButton.Visible = canManage;
        }

        private void ApplyTextColor(Color color)
        {
            titleLabel.ForeColor = color;
            articleLabel.ForeColor = color;
            categoryLabel.ForeColor = color;
            manufacturerLabel.ForeColor = color;
            supplierLabel.ForeColor = color;
            measurementLabel.ForeColor = color;
            warehouseLabel.ForeColor = color;
            descriptionLabel.ForeColor = color;
            priceTitleLabel.ForeColor = color;
            priceLabel.ForeColor = color;
            oldPriceLabel.ForeColor = color;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (editAction != null)
            {
                editAction(Convert.ToString(productRow["article"]));
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteAction != null)
            {
                deleteAction(Convert.ToString(productRow["article"]));
            }
        }
    }
}
