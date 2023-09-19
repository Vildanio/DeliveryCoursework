namespace DeliveryProject
{
    partial class ProductList
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
            productPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // productPanel
            // 
            productPanel.AutoScroll = true;
            productPanel.Dock = DockStyle.Fill;
            productPanel.FlowDirection = FlowDirection.TopDown;
            productPanel.Location = new Point(0, 0);
            productPanel.Name = "productPanel";
            productPanel.Size = new Size(435, 382);
            productPanel.TabIndex = 1;
            productPanel.WrapContents = false;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productPanel);
            Name = "ProductList";
            Size = new Size(435, 382);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel productPanel;
    }
}
