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
using System.IO;

namespace arackiralama
{
    


    public partial class userMenu : Form
    {
        public static DateTime k_batrh;
        public static DateTime k_bitrh;
        public static string k_plaka;
        public static string k_kullanici;
        public static int k_tutar;
        SqlConnection baglanti, baglanti1;
        SqlCommand komut, komut1;
        public userMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa anasayfaformu = new anasayfa();
            anasayfaformu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa anasayfaformu = new anasayfa();
            anasayfaformu.Show();
        }

        private void userMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            anasayfa anasayfaformu = new anasayfa();
            anasayfaformu.Show();
        }
        private string Subeadi(string subeid)
        {
            string deger = "";
            baglanti1 = new SqlConnection(anasayfa.sqlserver);
            baglanti1.Open();
            komut1 = new SqlCommand("Select * From subeler where subeid=" + subeid, baglanti1);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                deger = dr1["subeadi"].ToString();
            }
            baglanti1.Close();
            return deger;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) 
            { 
            plakaTxt.Text = listView1.SelectedItems[0].SubItems[0].Text;
            subeBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            markaBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            modelBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            yakitBox.Text = listView1.SelectedItems[0].SubItems[4].Text;
            vitesBox.Text = listView1.SelectedItems[0].SubItems[5].Text;
            ucretBox.Text = listView1.SelectedItems[0].SubItems[6].Text;
            if (File.Exists(Application.StartupPath.ToString() + "\\araclar\\" + listView1.SelectedItems[0].SubItems[0].Text.Trim() + ".jpg"))
                aracresmi.Image = Image.FromFile(Application.StartupPath.ToString() + "\\araclar\\" + listView1.SelectedItems[0].SubItems[0].Text.Trim() + ".jpg");
            else aracresmi.Image = null;
                try
                {
                    if (ucretBox.Text != null && txttoplam.Text != null)
                    {

                        DateTime bugunTarihi = DateBaslangic.Value;
                        DateTime bitisTarihi = DateBitis.Value;
                        TimeSpan ts = bitisTarihi - bugunTarihi;
                        lblgunsayisi.Text = ts.Days.ToString();
                        int gunsayisi = Convert.ToInt32(lblgunsayisi.Text);
                        int gunucret = Convert.ToInt32(ucretBox.Text);
                        int toplam = gunsayisi * gunucret;
                        txttoplam.Text = toplam.ToString();


                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Araç Seçim ve Tarih Aralığı bilgilerinizi kontrol ediniz.");

                }

            }
            else
            {
                plakaTxt.Text = "";
                subeBox.Text = "";
                markaBox.Text = "";
                modelBox.Text = "";
                yakitBox.Text = "";
                vitesBox.Text = "";
                ucretBox.Text = "";
                lblgunsayisi.Text = "";
                txttoplam.Text = "";
                aracresmi.Image = null;
            }

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void aracekleBtn_Click(object sender, EventArgs e)
        {
          

            //kullanıcı olup olmadığını sorguluyorr
            if (anasayfa.kullaniciadi.Equals(""))
            {               
                kayitekle frmkayit = new kayitekle();
                frmkayit.Text = "Kayıt Ekle";
                frmkayit.ShowDialog();

            }
            else
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    k_batrh = DateBaslangic.Value;
                    k_bitrh = DateBitis.Value;
                    k_kullanici = anasayfa.kullaniciadi;
                    k_tutar = Convert.ToInt32(txttoplam.Text);
                    k_plaka = listView1.SelectedItems[0].Text;
                    AraciKirala frmkirala = new AraciKirala();
                    frmkirala.ShowDialog();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {            
           

        }

        private void txtgunSayisi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBitis_ValueChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DateTime bugunTarihi = DateBaslangic.Value;
            DateTime bitisTarihi = DateBitis.Value;
            TimeSpan ts = bitisTarihi - bugunTarihi;
            lblgunsayisi.Text = ts.Days.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateBaslangic_ValueChanged(object sender, EventArgs e)
        {
            DateBitis.Enabled = true;
            DateBitis.MinDate = DateBaslangic.Value.AddDays(1);
            listele();
        }
        public Boolean Aracuygunmu(String plakaa, DateTime bastrh, DateTime bittrh)
        {
            
            Boolean sonuc = true;
            
            baglanti = new SqlConnection(anasayfa.sqlserver);
            komut = new SqlCommand("Select * From kiralama where plaka=@plaka", baglanti);
            //            
            komut.Parameters.AddWithValue("@plaka", plakaa);
            baglanti.Open();            
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {                
                DateTime bastarih1 =Convert.ToDateTime(dr["bastarih"].ToString());
                DateTime bittarih1 = Convert.ToDateTime(dr["bittarih"].ToString());
                if ((bastarih1 >= bastrh && bastarih1<bittrh) || (bittarih1 > bastrh && bittarih1 <= bittrh) || (bastarih1 < bastrh && bittarih1 > bittrh))
                {
                    sonuc = false;
                }
                
            }
                return sonuc;
        }
        public void listele()
        {
            plakaTxt.Text = "";
            subeBox.Text = "";
            markaBox.Text = "";
            modelBox.Text = "";
            yakitBox.Text = "";
            vitesBox.Text = "";
            ucretBox.Text = "";
            lblgunsayisi.Text = "";
            txttoplam.Text = "";
            aracresmi.Image = null;
            listView1.Items.Clear();
            baglanti = new SqlConnection(anasayfa.sqlserver);
            baglanti.Open();
            komut = new SqlCommand("Select * From araclar", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Aracuygunmu(dr["plaka"].ToString(), DateBaslangic.Value, DateBitis.Value))
                {
                    ListViewItem item = new ListViewItem(dr["plaka"].ToString());
                    item.SubItems.Add(Subeadi(dr["subeid"].ToString()));
                    item.SubItems.Add(dr["marka"].ToString());
                    item.SubItems.Add(dr["model"].ToString());
                    item.SubItems.Add(dr["yakitturu"].ToString());
                    item.SubItems.Add(dr["vites"].ToString());
                    item.SubItems.Add(dr["ucret"].ToString());
                    item.SubItems.Add(dr["aracid"].ToString());
                    listView1.Items.Add(item);
                }
            }
            baglanti.Close();
        }
        private void userMenu_Load(object sender, EventArgs e)
        {
            DateBitis.Enabled = true;
            DateBaslangic.MinDate = DateTime.Today.Date;
            DateBaslangic.MaxDate = DateTime.Today.AddMonths(3);
            DateBitis.MinDate = DateTime.Today.Date.AddDays(1);
            DateBitis.MaxDate = DateTime.Today.Date.AddMonths(3);
            listele();
        }
    }
}
