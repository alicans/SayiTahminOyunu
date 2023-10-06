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
            // �nce timer ba�lat
            timer1.Start();
            // Rastgele say� �ret
            uretilenSayi = rnd.Next(1, 101);

            lblDurum.Text = "Oyun Ba�lad�.";

            // Progress bar�n durumunu ayarla. 100'den geri sayacak.
            pbarDurum.Value = pbarDurum.Maximum;

            // Oyunu ba�lat�nca a�
            oyunPanel.Visible = true;
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {

            // say� kontrolleri
            if (txtSayi.Text == "" || !int.TryParse(txtSayi.Text, out int tahminEdilen) || (txtSayi.Text.Contains(" ") && btnTahmin.Enabled))
                btnTahmin.Enabled = false;
            else if (!btnTahmin.Enabled && !txtSayi.Text.Contains(" "))
                btnTahmin.Enabled = true;

        }
    }
}