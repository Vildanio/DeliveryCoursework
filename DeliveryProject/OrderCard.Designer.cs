namespace DeliveryProject
{
    partial class OrderCard
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
            clientNameLabel = new Label();
            idLabel = new Label();
            buttonsPanel = new FlowLayoutPanel();
            statusLabel = new Label();
            productsPanel = new FlowLayoutPanel();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clientNameLabel.Location = new Point(3, 0);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new Size(91, 20);
            clientNameLabel.TabIndex = 4;
            clientNameLabel.Text = "ClientName";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(100, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(22, 20);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id";
            // 
            // buttonsPanel
            // 
            buttonsPanel.AutoSize = true;
            buttonsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonsPanel.Controls.Add(clientNameLabel);
            buttonsPanel.Controls.Add(idLabel);
            buttonsPanel.Controls.Add(statusLabel);
            buttonsPanel.Dock = DockStyle.Top;
            buttonsPanel.Location = new Point(0, 0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(250, 20);
            buttonsPanel.TabIndex = 6;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(128, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(49, 20);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "Status";
            // 
            // productsPanel
            // 
            productsPanel.AutoSize = true;
            productsPanel.FlowDirection = FlowDirection.TopDown;
            productsPanel.Location = new Point(3, 44);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(244, 33);
            productsPanel.TabIndex = 3;
            productsPanel.WrapContents = false;
            // 
            // OrderCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(buttonsPanel);
            Controls.Add(productsPanel);
            Name = "OrderCard";
            Size = new Size(250, 80);
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label clientNameLabel;
        private Label idLabel;
        private FlowLayoutPanel buttonsPanel;
        private Label statusLabel;
        private FlowLayoutPanel productsPanel;
    }
}
