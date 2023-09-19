namespace DeliveryProject.Pages
{
    partial class DispatcherPage
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
            orderListLabel = new Label();
            orderPanel = new FlowLayoutPanel();
            acceptOrderButton = new Button();
            sendOrderButton = new Button();
            SuspendLayout();
            // 
            // orderListLabel
            // 
            orderListLabel.AutoSize = true;
            orderListLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderListLabel.Location = new Point(12, 15);
            orderListLabel.Name = "orderListLabel";
            orderListLabel.Size = new Size(64, 20);
            orderListLabel.TabIndex = 4;
            orderListLabel.Text = "Заказы:";
            // 
            // orderPanel
            // 
            orderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderPanel.AutoScroll = true;
            orderPanel.AutoSize = true;
            orderPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            orderPanel.FlowDirection = FlowDirection.TopDown;
            orderPanel.Location = new Point(12, 50);
            orderPanel.MinimumSize = new Size(780, 70);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(780, 70);
            orderPanel.TabIndex = 3;
            orderPanel.WrapContents = false;
            // 
            // acceptOrderButton
            // 
            acceptOrderButton.Location = new Point(112, 15);
            acceptOrderButton.Name = "acceptOrderButton";
            acceptOrderButton.Size = new Size(125, 29);
            acceptOrderButton.TabIndex = 5;
            acceptOrderButton.Text = "Собрать заказ";
            acceptOrderButton.UseVisualStyleBackColor = true;
            acceptOrderButton.Click += AcceptOrderButton_Click;
            // 
            // sendOrderButton
            // 
            sendOrderButton.Location = new Point(243, 15);
            sendOrderButton.Name = "sendOrderButton";
            sendOrderButton.Size = new Size(136, 29);
            sendOrderButton.TabIndex = 6;
            sendOrderButton.Text = "Отправить заказ";
            sendOrderButton.UseVisualStyleBackColor = true;
            sendOrderButton.Click += SendOrderButton_Click;
            // 
            // DispatcherPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 133);
            Controls.Add(sendOrderButton);
            Controls.Add(acceptOrderButton);
            Controls.Add(orderListLabel);
            Controls.Add(orderPanel);
            Name = "DispatcherPage";
            Text = "Диспетчер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderListLabel;
        private FlowLayoutPanel orderPanel;
        private Button acceptOrderButton;
        private Button sendOrderButton;
    }
}