using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;



namespace Ay_Yıldız_Pansiyon_Ve_Dinlenme_Tesisleri
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=NUMANTUNCEL\\MSSQLSERVER01;Initial Catalog=PansiyonDB;Integrated Security=True;Trust Server Certificate=True");
        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from dbo.admin where KullanıcıAdi=@p1 and şifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullanıcıAdi.Text);// komuta parametre olarak text deki değer ile ekle parametre(p1)
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())// okuma işlemi başarılıysa
            {
                MessageBox.Show("Giriş Başarlı.");
                FrmAnaForm fra=new FrmAnaForm();
                fra.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı yada Şifre Hatalı.");
            }
            baglanti.Close();



        }
    }
}
