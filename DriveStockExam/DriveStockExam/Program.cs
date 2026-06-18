using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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
        public static readonly Color SecondaryBackColor = ColorTranslator.FromHtml("#00FFFF");
        public static readonly Color AccentColor = ColorTranslator.FromHtml("#0000FF");
        public static readonly Color HighSaleColor = ColorTranslator.FromHtml("#008080");
        public static readonly Font MainFont = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);

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
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Icon = GetAppIcon();
        }

        public static void ApplyHeaderStyle(Panel panel)
        {
        }

        public static void ApplyAccentButton(Button button)
        {
            ApplyButtonBaseStyle(button, AccentColor, Color.White);
        }

        public static void ApplySecondaryButton(Button button)
        {
            ApplyButtonBaseStyle(button, AccentColor, Color.White);
        }

        public static void ApplyPlainButton(Button button)
        {
            ApplyButtonBaseStyle(button, AccentColor, Color.White);
        }

        private static void ApplyButtonBaseStyle(Button button, Color backColor, Color foreColor)
        {
            button.Cursor = Cursors.Hand;
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.MinimumSize = new Size(button.MinimumSize.Width, 28);
            if (button.Height < 28)
            {
                button.Height = 28;
            }
        }

        public static void ApplyGridStyle(DataGridView gridView)
        {
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
                // Если файл .ico поврежден или имеет неверный формат, пробуем собрать иконку из PNG-логотипа.
            }

            try
            {
                Icon icon = CreateIconFromImage("icon.png");
                if (icon != null)
                {
                    return icon;
                }
            }
            catch (Exception)
            {
                // Если иконка не загрузилась, используем стандартную.
            }

            return SystemIcons.Application;
        }

        private static Icon CreateIconFromImage(string fileName)
        {
            string path = GetAssetPath(fileName);
            if (!File.Exists(path))
            {
                return null;
            }

            using (Bitmap bitmap = new Bitmap(path))
            {
                IntPtr handle = bitmap.GetHicon();
                try
                {
                    using (Icon icon = Icon.FromHandle(handle))
                    {
                        return (Icon)icon.Clone();
                    }
                }
                finally
                {
                    DestroyIcon(handle);
                }
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

    }
}
