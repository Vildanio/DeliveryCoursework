namespace DeliveryProject
{
    partial class ProductCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            priceLabel = new Label();
            countLabel = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(8, 8);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(8, 37);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(41, 20);
            priceLabel.TabIndex = 1;
            priceLabel.Text = "Price";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(8, 66);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(48, 20);
            countLabel.TabIndex = 2;
            countLabel.Text = "Count";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(countLabel);
            Controls.Add(priceLabel);
            Controls.Add(nameLabel);
            Name = "ProductCard";
            Size = new Size(62, 86);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label priceLabel;
        private Label countLabel;
    }
}
