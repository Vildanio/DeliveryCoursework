namespace DeliveryProject.Pages
{
    partial class StorekeeperPage
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
            collectOrderButton = new Button();
            SuspendLayout();
            // 
            // orderListLabel
            // 
            orderListLabel.AutoSize = true;
            orderListLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderListLabel.Location = new Point(11, 14);
            orderListLabel.Name = "orderListLabel";
            orderListLabel.Size = new Size(64, 20);
            orderListLabel.TabIndex = 6;
            orderListLabel.Text = "Заказы:";
            // 
            // orderPanel
            // 
            orderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderPanel.AutoScroll = true;
            orderPanel.AutoSize = true;
            orderPanel.FlowDirection = FlowDirection.TopDown;
            orderPanel.Location = new Point(11, 45);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(779, 62);
            orderPanel.TabIndex = 5;
            orderPanel.WrapContents = false;
            // 
            // collectOrderButton
            // 
            collectOrderButton.Location = new Point(97, 10);
            collectOrderButton.Name = "collectOrderButton";
            collectOrderButton.Size = new Size(94, 29);
            collectOrderButton.TabIndex = 7;
            collectOrderButton.Text = "Собрать";
            collectOrderButton.UseVisualStyleBackColor = true;
            collectOrderButton.Click += CollectOrderButton_Click;
            // 
            // StorekeeperPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 115);
            Controls.Add(collectOrderButton);
            Controls.Add(orderListLabel);
            Controls.Add(orderPanel);
            Name = "StorekeeperPage";
            Text = "Кладовщик";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderListLabel;
        private FlowLayoutPanel orderPanel;
        private Button collectOrderButton;
    }
}