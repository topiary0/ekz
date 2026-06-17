using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DriveStockExam
{
    internal static class Program
    {
        public const int GuestRoleId = 0;
        public const int AdministratorRoleId = 1;
        public const int ManagerRoleId = 2;
        public const int ClientRoleId = 3;

        public static readonly Color MainBackColor = Color.White;
        public static readonly Color SecondaryBackColor = ColorTranslator.FromHtml("#6A5ACD");
        public static readonly Color AccentColor = ColorTranslator.FromHtml("#4B0082");
        public static readonly Color HighSaleColor = ColorTranslator.FromHtml("#483D8B");
        public static readonly Font MainFont = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartWindow());
        }

        public static string GetAssetPath(string fileName)
        {
            return Path.Combine(Application.StartupPath, "Assets", fileName);
        }

        public static void ApplyFormStyle(Form form)
        {
            form.BackColor = MainBackColor;
            form.ForeColor = Color.Black;
            form.Font = MainFont;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Icon = GetAppIcon();
        }

        public static void ApplyHeaderStyle(Panel panel)
        {
            panel.BackColor = SecondaryBackColor;
        }

        public static void ApplyAccentButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = AccentColor;
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
        }

        public static void ApplySecondaryButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = SecondaryBackColor;
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
        }

        public static void ApplyPlainButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = SecondaryBackColor;
            button.BackColor = Color.White;
            button.ForeColor = AccentColor;
            button.Cursor = Cursors.Hand;
        }

        public static void ApplyGridStyle(DataGridView gridView)
        {
            gridView.BackgroundColor = MainBackColor;
            gridView.BorderStyle = BorderStyle.FixedSingle;
            gridView.EnableHeadersVisualStyles = false;
            gridView.GridColor = SecondaryBackColor;
            gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            gridView.ColumnHeadersDefaultCellStyle.BackColor = SecondaryBackColor;
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridView.DefaultCellStyle.Font = MainFont;
            gridView.DefaultCellStyle.SelectionBackColor = AccentColor;
            gridView.DefaultCellStyle.SelectionForeColor = Color.White;
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
        }

        public static void SetLogo(PictureBox pictureBox)
        {
            if (!SetPicture(pictureBox, "icon.png"))
            {
                SetPicture(pictureBox, "icon.jpg");
            }
        }

        public static void SetPlaceholder(PictureBox pictureBox)
        {
            SetPicture(pictureBox, "picture.png");
        }

        public static bool SetPicture(PictureBox pictureBox, string fileName)
        {
            Image image = LoadImage(fileName);
            if (image == null)
            {
                return false;
            }

            pictureBox.ImageLocation = string.Empty;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = image;
            return true;
        }

        public static Image LoadImage(string fileName)
        {
            string path = Path.IsPathRooted(fileName) ? fileName : GetAssetPath(fileName);
            if (!File.Exists(path))
            {
                return null;
            }

            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image image = Image.FromStream(stream))
            {
                return new Bitmap(image);
            }
        }

        private static Icon GetAppIcon()
        {
            try
            {
                string path = GetAssetPath("icon.ico");
                if (File.Exists(path))
                {
                    return new Icon(path);
                }
            }
            catch (Exception)
            {
                // Если иконка не загрузилась, используем стандартную
            }

            return SystemIcons.Application;
        }
    }
}
