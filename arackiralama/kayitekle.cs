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

namespace arackiralama
{
    public partial class kayitekle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        //SqlDataAdapter da;

        public kayitekle()
        {
            InitializeComponent();
        }

        private void kayitekle_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("Kayıt Ekle"))
                button2.Visible = false;
            else button2.Visible = true;
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {    
                baglanti = new SqlConnection(anasayfa.sqlserver);
                string sorgu = "Insert into uyeler (kullaniciadi,sifre,adsoyad,tc,telno,email,adres,ehliyetno,ehliyettarih,ehliyetverilis,rol,uyelikonayi,subeid) values (@kullaniciadi,@sifre,@adsoyad,@tc,@telno,@email,@adres,@ehliyetno,@ehliyettarih,@ehliyetverilis,@rol,@uyelikonayi,@subeid)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kullaniciadi", kullaniciTxt.Text);
                komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
                komut.Parameters.AddWithValue("@adsoyad", adsoyadTxt.Text);
                komut.Parameters.AddWithValue("@tc", tcTxt.Text);
                komut.Parameters.AddWithValue("@telno", telTxt.Text);
                komut.Parameters.AddWithValue("@email", epostaTxt.Text);
                komut.Parameters.AddWithValue("@ehliyetno", ehliyetNotxt.Text);
                komut.Parameters.AddWithValue("@ehliyettarih", EhliyetTarihitxt.Text);
                komut.Parameters.AddWithValue("@ehliyetverilis", EhliyetVerilistxt.Text);
                komut.Parameters.AddWithValue("@rol", "musteri");
                komut.Parameters.AddWithValue("@uyelikonayi", 1);
                komut.Parameters.AddWithValue("@subeid", 0);
              try
            {
            baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt İşlemi Başarılı!!");
                anasayfa.kullaniciadi = kullaniciTxt.Text;
                    this.Hide();
            //anasayfa anasayfaformu = new anasayfa();
            //anasayfaformu.Show();

            }
            catch
               {
            MessageBox.Show("Lütfen Alanları Eksiksiz Doldurunuz ");
                }






        }

        private void anasayfaBtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {            
            this.Hide();
            anasayfa frmanasayfa = new anasayfa();
            frmanasayfa.Show();
        }

        private void kullaniciLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
