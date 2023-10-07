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
            txtSayi.Enabled = true;

            // �nce timer ba�lat
            timer1.Start();
            // Rastgele say� �ret
            uretilenSayi = rnd.Next(1, 101);

            lblDurum.Text = "S�reniz Ba�lad�.";

            // Progress bar�n durumunu ayarla. 100'den geri sayacak.
            pbarDurum.Value = pbarDurum.Maximum;

            // Oyunu ba�lat�nca a�
            oyunPanel.Visible = true;


        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {

            // say� kontrolleri
            if (txtSayi.Text == "" || !int.TryParse(txtSayi.Text, out int yazilanSayi) || (txtSayi.Text.Contains(" ") && btnTahmin.Enabled))
                btnTahmin.Enabled = false;
            else if (!btnTahmin.Enabled && !txtSayi.Text.Contains(" "))
                btnTahmin.Enabled = true;



        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            

            // tahmin edilen say�y� al
            
            tahminEdilen = Convert.ToInt32(txtSayi.Text);

            if (pbarDurum.Value != 0)
            {
                if (uretilenSayi == tahminEdilen)
                {
                    timer1.Stop();

                    btnBaslat.Enabled = true;
                    txtSayi.Enabled = false;

                    lblMesaj.Text = "KAZANDINIZ!!!";
                    lblDurum.Text = "Tebrikler.";
                }
                    

                else if (tahminEdilen < uretilenSayi )
                    lblMesaj.Text = tahminEdilen.ToString() + "=> K���k say� girdiniz";

                else
                    lblMesaj.Text = tahminEdilen.ToString() + "=> B�y�k say� girdiniz";

            }
            else
            {
                lblMesaj.Text = "Kaybettiniz!";
                btnTahmin.Enabled = false;
            }


            txtSayi.Text = "";




        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //progressbar value de�erini 1 azalt
            pbarDurum.Value--;

            btnTahmin.Text = "Tahmin Et (" + pbarDurum.Value + ")";

            if (pbarDurum.Value > 30 && pbarDurum.Value <= 50)
                lblDurum.Text = "S�re daha var :)";
            if (pbarDurum.Value > 20 && pbarDurum.Value <= 29)
                lblDurum.Text = "S�re azal�yor..";
            if (pbarDurum.Value > 1 && pbarDurum.Value <= 19)
                lblDurum.Text = "S�re �ok az kald�";

            if (pbarDurum.Value == pbarDurum.Minimum)
            {
                timer1.Stop();
                btnBaslat.Enabled = true;
                lblDurum.Text = "S�reniz bitti.";
                lblMesaj.Text = "Kaybettiniz!";
            }

        }
    }
}