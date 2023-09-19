namespace DeliveryProject
{
    partial class CreateProductForm
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
            countBox = new NumericUpDown();
            priceBox = new NumericUpDown();
            nameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)countBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceBox).BeginInit();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            submitButton.Location = new Point(161, 214);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(126, 33);
            submitButton.TabIndex = 7;
            submitButton.Text = "Добавить";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click_1;
            // 
            // countBox
            // 
            countBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            countBox.Location = new Point(143, 181);
            countBox.Name = "countBox";
            countBox.Size = new Size(164, 27);
            countBox.TabIndex = 6;
            // 
            // priceBox
            // 
            priceBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceBox.Location = new Point(143, 148);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(164, 27);
            priceBox.TabIndex = 5;
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameBox.Location = new Point(143, 115);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(164, 27);
            nameBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 118);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 8;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 188);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 9;
            label2.Text = "Количество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 155);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 10;
            label3.Text = "Цена";
            // 
            // CreateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 362);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(submitButton);
            Controls.Add(countBox);
            Controls.Add(priceBox);
            Controls.Add(nameBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CreateProductForm";
            Text = "Добавить товар";
            ((System.ComponentModel.ISupportInitialize)countBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitButton;
        private NumericUpDown countBox;
        private NumericUpDown priceBox;
        private TextBox nameBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}