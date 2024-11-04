using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Yıldız_Pansiyon_Ve_Dinlenme_Tesisleri
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void oda101_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "101";
        }

        private void oda102_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "102";
        }

        private void oda103_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "103";
        }

        private void oda104_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "104";
        }

        private void oda105_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "105";
        }

        private void oda106_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "106";
        }

        private void oda201_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "201";
        }

        private void oda202_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "202";

        }

        private void oda203_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "203";

        }

        private void oda204_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "204";

        }

        private void oda205_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "205";

        }

        private void oda206_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "206";

        }

        private void oda301_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "301";

        }

        private void oda302_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "302";

        }

        private void oda303_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "303";

        }

        private void oda304_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "304";

        }

        private void oda305_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "305";

        }

        private void oda306_Click(object sender, EventArgs e)
        {
            text_odaNo.Text = "306";

        }

        private void oda_Bos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Linght Blue renkli butonlar dolu odaları gösterir.");
        }

        private void oda_Dolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Medium Slate Blue renkli butonlar dolu odaları gösterir.");
        }

        private void dtp_cıkısTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(dtp_girisTarihi.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtp_cıkısTarihi.Text);

            TimeSpan sonuc;
            sonuc = buyukTarih - kucukTarih;
            lbl_günadet.Text = sonuc.TotalDays.ToString();

            //iki  tarih arası fark için time spanı kullandım

            ucret = Convert.ToInt32(lbl_günadet.Text)*1000;
            text_ücret.Text = ucret.ToString();
        }
    }
}
