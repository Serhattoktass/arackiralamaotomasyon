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
using System.IO;
using System.Drawing.Imaging;

namespace arackiralama
{
    public partial class yoneticiMenu : Form
    {
        SqlConnection baglanti, baglanti1;
        SqlCommand komut,komut1;
        public yoneticiMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa anasayfaformu = new anasayfa();
            anasayfaformu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private string Subeadi(string subeid)
        {
            string deger = "";
            baglanti1 = new SqlConnection(anasayfa.sqlserver);
            baglanti1.Open();
            komut1 = new SqlCommand("Select * From subeler where subeid="+subeid, baglanti1);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                deger = dr1["subeadi"].ToString();
            }
            baglanti1.Close();
            return deger;
        }
        private string Subeiddondur(string sube_adi)
        {
            string deger = "";
            baglanti1 = new SqlConnection(anasayfa.sqlserver);
            baglanti1.Open();
            komut1 = new SqlCommand("Select * From subeler where subeadi=@subeadi", baglanti1);
            komut1.Parameters.AddWithValue("@subeadi", sube_adi);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                deger = dr1["subeid"].ToString();
            }
            baglanti1.Close();
            return deger;
        }
        private void Subedoldur(ComboBox cmbbx,Boolean yok)
        {
            string deger = "";            
            baglanti1 = new SqlConnection(anasayfa.sqlserver);
            baglanti1.Open();
            komut1 = new SqlCommand("Select * From subeler", baglanti1);
            SqlDataReader dr1 = komut1.ExecuteReader();            cmbbx.Items.Clear();

            while (dr1.Read())
            {
                deger = dr1["subeadi"].ToString();
                if (deger.Substring(0,3).Equals("yok")&&yok)
                    deger = "";
                else  cmbbx.Items.Add(deger);                
                
            }
            baglanti1.Close();            
        }

        private void yoneticiMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            anasayfa anasayfaformu = new anasayfa();
            anasayfaformu.Show();
        }

        private void aracekleBtn_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(anasayfa.sqlserver);
            string sorgu = "Insert into araclar (plaka,subeid,marka,model,yakitturu,vites,ucret) values (@plaka,@subeid,@marka,@model,@yakitturu,@vites,@ucret)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@plaka", plakaTxt.Text);
            komut.Parameters.AddWithValue("@subeid", Convert.ToInt32(Subeiddondur(subeBox.Text)));//şubeyi çek
            komut.Parameters.AddWithValue("@marka", markaBox.Text);
            komut.Parameters.AddWithValue("@model", modelBox.Text);
            komut.Parameters.AddWithValue("@yakitturu", yakitBox.Text);
            komut.Parameters.AddWithValue("@vites", vitesBox.Text);
            komut.Parameters.AddWithValue("@ucret", ucretBox.Text);            
            try
            {
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                if (pictureBox1.Image!=null)
                {
                    pictureBox1.Image.Save(Application.StartupPath.ToString() + "\\araclar\\" + plakaTxt.Text.Trim() + ".jpg", ImageFormat.Jpeg);
                }
                MessageBox.Show("Araç Eklendi");
                pictureBox1.Image = null;
                plakaTxt.Clear();
                ucretBox.Clear();
                listele();
                //anasayfa anasayfaformu = new anasayfa();
                //anasayfaformu.Show();

            }
            catch
            {
                MessageBox.Show("Bu plaka adı zaten kayıtlı!!");
            }
        }

        private void duzeltBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                try
                {
                    string sorgu = "Update araclar Set plaka=@plaka,subeid=@subeid,marka=@marka,model=@model,yakitturu=@yakitturu,vites=@vites,ucret=@ucret Where aracid=@id";
                    baglanti = new SqlConnection(anasayfa.sqlserver);
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@plaka", plakaTxt.Text);
                    komut.Parameters.AddWithValue("@subeid", Convert.ToInt32(Subeiddondur(subeBox.Text)));
                    komut.Parameters.AddWithValue("@marka", markaBox.Text);
                    komut.Parameters.AddWithValue("@model", modelBox.Text);
                    komut.Parameters.AddWithValue("@yakitturu", yakitBox.Text);
                    komut.Parameters.AddWithValue("@vites", vitesBox.Text);
                    komut.Parameters.AddWithValue("@ucret", ucretBox.Text);
                    komut.Parameters.AddWithValue("@id", Convert.ToInt32(listView1.SelectedItems[0].SubItems[7].Text));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Değiştirme işlemi başarılı!!");
                    listele();
                }
                catch 
                {
                    MessageBox.Show("Hata! işlem Yapılamıyor!");
                }
                
            }
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                plakaTxt.Text = listView1.SelectedItems[0].Text;
                subeBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
                markaBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
                modelBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
                yakitBox.Text = listView1.SelectedItems[0].SubItems[4].Text;
                vitesBox.Text = listView1.SelectedItems[0].SubItems[5].Text;
                ucretBox.Text = listView1.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult mesajsonucu = MessageBox.Show(listView1.SelectedItems[0].Text + " plakalı aracı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mesajsonucu==DialogResult.Yes) {
                    baglanti = new SqlConnection(anasayfa.sqlserver);
                    string sorgu = "DELETE araclar Where aracid=@id";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", listView1.SelectedItems[0].SubItems[7].Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show(listView1.SelectedItems[0].Text + " plakalı araç silindi!");
                    listele();
                }
            }
        }

        private void kullaniciTab_Click(object sender, EventArgs e)
        {
            

           }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                //try
                //{
                    string sorgu = "Update uyeler Set rol=@rol,subeid=@subeid Where kullaniciadi=@kullaniciadi";
                    baglanti = new SqlConnection(anasayfa.sqlserver);
                komut = new SqlCommand(sorgu, baglanti);//kullaniciadi=@kullaniciadi,sifre=@sifre,adsoyad=@adsoyad,tc=@tc,telno=@telno,email=@email,adres=@adres,rol=@rol,uyelikonayi=@uyelikonayi,subeid=@subeid
                komut.Parameters.AddWithValue("@rol", yetkiBox.Text);
                    komut.Parameters.AddWithValue("@subeid", Convert.ToInt32(Subeiddondur(subeBox2.Text)));
                    komut.Parameters.AddWithValue("@kullaniciadi", listView2.SelectedItems[0].Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Değiştirme işlemi başarılı!!");
                    listele2();
                //}
                //catch
                //{
                //    MessageBox.Show("Hata! işlem Yapılamıyor!");
                //}

            }
        }
        public void listele2()
         {
                listView2.Items.Clear();
                baglanti = new SqlConnection(anasayfa.sqlserver);
            baglanti.Open();
                komut = new SqlCommand("Select * From uyeler", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["kullaniciadi"].ToString());
                    item.SubItems.Add(dr["adsoyad"].ToString());
                    item.SubItems.Add(dr["tc"].ToString());
                    item.SubItems.Add(dr["rol"].ToString());
                    item.SubItems.Add(Subeadi(dr["subeid"].ToString()));
                if (dr["uyelikonayi"].ToString().Equals("0"))
                    item.SubItems.Add("Hayir");
                else item.SubItems.Add("Evet");                
                    listView2.Items.Add(item);
                }
                baglanti.Close();
         }


        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                DialogResult mesajsonucu = MessageBox.Show(listView2.SelectedItems[0].Text + " kullanıcısını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mesajsonucu == DialogResult.Yes)
                {
                    baglanti = new SqlConnection(anasayfa.sqlserver);
                    string sorgu = "DELETE uyeler Where kullaniciadi=@kullaniciadi";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@kullaniciadi", listView2.SelectedItems[0].Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show(listView2.SelectedItems[0].Text + " kullanıcısı silindi!");
                    listele2();
                }
            }
        }

        private void subeLbl_Click(object sender, EventArgs e)
        {

        }

        private void resimBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            string DosyaYolu = file.FileName;
            pictureBox1.Image = Image.FromFile(DosyaYolu);
            //string DosyaAdi = file.SafeFileName;
        }

        private void subeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void araclarTab_Click(object sender, EventArgs e)
        {

        }

        public void listele()
        {
            listView1.Items.Clear();
            baglanti = new SqlConnection(anasayfa.sqlserver);
            baglanti.Open();
            komut = new SqlCommand("Select * From araclar", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
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
            baglanti.Close();
        }

        private void listView3_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public string iladidondur(string ilid)
        {
            string sonuc="";
            baglanti = new SqlConnection(anasayfa.sqlserver);
            baglanti.Open();
            komut = new SqlCommand("Select * From iller where ilid=@ilid", baglanti);
            komut.Parameters.AddWithValue("@ilid", ilid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                sonuc = dr["iladi"].ToString();
            }
                return sonuc;
        }
        public int iliddondur(string iladi)
        {
            int sonuc = 0;
            baglanti1 = new SqlConnection(anasayfa.sqlserver);
            baglanti1.Open();
            komut1 = new SqlCommand("Select * From iller where iladi=@iladi", baglanti1);
            komut1.Parameters.AddWithValue("@iladi", iladi);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                sonuc = Convert.ToInt32(dr["ilid"].ToString());
            }
            return sonuc;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(anasayfa.sqlserver);
            string sorgu = "Insert into iller (ilid,iladi) values (@ilid,@iladi)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ilid", Convert.ToInt32(ilkodTxt.Text));
            komut.Parameters.AddWithValue("@iladi", iladiTxt.Text);           
            try
            {
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Başarılı!!");
                //anasayfa anasayfaformu = new anasayfa();
                //anasayfaformu.Show();
                ildoldur(iladiBox,true);
            }
            catch
            {
                MessageBox.Show("İl kodu 2 hane sayıdan(81 il) oluşabilir. Kayıt yapılamadı aynı il kodu olup olmadığına dikkat ediniz!!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (iladiBox.SelectedIndex != -1)
            {
                baglanti = new SqlConnection(anasayfa.sqlserver);
                string sorgu = "Insert into subeler (subeid,subeadi,ilid) values (@subeid,@subeadi,@ilid)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@subeid", Convert.ToInt32(subekoduTxt.Text));
                komut.Parameters.AddWithValue("@subeadi", subeadiTxt.Text);
                komut.Parameters.AddWithValue("@ilid", iliddondur(iladiBox.Text));
                try
                {
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Başarılı!!");
                

                }
                catch
                {
                    MessageBox.Show("şube kodu 5 hane sayıdan oluşabilir. Kayıt yapılamadı aynı şube kodu olup olmadığına dikkat ediniz!!");
                }
                subelistele(true);
            }
            else MessageBox.Show("İl adı seçiniz!!");
        }

        public void subelistele(Boolean yok)
        {
            String deger = "";
            listView3.Items.Clear();
            baglanti = new SqlConnection(anasayfa.sqlserver);
            baglanti.Open();
            komut = new SqlCommand("Select * From subeler", baglanti);
            // SqlCommand komut2 = new SqlCommand("Select * From subeler where ilid=")
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {                
                ListViewItem item = new ListViewItem(dr["ilid"].ToString());
                item.SubItems.Add(iladidondur(dr["ilid"].ToString()));
                item.SubItems.Add(dr["subeid"].ToString());
                item.SubItems.Add(dr["subeadi"].ToString());
                deger = dr["subeadi"].ToString();
                if (deger.Substring(0, 3).Equals("yok") && yok)
                    deger = "";
                else listView3.Items.Add(item);
            }
            baglanti.Close();
        }
        private void ildoldur(ComboBox cmbbx, Boolean yok)
        {
            string deger = "";
            baglanti1 = new SqlConnection(anasayfa.sqlserver);
            baglanti1.Open();
            komut1 = new SqlCommand("Select * From iller", baglanti1);
            SqlDataReader dr1 = komut1.ExecuteReader(); cmbbx.Items.Clear();

            while (dr1.Read())
            {
                deger = dr1["iladi"].ToString();
                if (deger.Substring(0, 3).Equals("yok") && yok)
                    deger = "";
                else cmbbx.Items.Add(deger);

            }
            baglanti1.Close();
        }
        private void yoneticiMenu_Load(object sender, EventArgs e)
        {
            listele();
            listele2();
            subelistele(true);
            ildoldur(iladiBox,true);
            Subedoldur(subeBox,true);
            Subedoldur(subeBox2,false);
        }
    }
}
