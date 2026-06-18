namespace DemoMebel
{
    partial class RequestWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestWindow));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.articleLabel = new System.Windows.Forms.Label();
            this.articleComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.salePointLabel = new System.Windows.Forms.Label();
            this.salePointComboBox = new System.Windows.Forms.ComboBox();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.deliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countLabel = new System.Windows.Forms.Label();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Cyan;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(620, 47);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(14, 14);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(194, 22);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Добавление заказа";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(15, 60);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(41, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Номер";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(18, 77);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(106, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // articleLabel
            // 
            this.articleLabel.AutoSize = true;
            this.articleLabel.Location = new System.Drawing.Point(141, 60);
            this.articleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.articleLabel.Name = "articleLabel";
            this.articleLabel.Size = new System.Drawing.Size(38, 13);
            this.articleLabel.TabIndex = 3;
            this.articleLabel.Text = "Товар";
            // 
            // articleComboBox
            // 
            this.articleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articleComboBox.FormattingEnabled = true;
            this.articleComboBox.Location = new System.Drawing.Point(144, 77);
            this.articleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.articleComboBox.Name = "articleComboBox";
            this.articleComboBox.Size = new System.Drawing.Size(452, 21);
            this.articleComboBox.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(15, 107);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 13);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Статус";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(18, 124);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(166, 21);
            this.statusComboBox.TabIndex = 6;
            // 
            // salePointLabel
            // 
            this.salePointLabel.AutoSize = true;
            this.salePointLabel.Location = new System.Drawing.Point(201, 107);
            this.salePointLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salePointLabel.Name = "salePointLabel";
            this.salePointLabel.Size = new System.Drawing.Size(77, 13);
            this.salePointLabel.TabIndex = 7;
            this.salePointLabel.Text = "Пункт выдачи";
            // 
            // salePointComboBox
            // 
            this.salePointComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salePointComboBox.FormattingEnabled = true;
            this.salePointComboBox.Location = new System.Drawing.Point(204, 124);
            this.salePointComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.salePointComboBox.Name = "salePointComboBox";
            this.salePointComboBox.Size = new System.Drawing.Size(392, 21);
            this.salePointComboBox.TabIndex = 8;
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Location = new System.Drawing.Point(15, 153);
            this.purchaseDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(72, 13);
            this.purchaseDateLabel.TabIndex = 9;
            this.purchaseDateLabel.Text = "Дата заказа";
            // 
            // purchaseDateTimePicker
            // 
            this.purchaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.purchaseDateTimePicker.Location = new System.Drawing.Point(18, 170);
            this.purchaseDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.purchaseDateTimePicker.Name = "purchaseDateTimePicker";
            this.purchaseDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.purchaseDateTimePicker.TabIndex = 10;
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(141, 153);
            this.deliveryDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(73, 13);
            this.deliveryDateLabel.TabIndex = 11;
            this.deliveryDateLabel.Text = "Дата выдачи";
            // 
            // deliveryDateTimePicker
            // 
            this.deliveryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deliveryDateTimePicker.Location = new System.Drawing.Point(144, 170);
            this.deliveryDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            this.deliveryDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.deliveryDateTimePicker.TabIndex = 12;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(267, 153);
            this.countLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(66, 13);
            this.countLabel.TabIndex = 13;
            this.countLabel.Text = "Количество";
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Location = new System.Drawing.Point(270, 170);
            this.countNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.countNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.countNumericUpDown.TabIndex = 14;
            this.countNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(15, 200);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(43, 13);
            this.clientLabel.TabIndex = 15;
            this.clientLabel.Text = "Клиент";
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(18, 217);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(343, 21);
            this.clientComboBox.TabIndex = 16;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(378, 200);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(81, 13);
            this.codeLabel.TabIndex = 17;
            this.codeLabel.Text = "Код получения";
            // 
            // codeNumericUpDown
            // 
            this.codeNumericUpDown.Location = new System.Drawing.Point(381, 217);
            this.codeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.codeNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.codeNumericUpDown.Name = "codeNumericUpDown";
            this.codeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.codeNumericUpDown.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Blue;
            this.saveButton.Location = new System.Drawing.Point(18, 260);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 25);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Blue;
            this.cancelButton.Location = new System.Drawing.Point(164, 260);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 25);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RequestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 300);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.codeNumericUpDown);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.countNumericUpDown);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.deliveryDateTimePicker);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.purchaseDateTimePicker);
            this.Controls.Add(this.purchaseDateLabel);
            this.Controls.Add(this.salePointComboBox);
            this.Controls.Add(this.salePointLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.articleComboBox);
            this.Controls.Add(this.articleLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestWindow";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.RequestWindow_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label articleLabel;
        private System.Windows.Forms.ComboBox articleComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label salePointLabel;
        private System.Windows.Forms.ComboBox salePointComboBox;
        private System.Windows.Forms.Label purchaseDateLabel;
        private System.Windows.Forms.DateTimePicker purchaseDateTimePicker;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.DateTimePicker deliveryDateTimePicker;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.NumericUpDown codeNumericUpDown;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
