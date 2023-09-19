namespace DeliveryProject.Pages
{
    partial class AdministratorPage
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
            createProductButton = new Button();
            buttonsPanel = new FlowLayoutPanel();
            signUpButton = new Button();
            saveButton = new Button();
            loadButton = new Button();
            productList = new ProductList();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // createProductButton
            // 
            createProductButton.AutoSize = true;
            createProductButton.Location = new Point(3, 3);
            createProductButton.Name = "createProductButton";
            createProductButton.Size = new Size(86, 50);
            createProductButton.TabIndex = 1;
            createProductButton.Text = "Добавить";
            createProductButton.UseVisualStyleBackColor = true;
            createProductButton.Click += CreateProductButton_Click;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonsPanel.Controls.Add(createProductButton);
            buttonsPanel.Controls.Add(signUpButton);
            buttonsPanel.Controls.Add(saveButton);
            buttonsPanel.Controls.Add(loadButton);
            buttonsPanel.Location = new Point(0, 0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(800, 54);
            buttonsPanel.TabIndex = 1;
            // 
            // signUpButton
            // 
            signUpButton.AutoSize = true;
            signUpButton.Location = new Point(95, 3);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(161, 50);
            signUpButton.TabIndex = 2;
            signUpButton.Text = "Зарегистрироваться";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += SignUpButton_Click;
            // 
            // saveButton
            // 
            saveButton.AutoSize = true;
            saveButton.Location = new Point(262, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(101, 50);
            saveButton.TabIndex = 3;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // loadButton
            // 
            loadButton.AutoSize = true;
            loadButton.Location = new Point(369, 3);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(101, 50);
            loadButton.TabIndex = 4;
            loadButton.Text = "Загрузить";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += LoadButton_Click;
            // 
            // productList
            // 
            productList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productList.Location = new Point(12, 60);
            productList.Name = "productList";
            productList.Size = new Size(776, 378);
            productList.TabIndex = 3;
            // 
            // AdministratorPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productList);
            Controls.Add(buttonsPanel);
            Name = "AdministratorPage";
            Text = "Администратор";
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button createProductButton;
        private FlowLayoutPanel buttonsPanel;
        private Button signUpButton;
        private Button saveButton;
        private Button loadButton;
        private ProductList productList;
    }
}