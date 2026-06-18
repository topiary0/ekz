using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DemoMebel
{
    public partial class GoodsWindow : Form
    {
        private readonly int currentRole;
        private MainDataSet.goodsDataTable goodsTable;

        public GoodsWindow()
            : this(Program.GuestRoleId)
        {
        }

        public GoodsWindow(int roleId)
        {
            InitializeComponent();
            currentRole = roleId;
            Program.ApplyFormStyle(this);
            Program.ApplyHeaderStyle(headerPanel);
            Program.ApplyAccentButton(addProductButton);
            Program.ApplySecondaryButton(ordersButton);
            Program.ApplyPlainButton(refreshButton);
        }

        private bool CanUseProductTools
        {
            get { return currentRole == Program.AdministratorRoleId || currentRole == Program.ManagerRoleId; }
        }

        private bool CanManageProducts
        {
            get { return currentRole == Program.AdministratorRoleId; }
        }

        private bool CanOpenOrders
        {
            get { return currentRole == Program.AdministratorRoleId || currentRole == Program.ManagerRoleId; }
        }

        private void GoodsWindow_Load(object sender, EventArgs e)
        {
            Program.SetLogo(logoPictureBox);
            logoPictureBox.Visible = logoPictureBox.Image != null;
            searchLabel.Visible = CanUseProductTools;
            searchTextBox.Visible = CanUseProductTools;
            filterLabel.Visible = CanUseProductTools;
            filterComboBox.Visible = CanUseProductTools;
            sortLabel.Visible = CanUseProductTools;
            sortComboBox.Visible = CanUseProductTools;
            addProductButton.Visible = CanManageProducts;
            ordersButton.Visible = CanOpenOrders;
            filterComboBox.SelectedIndex = 0;
            sortComboBox.SelectedIndex = 0;
            LoadGoods();
        }

        private void LoadGoods()
        {
            try
            {
                MainDataSetTableAdapters.goodsTableAdapter goodsAdapter = new MainDataSetTableAdapters.goodsTableAdapter();
                goodsTable = goodsAdapter.GetData();
                FillLookupColumns();
                ApplyGoodsView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить список товаров.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillLookupColumns()
        {
            MainDataSet.categoriesDataTable categories = new MainDataSetTableAdapters.categoriesTableAdapter().GetData();
            MainDataSet.manufacturersDataTable manufacturers = new MainDataSetTableAdapters.manufacturersTableAdapter().GetData();
            MainDataSet.suppliersDataTable suppliers = new MainDataSetTableAdapters.suppliersTableAdapter().GetData();

            AddTextColumn("category_name");
            AddTextColumn("manufacturer_name");
            AddTextColumn("supplier_name");

            foreach (DataRow row in goodsTable.Rows)
            {
                row["category_name"] = FindName(categories, Convert.ToInt32(row["category"]));
                row["manufacturer_name"] = FindName(manufacturers, Convert.ToInt32(row["manufacturer"]));
                row["supplier_name"] = FindName(suppliers, Convert.ToInt32(row["supplier"]));
            }
        }

        private void AddTextColumn(string columnName)
        {
            if (!goodsTable.Columns.Contains(columnName))
            {
                goodsTable.Columns.Add(columnName);
            }
        }

        private static string FindName(DataTable table, int id)
        {
            foreach (DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row["id"]) == id)
                {
                    return Convert.ToString(row["name"]);
                }
            }

            return string.Empty;
        }

        private void ApplyGoodsView()
        {
            if (goodsTable == null)
            {
                return;
            }

            IEnumerable<DataRow> rows = goodsTable.AsEnumerable();

            if (CanUseProductTools)
            {
                string search = searchTextBox.Text.Trim().ToLower();
                if (search != string.Empty)
                {
                    rows = rows.Where(row => GetSearchText(row).Contains(search));
                }

                if (filterComboBox.SelectedIndex == 1)
                {
                    rows = rows.Where(row => Convert.ToInt32(row["sale"]) < 12);
                }
                else if (filterComboBox.SelectedIndex == 2)
                {
                    rows = rows.Where(row =>
                    {
                        int sale = Convert.ToInt32(row["sale"]);
                        return sale >= 12 && sale < 19;
                    });
                }
                else if (filterComboBox.SelectedIndex == 3)
                {
                    rows = rows.Where(row => Convert.ToInt32(row["sale"]) >= 19);
                }

                if (sortComboBox.SelectedIndex == 1)
                {
                    rows = rows.OrderBy(row => Convert.ToDouble(row["price"]));
                }
                else if (sortComboBox.SelectedIndex == 2)
                {
                    rows = rows.OrderByDescending(row => Convert.ToDouble(row["price"]));
                }
                else if (sortComboBox.SelectedIndex == 3)
                {
                    rows = rows.OrderBy(row => Convert.ToInt32(row["warehouse"]));
                }
                else if (sortComboBox.SelectedIndex == 4)
                {
                    rows = rows.OrderByDescending(row => Convert.ToInt32(row["warehouse"]));
                }
                else
                {
                    rows = rows.OrderBy(row => Convert.ToString(row["name"]));
                }
            }
            else
            {
                rows = rows.OrderBy(row => Convert.ToString(row["name"]));
            }

            RenderGoods(rows.ToList());
        }

        private static string GetSearchText(DataRow row)
        {
            return (
                Convert.ToString(row["article"]) + " " +
                Convert.ToString(row["name"]) + " " +
                Convert.ToString(row["supplier_name"]) + " " +
                Convert.ToString(row["manufacturer_name"]) + " " +
                Convert.ToString(row["category_name"]) + " " +
                Convert.ToString(row["describe"])).ToLower();
        }

        private void RenderGoods(List<DataRow> rows)
        {
            productsPanel.SuspendLayout();
            productsPanel.Controls.Clear();
            countLabel.Text = "Найдено: " + rows.Count;

            if (rows.Count == 0)
            {
                Label emptyLabel = new Label();
                emptyLabel.AutoSize = true;
                emptyLabel.Margin = new Padding(12);
                emptyLabel.Text = "Товары не найдены.";
                productsPanel.Controls.Add(emptyLabel);
            }
            else
            {
                foreach (DataRow row in rows)
                {
                    productsPanel.Controls.Add(new GoodsCard(row, CanManageProducts, DeleteProduct));
                }
            }

            productsPanel.ResumeLayout();
        }

        private void DeleteProduct(string article)
        {
            if (!CanManageProducts)
            {
                return;
            }

            try
            {
                MainDataSet.ordersDataTable orders = new MainDataSetTableAdapters.ordersTableAdapter().GetData();
                foreach (DataRow row in orders.Rows)
                {
                    if (Convert.ToString(row["article"]) == article)
                    {
                        MessageBox.Show("Этот товар используется в заказах, удалить его нельзя.", "Удаление запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (MessageBox.Show("Удалить товар с артикулом " + article + "?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                MainDataSetTableAdapters.goodsTableAdapter adapter = new MainDataSetTableAdapters.goodsTableAdapter();
                MainDataSet.goodsDataTable table = adapter.GetData();

                foreach (DataRow row in table.Rows)
                {
                    if (Convert.ToString(row["article"]) == article)
                    {
                        row.Delete();
                        break;
                    }
                }

                adapter.Update(table);
                LoadGoods();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось удалить товар.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyGoodsView();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyGoodsView();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyGoodsView();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadGoods();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            using (AddGoodWindow form = new AddGoodWindow())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LoadGoods();
                }
            }
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            using (RequestsWindow form = new RequestsWindow(currentRole))
            {
                form.ShowDialog(this);
            }
        }
    }
}
