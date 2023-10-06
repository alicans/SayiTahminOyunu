namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int uretilenSayi;
        public Form1()
        {
            InitializeComponent();
            oyunPanel.Visible = false;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            // Önce timer baþlat
            timer1.Start();
            // Rastgele sayý üret
            uretilenSayi = rnd.Next(1, 101);

            lblDurum.Text = "Oyun Baþladý.";

            // Progress barýn durumunu ayarla. 100'den geri sayacak.
            pbarDurum.Value = pbarDurum.Maximum;

            // Oyunu baþlatýnca aç
            oyunPanel.Visible = true;
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {
            if (!btnTahmin.Enabled)
                btnTahmin.Enabled = true;

            if(string.IsNullOrEmpty(txtSayi.Text) && btnTahmin.Enabled)
                btnTahmin.Enabled = false;
        }
    }
}