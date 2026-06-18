using System;
using System.Data;
using System.Windows.Forms;

namespace DemoMebel
{
    public partial class RequestWindow : Form
    {
        private readonly int? editingId;

        public RequestWindow()
            : this(null)
        {
        }

        public RequestWindow(int? id)
        {
            InitializeComponent();
            editingId = id;
            Program.ApplyFormStyle(this);
            Program.ApplyHeaderStyle(headerPanel);
            Program.ApplyAccentButton(saveButton);
            Program.ApplyPlainButton(cancelButton);
            articleComboBox.Format += articleComboBox_Format;
            clientComboBox.Format += clientComboBox_Format;
        }

        private bool IsEditMode
        {
            get { return editingId.HasValue; }
        }

        private void RequestWindow_Load(object sender, EventArgs e)
        {
            Text = IsEditMode ? "Редактирование заказа" : "Добавление заказа";
            titleLabel.Text = IsEditMode ? "Редактирование заказа" : "Добавление заказа";

            try
            {
                articleComboBox.DataSource = new MainDataSetTableAdapters.goodsTableAdapter().GetData();
                articleComboBox.DisplayMember = "name";
                articleComboBox.ValueMember = "article";

                statusComboBox.DataSource = new MainDataSetTableAdapters.statusesTableAdapter().GetData();
                statusComboBox.DisplayMember = "name";
                statusComboBox.ValueMember = "id";

                salePointComboBox.DataSource = new MainDataSetTableAdapters.sale_pointsTableAdapter().GetData();
                salePointComboBox.DisplayMember = "address";
                salePointComboBox.ValueMember = "id";

                clientComboBox.DataSource = new MainDataSetTableAdapters.usersTableAdapter().GetData();
                clientComboBox.DisplayMember = "full_name";
                clientComboBox.ValueMember = "login";

                if (IsEditMode)
                {
                    LoadOrder();
                }
                else
                {
                    idTextBox.Text = GetNextOrderId().ToString();
                    codeNumericUpDown.Value = GetNextOrderCode();
                    countNumericUpDown.Value = 1;
                    purchaseDateTimePicker.Value = DateTime.Today;
                    deliveryDateTimePicker.Value = DateTime.Today.AddDays(3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить данные формы заказа.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private static void articleComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRowView row = e.ListItem as DataRowView;
            if (row != null)
            {
                e.Value = Convert.ToString(row["article"]) + " | " + Convert.ToString(row["name"]);
            }
        }

        private static void clientComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRowView row = e.ListItem as DataRowView;
            if (row != null)
            {
                string fullName = Convert.ToString(row["full_name"]);
                e.Value = string.IsNullOrWhiteSpace(fullName) ? Convert.ToString(row["login"]) : fullName;
            }
        }

        private int GetNextOrderId()
        {
            int maxId = 0;
            MainDataSet.ordersDataTable orders = new MainDataSetTableAdapters.ordersTableAdapter().GetData();

            foreach (DataRow row in orders.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                if (id > maxId)
                {
                    maxId = id;
                }
            }

            return maxId + 1;
        }

        private decimal GetNextOrderCode()
        {
            int maxCode = 900;
            MainDataSet.ordersDataTable orders = new MainDataSetTableAdapters.ordersTableAdapter().GetData();

            foreach (MainDataSet.ordersRow row in orders)
            {
                if (row.IscodeNull())
                {
                    continue;
                }

                int code = Convert.ToInt32(row.code);
                if (code > maxCode)
                {
                    maxCode = code;
                }
            }

            return maxCode + 1;
        }

        private void LoadOrder()
        {
            MainDataSet.ordersDataTable orders = new MainDataSetTableAdapters.ordersTableAdapter().GetData();

            foreach (MainDataSet.ordersRow row in orders)
            {
                if (row.id != editingId.Value)
                {
                    continue;
                }

                idTextBox.Text = row.id.ToString();
                countNumericUpDown.Value = row.IscountNull() ? countNumericUpDown.Minimum : Convert.ToDecimal(row.count);
                codeNumericUpDown.Value = row.IscodeNull() ? codeNumericUpDown.Minimum : Convert.ToDecimal(row.code);
                purchaseDateTimePicker.Value = row.Ispurchase_dateNull() ? DateTime.Today : row.purchase_date;
                deliveryDateTimePicker.Value = row.Isdelivery_dateNull() ? purchaseDateTimePicker.Value : row.delivery_date;

                if (!row.IsarticleNull())
                {
                    articleComboBox.SelectedValue = row.article;
                }

                if (!row.IsstatusNull())
                {
                    statusComboBox.SelectedValue = row.status;
                }

                if (!row.Issale_pointsNull())
                {
                    salePointComboBox.SelectedValue = row.sale_points;
                }

                if (!row.IsloginNull())
                {
                    clientComboBox.SelectedValue = row.login;
                }

                return;
            }

            MessageBox.Show("Заказ не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateOrder())
            {
                return;
            }

            try
            {
                MainDataSetTableAdapters.ordersTableAdapter adapter = new MainDataSetTableAdapters.ordersTableAdapter();

                if (IsEditMode)
                {
                    MainDataSet.ordersDataTable table = adapter.GetData();

                    foreach (DataRow row in table.Rows)
                    {
                        if (Convert.ToInt32(row["id"]) != editingId.Value)
                        {
                            continue;
                        }

                        row["article"] = Convert.ToString(articleComboBox.SelectedValue);
                        row["count"] = Convert.ToInt32(countNumericUpDown.Value);
                        row["purchase_date"] = purchaseDateTimePicker.Value.Date;
                        row["delivery_date"] = deliveryDateTimePicker.Value.Date;
                        row["sale_points"] = Convert.ToInt32(salePointComboBox.SelectedValue);
                        row["login"] = Convert.ToString(clientComboBox.SelectedValue);
                        row["code"] = Convert.ToDouble(codeNumericUpDown.Value);
                        row["status"] = Convert.ToInt32(statusComboBox.SelectedValue);
                        break;
                    }

                    adapter.Update(table);
                }
                else
                {
                    adapter.Insert(
                        Convert.ToInt32(idTextBox.Text),
                        Convert.ToString(articleComboBox.SelectedValue),
                        Convert.ToInt32(countNumericUpDown.Value),
                        purchaseDateTimePicker.Value.Date,
                        deliveryDateTimePicker.Value.Date,
                        Convert.ToInt32(salePointComboBox.SelectedValue),
                        Convert.ToString(clientComboBox.SelectedValue),
                        Convert.ToInt32(codeNumericUpDown.Value),
                        Convert.ToInt32(statusComboBox.SelectedValue));
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить заказ.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateOrder()
        {
            if (articleComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите товар.", "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (statusComboBox.SelectedValue == null || salePointComboBox.SelectedValue == null || clientComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите статус, пункт выдачи и клиента.", "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (deliveryDateTimePicker.Value.Date < purchaseDateTimePicker.Value.Date)
            {
                MessageBox.Show("Дата выдачи не может быть раньше даты заказа.", "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
