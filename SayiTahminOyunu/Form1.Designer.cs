namespace SayiTahminOyunu
{
    partial class Form1
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
            btnBaslat = new Button();
            label1 = new Label();
            txtSayi = new TextBox();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(34, 71);
            btnBaslat.Margin = new Padding(4, 4, 4, 4);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(355, 56);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "Oyunu Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(249, 21);
            label1.TabIndex = 1;
            label1.Text = "[1-100] arasında bir sayı giriniz:";
            // 
            // txtSayi
            // 
            txtSayi.Location = new Point(289, 20);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(100, 29);
            txtSayi.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 237);
            Controls.Add(txtSayi);
            Controls.Add(label1);
            Controls.Add(btnBaslat);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaslat;
        private Label label1;
        private TextBox txtSayi;
    }
}