namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int uretilenSayi, tahminEdilen;
        public Form1()
        {
            InitializeComponent();
            pbarDurum.Maximum = 60;
            oyunPanel.Visible = false;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            btnBaslat.Enabled = false;

            // Önce timer baþlat
            timer1.Start();
            // Rastgele sayý üret
            uretilenSayi = rnd.Next(1, 101);

            lblDurum.Text = "Süreniz Baþladý.";

            // Progress barýn durumunu ayarla. 100'den geri sayacak.
            pbarDurum.Value = pbarDurum.Maximum;

            // Oyunu baþlatýnca aç
            oyunPanel.Visible = true;

            
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {

            // sayý kontrolleri
            if (txtSayi.Text == "" || !int.TryParse(txtSayi.Text, out int yazilanSayi) || (txtSayi.Text.Contains(" ") && btnTahmin.Enabled))
                btnTahmin.Enabled = false;
            else if (!btnTahmin.Enabled && !txtSayi.Text.Contains(" "))
                btnTahmin.Enabled = true;



        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            // tahmin edilen sayýyý al
            tahminEdilen = Convert.ToInt32(txtSayi.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressbar value deðerini 1 azalt
                pbarDurum.Value--;

            if (pbarDurum.Value == pbarDurum.Minimum) 
            {
                timer1.Stop();
                btnBaslat.Enabled = true;
                lblDurum.Text = "Süreniz bitti.";
            }
               
        }
    }
}