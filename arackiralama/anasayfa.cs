using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arackiralama
{
    
    public partial class anasayfa : Form
    {
        public static string sqlserver = "Data Source=SERHATTOKTAS\\SQLEXPRESS;Initial Catalog = arackirala; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //SERHAT "Data Source=SERHATTOKTAS\\SQLEXPRESS;Initial Catalog = arackirala; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //KADİR "Data Source = DESKTOP - T4LEG9N; Initial Catalog = arackiralama; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static string kullaniciadi;
        public static int subeid;
        SqlConnection baglanti;
        SqlCommand komut;
        //SqlDataAdapter da;
        public anasayfa()
        {
            InitializeComponent();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {            
            kayitekle kayitekleformu = new kayitekle();
            kayitekleformu.ShowDialog();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string subeee="0";
            if (kullaniciTxt.Text.Equals("") || sifreTxt.Text.Equals(""))
                MessageBox.Show("Kullanıcı adı veya Parola boş bırakılamaz!!");
            else
            {
                baglanti = new SqlConnection(sqlserver);
                string sorgu = "Select * From Uyeler Where kullaniciadi=@kullaniciadi AND sifre=@sifre";
                komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                komut.Parameters.AddWithValue("@kullaniciadi", kullaniciTxt.Text);
                komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
                SqlDataReader dr = komut.ExecuteReader();
                int say = 0;
                string yetki = "", adsoyad = "";
                
                while (dr.Read())
                {
                    say++;
                    yetki = dr["rol"].ToString();
                    adsoyad = dr["adsoyad"].ToString();
                    subeee = dr["subeid"].ToString();
                }
                baglanti.Close();
                                
                if (say == 0)
                    MessageBox.Show("Kullanıcı adı veya parola hatalı!! Lütfen kontrol ediniz.");

                else if (yetki.Substring(0, 7) == "musteri")
                {
                    kullaniciadi = kullaniciTxt.Text;
                    MessageBox.Show("Hoşgeldin " + adsoyad);
                    this.Hide();
                    userMenu userformu = new userMenu();
                    userformu.Show();

                }
                else if (yetki.Substring(0, 4) == "sube")
                {
                    subeid = Convert.ToInt32(subeee);
                    kullaniciadi = kullaniciTxt.Text;
                    MessageBox.Show("Hoşgeldin " + adsoyad);
                    this.Hide();
                    SubeMenu subeformu = new SubeMenu();
                    subeformu.Show();
                }
                else if (yetki.Substring(0, 8) == "yonetici")
                {
                    kullaniciadi = kullaniciTxt.Text;
                    MessageBox.Show("Hoşgeldin " + adsoyad);
                    this.Hide();
                    yoneticiMenu yoneticiformu = new yoneticiMenu();
                    yoneticiformu.Show();
                }



            }
        }

        private void anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void sunucuTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            kayitekle kayitekleformu = new kayitekle();
            kayitekleformu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciadi = "";
            this.Hide();
            userMenu frmsube = new userMenu();
            frmsube.Show();            
          
        }
    }
}
