namespace DemoMebel
{
    partial class AddGoodWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGoodWindow));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.articleLabel = new System.Windows.Forms.Label();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.measurementLabel = new System.Windows.Forms.Label();
            this.measurementTextBox = new System.Windows.Forms.TextBox();
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.warehouseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saleLabel = new System.Windows.Forms.Label();
            this.saleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.pictureNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Cyan;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(700, 47);
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
            this.titleLabel.Size = new System.Drawing.Size(200, 22);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Добавление товара";
            // 
            // articleLabel
            // 
            this.articleLabel.AutoSize = true;
            this.articleLabel.Location = new System.Drawing.Point(16, 62);
            this.articleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.articleLabel.Name = "articleLabel";
            this.articleLabel.Size = new System.Drawing.Size(48, 13);
            this.articleLabel.TabIndex = 1;
            this.articleLabel.Text = "Артикул";
            // 
            // articleTextBox
            // 
            this.articleTextBox.Location = new System.Drawing.Point(20, 79);
            this.articleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(128, 20);
            this.articleTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(161, 62);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Наименование";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(164, 79);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nameTextBox.Size = new System.Drawing.Size(316, 44);
            this.nameTextBox.TabIndex = 4;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(16, 132);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 13);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Категория";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(20, 149);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(211, 21);
            this.categoryComboBox.TabIndex = 6;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(247, 132);
            this.manufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(86, 13);
            this.manufacturerLabel.TabIndex = 7;
            this.manufacturerLabel.Text = "Производитель";
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(250, 149);
            this.manufacturerComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(230, 21);
            this.manufacturerComboBox.TabIndex = 8;
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(16, 178);
            this.supplierLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(65, 13);
            this.supplierLabel.TabIndex = 9;
            this.supplierLabel.Text = "Поставщик";
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(20, 195);
            this.supplierComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(211, 21);
            this.supplierComboBox.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(247, 178);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 13);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Цена";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(250, 195);
            this.priceNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(105, 20);
            this.priceNumericUpDown.TabIndex = 12;
            this.priceNumericUpDown.ThousandsSeparator = true;
            // 
            // measurementLabel
            // 
            this.measurementLabel.AutoSize = true;
            this.measurementLabel.Location = new System.Drawing.Point(373, 178);
            this.measurementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.measurementLabel.Name = "measurementLabel";
            this.measurementLabel.Size = new System.Drawing.Size(49, 13);
            this.measurementLabel.TabIndex = 13;
            this.measurementLabel.Text = "Ед. изм.";
            // 
            // measurementTextBox
            // 
            this.measurementTextBox.Location = new System.Drawing.Point(376, 195);
            this.measurementTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.measurementTextBox.Name = "measurementTextBox";
            this.measurementTextBox.Size = new System.Drawing.Size(104, 20);
            this.measurementTextBox.TabIndex = 14;
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.Location = new System.Drawing.Point(16, 224);
            this.warehouseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(103, 13);
            this.warehouseLabel.TabIndex = 15;
            this.warehouseLabel.Text = "Остаток на складе";
            // 
            // warehouseNumericUpDown
            // 
            this.warehouseNumericUpDown.Location = new System.Drawing.Point(20, 242);
            this.warehouseNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.warehouseNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.warehouseNumericUpDown.Name = "warehouseNumericUpDown";
            this.warehouseNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.warehouseNumericUpDown.TabIndex = 16;
            // 
            // saleLabel
            // 
            this.saleLabel.AutoSize = true;
            this.saleLabel.Location = new System.Drawing.Point(161, 224);
            this.saleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saleLabel.Name = "saleLabel";
            this.saleLabel.Size = new System.Drawing.Size(58, 13);
            this.saleLabel.TabIndex = 17;
            this.saleLabel.Text = "Скидка, %";
            // 
            // saleNumericUpDown
            // 
            this.saleNumericUpDown.Location = new System.Drawing.Point(164, 242);
            this.saleNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saleNumericUpDown.Name = "saleNumericUpDown";
            this.saleNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.saleNumericUpDown.TabIndex = 18;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(16, 271);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.descriptionLabel.TabIndex = 19;
            this.descriptionLabel.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(20, 288);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(461, 90);
            this.descriptionTextBox.TabIndex = 20;
            // 
            // productPictureBox
            // 
            this.productPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPictureBox.Location = new System.Drawing.Point(500, 79);
            this.productPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(180, 124);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 21;
            this.productPictureBox.TabStop = false;
            // 
            // selectImageButton
            // 
            this.selectImageButton.BackColor = System.Drawing.Color.Blue;
            this.selectImageButton.Location = new System.Drawing.Point(500, 211);
            this.selectImageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(180, 22);
            this.selectImageButton.TabIndex = 22;
            this.selectImageButton.Text = "Выбрать изображение";
            this.selectImageButton.UseVisualStyleBackColor = false;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // pictureNameLabel
            // 
            this.pictureNameLabel.Location = new System.Drawing.Point(500, 239);
            this.pictureNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pictureNameLabel.Name = "pictureNameLabel";
            this.pictureNameLabel.Size = new System.Drawing.Size(180, 27);
            this.pictureNameLabel.TabIndex = 23;
            this.pictureNameLabel.Text = "Изображение не выбрано";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Blue;
            this.saveButton.Location = new System.Drawing.Point(20, 390);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 25);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Blue;
            this.cancelButton.Location = new System.Drawing.Point(165, 390);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 25);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddGoodWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureNameLabel);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.saleNumericUpDown);
            this.Controls.Add(this.saleLabel);
            this.Controls.Add(this.warehouseNumericUpDown);
            this.Controls.Add(this.warehouseLabel);
            this.Controls.Add(this.measurementTextBox);
            this.Controls.Add(this.measurementLabel);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.manufacturerComboBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.articleTextBox);
            this.Controls.Add(this.articleLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGoodWindow";
            this.Text = "Добавление товара";
            this.Load += new System.EventHandler(this.AddGoodWindow_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label articleLabel;
        private System.Windows.Forms.TextBox articleTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label measurementLabel;
        private System.Windows.Forms.TextBox measurementTextBox;
        private System.Windows.Forms.Label warehouseLabel;
        private System.Windows.Forms.NumericUpDown warehouseNumericUpDown;
        private System.Windows.Forms.Label saleLabel;
        private System.Windows.Forms.NumericUpDown saleNumericUpDown;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Label pictureNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
