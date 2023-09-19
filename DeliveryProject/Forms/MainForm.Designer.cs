namespace DeliveryProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            submitButton = new Button();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            continueAsClientButton = new Button();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            submitButton.Location = new Point(360, 235);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 0;
            submitButton.Text = "Войти";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click_1;
            // 
            // loginBox
            // 
            loginBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginBox.Location = new Point(346, 152);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(125, 27);
            loginBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.Location = new Point(346, 190);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(125, 27);
            passwordBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(288, 155);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(278, 197);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // continueAsClientButton
            // 
            continueAsClientButton.AutoSize = true;
            continueAsClientButton.Location = new Point(310, 270);
            continueAsClientButton.Name = "continueAsClientButton";
            continueAsClientButton.Size = new Size(184, 30);
            continueAsClientButton.TabIndex = 9;
            continueAsClientButton.Text = "Продолжить как клиент";
            continueAsClientButton.UseVisualStyleBackColor = true;
            continueAsClientButton.Click += ContinueAsClientButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(continueAsClientButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(submitButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainForm";
            Text = "DeliveryApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitButton;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private Button continueAsClientButton;
    }
}