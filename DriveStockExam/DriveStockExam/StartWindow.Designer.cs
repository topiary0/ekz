namespace DriveStockExam
{
    partial class StartWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.showPasswordButton = new System.Windows.Forms.Button();
            this.guestButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(0, 255, 255); // #00FFFF
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.logoPictureBox);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(363, 63);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(363, 63);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "ООО «DriveStockExam»";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(18, 10);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(48, 44);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(40, 85);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(44, 102);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(276, 20);
            this.loginTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(40, 131);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(44, 148);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(178, 24);
            this.passwordTextBox.TabIndex = 4;
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.BackColor = System.Drawing.Color.FromArgb(0, 0, 255);
            this.showPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordButton.FlatAppearance.BorderSize = 0;
            this.showPasswordButton.ForeColor = System.Drawing.Color.White;
            this.showPasswordButton.Location = new System.Drawing.Point(232, 146);
            this.showPasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(88, 28);
            this.showPasswordButton.TabIndex = 5;
            this.showPasswordButton.Text = "Показать";
            this.showPasswordButton.UseVisualStyleBackColor = false;
            this.showPasswordButton.Click += new System.EventHandler(this.showPasswordButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(0, 0, 255); // #0000FF
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.Location = new System.Drawing.Point(44, 184);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(274, 28);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // guestButton
            // 
            this.guestButton.BackColor = System.Drawing.Color.FromArgb(0, 0, 255); // #0000FF
            this.guestButton.ForeColor = System.Drawing.Color.White;
            this.guestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestButton.FlatAppearance.BorderSize = 0;
            this.guestButton.Location = new System.Drawing.Point(44, 216);
            this.guestButton.Margin = new System.Windows.Forms.Padding(2);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(274, 28);
            this.guestButton.TabIndex = 7;
            this.guestButton.Text = "Войти как гость";
            this.guestButton.UseVisualStyleBackColor = false;
            this.guestButton.Click += new System.EventHandler(this.guestButton_Click);
            // 
            // StartWindow
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255); // #FFFFFF
            this.ClientSize = new System.Drawing.Size(363, 268);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.showPasswordButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartWindow";
            this.Text = "DriveStockExam - вход";
            this.Load += new System.EventHandler(this.StartWindow_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button showPasswordButton;
        private System.Windows.Forms.Button guestButton;
    }
}