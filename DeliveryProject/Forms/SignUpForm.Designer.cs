namespace DeliveryProject
{
    partial class SignUpForm
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
            loginBox = new TextBox();
            passwordBox = new TextBox();
            submitButton = new Button();
            roleBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // loginBox
            // 
            loginBox.Location = new Point(296, 139);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(151, 27);
            loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(296, 183);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(151, 27);
            passwordBox.TabIndex = 1;
            // 
            // submitButton
            // 
            submitButton.AutoSize = true;
            submitButton.Location = new Point(289, 268);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(161, 30);
            submitButton.TabIndex = 2;
            submitButton.Text = "Зарегистрироваться";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click;
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Items.AddRange(new object[] { "Администратор", "Кладовщик", "Диспетчер", "Курьер" });
            roleBox.Location = new Point(296, 224);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(151, 28);
            roleBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(228, 184);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(238, 142);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Логин";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(248, 232);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 7;
            label4.Text = "Роль";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 465);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roleBox);
            Controls.Add(submitButton);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SignUpForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginBox;
        private TextBox passwordBox;
        private Button submitButton;
        private ComboBox roleBox;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}