using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DriveStockExam
{
    public partial class RequestsWindow : Form
    {
        private readonly int currentRole;

        public RequestsWindow()
            : this(Program.GuestRoleId)
        {
        }

        public RequestsWindow(int roleId)
        {
            InitializeComponent();
            currentRole = roleId;
            Program.ApplyFormStyle(this);
            Program.ApplyHeaderStyle(headerPanel);
            toolsPanel.BackColor = Program.MainBackColor;
            Program.ApplyAccentButton(addOrderButton);
            Program.ApplyPlainButton(editOrderButton);
            Program.ApplyPlainButton(deleteOrderButton);
            Program.ApplyPlainButton(refreshButton);
            Program.ApplyPlainButton(backButton);
            Program.ApplyGridStyle(ordersGridView);
        }

        private bool CanManageOrders
        {
            get { return currentRole == Program.AdministratorRoleId; }
        }

        private void RequestsWindow_Load(object sender, EventArgs e)
        {
            addOrderButton.Visible = CanManageOrders;
            editOrderButton.Visible = CanManageOrders;
            deleteOrderButton.Visible = CanManageOrders;
            LoadRequests();
        }

        private void LoadRequests()
        {
            try
            {
                MainDataSet.ordersDataTable orders = new MainDataSetTableAdapters.ordersTableAdapter().GetData();
                MainDataSet.goodsDataTable goods = new MainDataSetTableAdapters.goodsTableAdapter().GetData();
                MainDataSet.sale_pointsDataTable salePoints = new MainDataSetTableAdapters.sale_pointsTableAdapter().GetData();
                MainDataSet.usersDataTable users = new MainDataSetTableAdapters.usersTableAdapter().GetData();
                MainDataSet.statusesDataTable statuses = new MainDataSetTableAdapters.statusesTableAdapter().GetData();
                ConfigureGrid();
                ordersGridView.Rows.Clear();

                Dictionary<string, string> productNames = new Dictionary<string, string>();
                Dictionary<int, string> salePointNames = new Dictionary<int, string>();
                Dictionary<string, string> clientNames = new Dictionary<string, string>();
                Dictionary<int, string> statusNames = new Dictionary<int, string>();

                foreach (MainDataSet.goodsRow row in goods)
                    productNames[row.article] = Convert.ToString(row["name"]);

                foreach (MainDataSet.sale_pointsRow row in salePoints)
                    salePointNames[row.id] = Convert.ToString(row["address"]);

                foreach (MainDataSet.usersRow row in users)
                {
                    string fullName = Convert.ToString(row["full_name"]);
                    clientNames[row.login] = string.IsNullOrWhiteSpace(fullName) ? row.login : fullName;
                }

                foreach (MainDataSet.statusesRow row in statuses)
                    statusNames[row.id] = Convert.ToString(row["name"]);

                foreach (MainDataSet.ordersRow row in orders)
                {
                    ordersGridView.Rows.Add(
                        row.id,
                        GetString(productNames, row.IsarticleNull() ? null : row.article),
                        row.IscountNull() ? string.Empty : Convert.ToString(row.count),
                        GetDateText(row.Ispurchase_dateNull() ? (DateTime?)null : row.purchase_date),
                        GetDateText(row.Isdelivery_dateNull() ? (DateTime?)null : row.delivery_date),
                        GetString(salePointNames, row.Issale_pointsNull() ? (int?)null : row.sale_points),
                        GetString(clientNames, row.IsloginNull() ? null : row.login),
                        row.IscodeNull() ? string.Empty : Convert.ToString(Convert.ToInt32(row.code)),
                        GetString(statusNames, row.IsstatusNull() ? (int?)null : row.status));
                }

                countLabel.Text = "Заказов: " + orders.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить список заказов.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            if (ordersGridView.Columns.Count > 0)
            {
                return;
            }

            ordersGridView.Columns.Add("idColumn", "№");
            ordersGridView.Columns.Add("productColumn", "Товар");
            ordersGridView.Columns.Add("countColumn", "Количество");
            ordersGridView.Columns.Add("purchaseDateColumn", "Дата заказа");
            ordersGridView.Columns.Add("deliveryDateColumn", "Дата выдачи");
            ordersGridView.Columns.Add("salePointColumn", "Пункт выдачи");
            ordersGridView.Columns.Add("clientColumn", "Клиент");
            ordersGridView.Columns.Add("codeColumn", "Код");
            ordersGridView.Columns.Add("statusColumn", "Статус");
        }

        private int? GetSelectedOrderId()
        {
            if (ordersGridView.CurrentRow == null)
            {
                return null;
            }

            object value = ordersGridView.CurrentRow.Cells[0].Value;
            return value == null || value == DBNull.Value ? (int?)null : Convert.ToInt32(value);
        }

        private static string GetString(Dictionary<string, string> values, string key)
        {
            return string.IsNullOrWhiteSpace(key) || !values.ContainsKey(key) ? string.Empty : values[key];
        }

        private static string GetString(Dictionary<int, string> values, int? key)
        {
            return !key.HasValue || !values.ContainsKey(key.Value) ? string.Empty : values[key.Value];
        }

        private static string GetDateText(DateTime? value)
        {
            return value.HasValue ? value.Value.ToShortDateString() : string.Empty;
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            OpenRequestWindow(null);
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedOrderId();
            if (id == null)
            {
                MessageBox.Show("Выберите заказ для редактирования.", "Заказ не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenRequestWindow(id.Value);
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedOrderId();
            if (id == null)
            {
                MessageBox.Show("Выберите заказ для удаления.", "Заказ не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Удалить заказ № " + id.Value + "?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                MainDataSetTableAdapters.ordersTableAdapter adapter = new MainDataSetTableAdapters.ordersTableAdapter();
                MainDataSet.ordersDataTable table = adapter.GetData();

                foreach (MainDataSet.ordersRow row in table)
                {
                    if (row.id == id.Value)
                    {
                        row.Delete();
                        break;
                    }
                }

                adapter.Update(table);
                LoadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось удалить заказ.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenRequestWindow(int? id)
        {
            if (!CanManageOrders)
            {
                return;
            }

            using (RequestWindow form = new RequestWindow(id))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LoadRequests();
                }
            }
        }
    }
}
