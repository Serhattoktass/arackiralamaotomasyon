using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arackiralama
{
    public partial class SubeMenu : Form
    {
        public static DateTime k_batrh;
        public static DateTime k_bitrh;
        public static string k_plaka;
        public static string k_kullanici;
        public static int k_tutar;
        SqlConnection baglanti, baglanti1;
        SqlCommand komut, komut1;
        public SubeMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SubeMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            anasayfa anasayfaformu = new anasayfa();
            anasayfaformu.Show();
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa anasayfaformu = new anasayfa();
            anasayfaformu.Show();
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
                DateTime bastarih1 = Convert.ToDateTime(dr["bastarih"].ToString());
                DateTime bittarih1 = Convert.ToDateTime(dr["bittarih"].ToString());
                if ((bastarih1 >= bastrh && bastarih1 < bittrh) || (bittarih1 > bastrh && bittarih1 <= bittrh) || (bastarih1 < bastrh && bittarih1 > bittrh))
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
            komut = new SqlCommand("Select * From araclar where subeid=@subeid", baglanti);
            komut.Parameters.AddWithValue("@subeid", anasayfa.subeid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item =new ListViewItem(dr["plaka"].ToString());
                item.SubItems.Add(Subeadi(dr["subeid"].ToString()));
                item.SubItems.Add(dr["marka"].ToString());
                item.SubItems.Add(dr["model"].ToString());
                item.SubItems.Add(dr["yakitturu"].ToString());
                item.SubItems.Add(dr["vites"].ToString());
                item.SubItems.Add(dr["ucret"].ToString());
                item.SubItems.Add(dr["aracid"].ToString());
                if (Aracuygunmu(dr["plaka"].ToString(), DateBaslangic.Value, DateBitis.Value))
                {
                    
                    item.ForeColor = Color.Black;
                    item.BackColor = Color.White;
                }
                else
                {
                    item.ForeColor = Color.White;
                    item.BackColor = Color.Red;
                }
                listView1.Items.Add(item);
            }
            baglanti.Close();
        }
        private void SubeMenu_Load(object sender, EventArgs e)
        {
            DateBitis.Enabled = true;
            DateBaslangic.MinDate = DateTime.Today.Date;
            DateBaslangic.MaxDate = DateTime.Today.AddMonths(3);
            DateBitis.MinDate = DateTime.Today.Date.AddDays(1);
            DateBitis.MaxDate = DateTime.Today.Date.AddMonths(3);
            listele();
        }

        private void DateBaslangic_ValueChanged(object sender, EventArgs e)
        {
            DateBitis.Enabled = true;
            DateBitis.MinDate = DateBaslangic.Value.AddDays(1);
            listele();
        }

        private void aracekleBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                {
                if (listView1.SelectedItems[0].BackColor == Color.White)
                {
                    k_batrh = DateBaslangic.Value;
                    k_bitrh = DateBitis.Value;
                    k_kullanici = anasayfa.kullaniciadi;
                    k_tutar = Convert.ToInt32(txttoplam.Text);
                    k_plaka = listView1.SelectedItems[0].Text;
                    AraciKirala frmkirala = new AraciKirala();
                    frmkirala.ShowDialog();
                }
                else MessageBox.Show("Seçilen Araç girilen tarih arasında müsait değil!!");
                }
            
        }

        private void DateBitis_ValueChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!plakaTxt.Text.Equals("") && !ucretBox.Text.Equals(""))
            {
                try
                {
                    string sorgu = "Update araclar Set ucret=@ucret Where plaka=@plaka";
                    baglanti = new SqlConnection(anasayfa.sqlserver);
                    komut = new SqlCommand(sorgu, baglanti);
                    int aaa = Convert.ToInt32(ucretBox.Text);
                    komut.Parameters.AddWithValue("@ucret", ucretBox.Text);
                    komut.Parameters.AddWithValue("@plaka", plakaTxt.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ücret değiştirme işlemi başarılı!!");
                    listele();
                }
                catch
                {
                    MessageBox.Show("Ücret bilgisi sayılardan oluşmalı!!");
                }
            }
            else MessageBox.Show("Araç seçimi yapılmamış veya ücret yazılmamış!!");
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
                ucretBox.Text = listView1.SelectedItems[0].SubItems[6].Text.Trim();
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
    }
}
