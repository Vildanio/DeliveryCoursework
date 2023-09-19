namespace DeliveryProject.RolePages
{
    partial class ClientPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productComboBox = new ComboBox();
            addProductButton = new Button();
            label1 = new Label();
            readyOrdersPanel = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            deliveredProductsPanel = new FlowLayoutPanel();
            orderButton = new Button();
            countBox = new NumericUpDown();
            productsPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)countBox).BeginInit();
            SuspendLayout();
            // 
            // productComboBox
            // 
            productComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(12, 15);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(151, 28);
            productComboBox.TabIndex = 0;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(12, 79);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(151, 29);
            addProductButton.TabIndex = 1;
            addProductButton.Text = "Добавить";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += AddProductButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 125);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 3;
            label1.Text = "Заказ";
            // 
            // readyOrdersPanel
            // 
            readyOrdersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            readyOrdersPanel.AutoScroll = true;
            readyOrdersPanel.AutoSize = true;
            readyOrdersPanel.BorderStyle = BorderStyle.FixedSingle;
            readyOrdersPanel.FlowDirection = FlowDirection.TopDown;
            readyOrdersPanel.Location = new Point(206, 49);
            readyOrdersPanel.Name = "readyOrdersPanel";
            readyOrdersPanel.Size = new Size(180, 343);
            readyOrdersPanel.TabIndex = 4;
            readyOrdersPanel.WrapContents = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(206, 15);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 5;
            label2.Text = "Выполняющиеся заказы";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(417, 18);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 7;
            label3.Text = "Выполненные заказы";
            // 
            // deliveredProductsPanel
            // 
            deliveredProductsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deliveredProductsPanel.AutoScroll = true;
            deliveredProductsPanel.AutoSize = true;
            deliveredProductsPanel.BorderStyle = BorderStyle.FixedSingle;
            deliveredProductsPanel.FlowDirection = FlowDirection.TopDown;
            deliveredProductsPanel.Location = new Point(408, 49);
            deliveredProductsPanel.Name = "deliveredProductsPanel";
            deliveredProductsPanel.Size = new Size(180, 343);
            deliveredProductsPanel.TabIndex = 6;
            deliveredProductsPanel.WrapContents = false;
            // 
            // orderButton
            // 
            orderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            orderButton.Location = new Point(12, 363);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(151, 29);
            orderButton.TabIndex = 8;
            orderButton.Text = "Заказать";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += OrderButton_Click;
            // 
            // countBox
            // 
            countBox.Location = new Point(13, 49);
            countBox.Name = "countBox";
            countBox.Size = new Size(150, 27);
            countBox.TabIndex = 9;
            // 
            // productsPanel
            // 
            productsPanel.AutoScroll = true;
            productsPanel.FlowDirection = FlowDirection.TopDown;
            productsPanel.Location = new Point(13, 161);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(150, 196);
            productsPanel.TabIndex = 10;
            productsPanel.WrapContents = false;
            // 
            // ClientPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 404);
            Controls.Add(productsPanel);
            Controls.Add(countBox);
            Controls.Add(orderButton);
            Controls.Add(label3);
            Controls.Add(deliveredProductsPanel);
            Controls.Add(label2);
            Controls.Add(readyOrdersPanel);
            Controls.Add(label1);
            Controls.Add(addProductButton);
            Controls.Add(productComboBox);
            Name = "ClientPage";
            Text = "ClientPage";
            ((System.ComponentModel.ISupportInitialize)countBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox productComboBox;
        private Button addProductButton;
        private Label label1;
        private FlowLayoutPanel readyOrdersPanel;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel deliveredProductsPanel;
        private Button orderButton;
        private NumericUpDown countBox;
        private FlowLayoutPanel productsPanel;
    }
}