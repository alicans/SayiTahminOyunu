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
            components = new System.ComponentModel.Container();
            btnBaslat = new Button();
            label1 = new Label();
            txtSayi = new TextBox();
            btnTahmin = new Button();
            statusStrip1 = new StatusStrip();
            lblDurum = new ToolStripStatusLabel();
            pbarDurum = new ToolStripProgressBar();
            lblMesaj = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(34, 13);
            btnBaslat.Margin = new Padding(4);
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
            label1.Location = new Point(34, 87);
            label1.Name = "label1";
            label1.Size = new Size(249, 21);
            label1.TabIndex = 1;
            label1.Text = "[1-100] arasında bir sayı giriniz:";
            // 
            // txtSayi
            // 
            txtSayi.Location = new Point(289, 84);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(100, 29);
            txtSayi.TabIndex = 2;
            // 
            // btnTahmin
            // 
            btnTahmin.Location = new Point(34, 131);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(355, 38);
            btnTahmin.TabIndex = 3;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDurum, pbarDurum });
            statusStrip1.Location = new Point(0, 309);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(422, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = false;
            lblDurum.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(173, 17);
            lblDurum.Text = "Oyunu başlatmanız bekleniyor..";
            lblDurum.TextAlign = ContentAlignment.TopCenter;
            // 
            // pbarDurum
            // 
            pbarDurum.Name = "pbarDurum";
            pbarDurum.Size = new Size(100, 16);
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(34, 181);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(355, 45);
            lblMesaj.TabIndex = 7;
            lblMesaj.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 331);
            Controls.Add(lblMesaj);
            Controls.Add(statusStrip1);
            Controls.Add(btnTahmin);
            Controls.Add(txtSayi);
            Controls.Add(label1);
            Controls.Add(btnBaslat);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Sayı Tahmin Oyunu";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaslat;
        private Label label1;
        private TextBox txtSayi;
        private Button btnTahmin;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDurum;
        private ToolStripProgressBar pbarDurum;
        private Label lblMesaj;
        private System.Windows.Forms.Timer timer1;
    }
}