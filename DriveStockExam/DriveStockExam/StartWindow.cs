using System;
using System.Windows.Forms;

namespace DriveStockExam
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
            Program.ApplyFormStyle(this);
            Program.ApplyHeaderStyle(headerPanel);
            Program.ApplyAccentButton(loginButton);
            Program.ApplySecondaryButton(guestButton);
        }

        private void StartWindow_Load(object sender, EventArgs e)
        {
            Program.SetLogo(logoPictureBox);
            titleLabel.Text = Text;
            logoPictureBox.Visible = logoPictureBox.Image != null;
            passwordTextBox.UseSystemPasswordChar = true;
            loginTextBox.Select();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (login == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Введите логин и пароль.", "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MainDataSetTableAdapters.usersTableAdapter adapter = new MainDataSetTableAdapters.usersTableAdapter();
                MainDataSet.usersDataTable users = adapter.GetData();

                foreach (MainDataSet.usersRow row in users)
                {
                    if (row.login == login && Convert.ToString(row["password"]) == password)
                    {
                        OpenGoods(row.role);
                        return;
                    }
                }

                MessageBox.Show("Пользователь не найден.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось выполнить вход.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            OpenGoods(Program.GuestRoleId);
        }

        private void OpenGoods(int roleId)
        {
            Hide();

            using (GoodsWindow form = new GoodsWindow(roleId))
            {
                form.ShowDialog(this);
            }

            passwordTextBox.Clear();
            Show();
            Activate();
            loginTextBox.Select();
        }
    }
}
