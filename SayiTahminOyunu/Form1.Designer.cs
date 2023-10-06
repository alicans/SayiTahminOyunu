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
            statusStrip1 = new StatusStrip();
            lblDurum = new ToolStripStatusLabel();
            pbarDurum = new ToolStripProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            oyunPanel = new Panel();
            lblMesaj = new Label();
            btnTahmin = new Button();
            txtSayi = new TextBox();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            oyunPanel.SuspendLayout();
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
            btnBaslat.Click += btnBaslat_Click;
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
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // oyunPanel
            // 
            oyunPanel.Controls.Add(lblMesaj);
            oyunPanel.Controls.Add(btnTahmin);
            oyunPanel.Controls.Add(txtSayi);
            oyunPanel.Controls.Add(label1);
            oyunPanel.Location = new Point(34, 76);
            oyunPanel.Name = "oyunPanel";
            oyunPanel.Size = new Size(355, 156);
            oyunPanel.TabIndex = 8;
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(0, 90);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(355, 45);
            lblMesaj.TabIndex = 11;
            lblMesaj.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnTahmin
            // 
            btnTahmin.Enabled = false;
            btnTahmin.Location = new Point(3, 36);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(355, 38);
            btnTahmin.TabIndex = 10;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // txtSayi
            // 
            txtSayi.Location = new Point(255, 1);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(100, 29);
            txtSayi.TabIndex = 9;
            txtSayi.TextChanged += txtSayi_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 4);
            label1.Name = "label1";
            label1.Size = new Size(249, 21);
            label1.TabIndex = 8;
            label1.Text = "[1-100] arasında bir sayı giriniz:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 331);
            Controls.Add(oyunPanel);
            Controls.Add(statusStrip1);
            Controls.Add(btnBaslat);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Sayı Tahmin Oyunu";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            oyunPanel.ResumeLayout(false);
            oyunPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaslat;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDurum;
        private ToolStripProgressBar pbarDurum;
        private System.Windows.Forms.Timer timer1;
        private Panel oyunPanel;
        private Label lblMesaj;
        private Button btnTahmin;
        private TextBox txtSayi;
        private Label label1;
    }
}