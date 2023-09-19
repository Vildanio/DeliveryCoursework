namespace DeliveryProject.Pages
{
    partial class CourierPage
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
            submitButton = new Button();
            orderCard = new OrderCard();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Bottom;
            submitButton.Location = new Point(68, 99);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(126, 29);
            submitButton.TabIndex = 1;
            submitButton.Text = "Готово";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click;
            // 
            // orderCard
            // 
            orderCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderCard.AutoSize = true;
            orderCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            orderCard.Location = new Point(12, 12);
            orderCard.Name = "orderCard";
            orderCard.Order = null;
            orderCard.Size = new Size(250, 80);
            orderCard.TabIndex = 2;
            // 
            // CourierPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(284, 140);
            Controls.Add(orderCard);
            Controls.Add(submitButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CourierPage";
            Text = "Курьер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button submitButton;
        private OrderCard orderCard;
    }
}