namespace DriveStockExam
{
    partial class GoodsCard
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.articleLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.measurementLabel = new System.Windows.Forms.Label();
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.saleLabel = new System.Windows.Forms.Label();
            this.priceTitleLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.oldPriceLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productPictureBox
            // 
            this.productPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPictureBox.Location = new System.Drawing.Point(9, 8);
            this.productPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(128, 117);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(148, 8);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(376, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Наименование";
            // 
            // articleLabel
            // 
            this.articleLabel.Location = new System.Drawing.Point(148, 38);
            this.articleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.articleLabel.Name = "articleLabel";
            this.articleLabel.Size = new System.Drawing.Size(180, 14);
            this.articleLabel.TabIndex = 2;
            this.articleLabel.Text = "Артикул";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Location = new System.Drawing.Point(148, 55);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(376, 14);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Категория";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Location = new System.Drawing.Point(148, 71);
            this.manufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(376, 14);
            this.manufacturerLabel.TabIndex = 4;
            this.manufacturerLabel.Text = "Производитель";
            // 
            // supplierLabel
            // 
            this.supplierLabel.Location = new System.Drawing.Point(148, 88);
            this.supplierLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(376, 14);
            this.supplierLabel.TabIndex = 5;
            this.supplierLabel.Text = "Поставщик";
            // 
            // measurementLabel
            // 
            this.measurementLabel.Location = new System.Drawing.Point(148, 104);
            this.measurementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.measurementLabel.Name = "measurementLabel";
            this.measurementLabel.Size = new System.Drawing.Size(142, 14);
            this.measurementLabel.TabIndex = 6;
            this.measurementLabel.Text = "Ед. изм.";
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.Location = new System.Drawing.Point(300, 104);
            this.warehouseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(135, 14);
            this.warehouseLabel.TabIndex = 7;
            this.warehouseLabel.Text = "Остаток";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(148, 120);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(376, 27);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Описание";
            // 
            // saleLabel
            // 
            this.saleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saleLabel.Location = new System.Drawing.Point(542, 8);
            this.saleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saleLabel.Name = "saleLabel";
            this.saleLabel.Size = new System.Drawing.Size(90, 29);
            this.saleLabel.TabIndex = 9;
            this.saleLabel.Text = "Скидка";
            this.saleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceTitleLabel
            // 
            this.priceTitleLabel.AutoSize = true;
            this.priceTitleLabel.Location = new System.Drawing.Point(540, 48);
            this.priceTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceTitleLabel.Name = "priceTitleLabel";
            this.priceTitleLabel.Size = new System.Drawing.Size(36, 13);
            this.priceTitleLabel.TabIndex = 10;
            this.priceTitleLabel.Text = "Цена:";
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(540, 64);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(112, 16);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "0,00 руб.";
            // 
            // oldPriceLabel
            // 
            this.oldPriceLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPriceLabel.Location = new System.Drawing.Point(540, 81);
            this.oldPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oldPriceLabel.Name = "oldPriceLabel";
            this.oldPriceLabel.Size = new System.Drawing.Size(112, 14);
            this.oldPriceLabel.TabIndex = 12;
            this.oldPriceLabel.Text = "0,00 руб.";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Blue;
            this.deleteButton.Location = new System.Drawing.Point(543, 104);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 19);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // GoodsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.oldPriceLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceTitleLabel);
            this.Controls.Add(this.saleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.warehouseLabel);
            this.Controls.Add(this.measurementLabel);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.articleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.productPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GoodsCard";
            this.Size = new System.Drawing.Size(648, 155);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label articleLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label measurementLabel;
        private System.Windows.Forms.Label warehouseLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label saleLabel;
        private System.Windows.Forms.Label priceTitleLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label oldPriceLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}
