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
    public partial class AraciKirala : Form
    {
        public AraciKirala()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti;
        SqlCommand komut;        

        private void AraciKirala_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            
            if(textKartNo.Text!=null &&textGuvenlik.Text!=null&&textKartAit.Text!=null)
            {

                DialogResult mesajsonucu = MessageBox.Show("Ödeme İşlemini Onaylıyor Musunuz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult.Yes == mesajsonucu)
                {
                    baglanti = new SqlConnection(anasayfa.sqlserver);
                    string sorgu = "Insert into kiralama (siparistarihi,bastarih,bittarih,plaka,kullaniciadi,siparisonayi,odemedurumu,miktar) values (@siparistarihi,@bastarih,@bittarih,@plaka,@kullaniciadi,@siparisonayi,@odemedurumu,@miktar)";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@siparistarihi", DateTime.Today.Date);
                    komut.Parameters.AddWithValue("@bastarih", userMenu.k_batrh);
                    komut.Parameters.AddWithValue("@bittarih", userMenu.k_bitrh);
                    komut.Parameters.AddWithValue("@plaka", userMenu.k_plaka);
                    komut.Parameters.AddWithValue("@kullaniciadi", userMenu.k_kullanici);
                    komut.Parameters.AddWithValue("@siparisonayi", 1);
                    komut.Parameters.AddWithValue("@odemedurumu", 1);
                    komut.Parameters.AddWithValue("@miktar", userMenu.k_tutar);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Araç Kiralama Başarılı!");
                    this.Hide();
                    var mfrm = (userMenu)Application.OpenForms["userMenu"];
                    if (mfrm != null)
                        mfrm.listele();

                    //((userMenu)this.Owner).listele();
                }






            }
            else
            {

                MessageBox.Show("Lütfen Alanları Eksiksiz Doldurunuz.");

            }
        }
    }
}
