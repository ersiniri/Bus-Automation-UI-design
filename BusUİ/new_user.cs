using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BusUİ
{
    public partial class new_user : Form
    {
        public new_user()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            user_login userlogin = new user_login();
            userlogin.Show();
            this.Hide();
            
        }
        public int VarMiTC(string aranan)
        {
            int sonuc;

            string sorgu = "Select COUNT(Kullanıcı_TC) from tbl_Kullanıcıbilgiler WHERE Kullanıcı_TC='" + aranan + "'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();

            sonuc = Convert.ToInt32(komut.ExecuteScalar());

            baglanti.Close();
            return sonuc;
        }
        public int VarMiTel(string aranan1)
        {
            int sonuc;

            string sorgu = "Select COUNT(Kullanıcı_Tel) from tbl_Kullanıcıbilgiler WHERE Kullanıcı_Tel='" + aranan1 + "'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();

            sonuc = Convert.ToInt32(komut.ExecuteScalar());

            baglanti.Close();
            return sonuc;
        }
        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            SqlDataReader reader;

            if (VarMiTC(txt_tc.Text) != 0)
            {
                MessageBox.Show(Properties.Strings.mesajtcvar, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (VarMiTel(txt_tel.Text) != 0)
            {
                MessageBox.Show("Bu telefon numarası kullanılmış");
            }
            else if (txt_adi.Text == "" || txt_soyadı.Text == "" || txt_tc.Text == "" || txt_tel.Text == "" || txt_kadı.Text == "" || txt_sifre.Text == "" || txt_sifretekrar.Text == "")
            {
                MessageBox.Show(Properties.Strings.mesajboş, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_sifre.Text == txt_sifretekrar.Text)
            {



                komut = new SqlCommand("insert into tbl_Kullanıcıbilgiler(Kullanıcı_Adı,Kullanıcı_Soyadı,Kullanıcı_TC,Kullanıcı_Tel,Kullanıcı_Şifre)values(@adı,@soyadı,@tc,@ktel,@ksifre)", baglanti);
                baglanti.Open();
                komut.Parameters.AddWithValue("@adı", txt_adi.Text);
                komut.Parameters.AddWithValue("@soyadı", txt_soyadı.Text);
                komut.Parameters.AddWithValue("@tc", txt_tc.Text);
                komut.Parameters.AddWithValue("@ktel", txt_tel.Text);
                komut.Parameters.AddWithValue("@ksifre", txt_sifre.Text);
                MessageBox.Show(Properties.Strings.mesajkayıt, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Information);
                reader = komut.ExecuteReader();

                baglanti.Close();
                komut.Dispose();

                user_login userlogin = new user_login();
                userlogin.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(Properties.Strings.mesajşifre, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        private void new_user_Load(object sender, EventArgs e)
        {
            lblisim.Text = Properties.Strings.lbl_isim;
            lblsoyisim.Text = Properties.Strings.lbl_soyisim;
            lbltc.Text = Properties.Strings.lbl_tc;
            lbltel.Text = Properties.Strings.lbl_tel;
            lblkadı.Text = Properties.Strings.lbl_kullanıcıadı;
            lblşifre.Text = Properties.Strings.lbl_şifre;
            lblşifretekrar.Text = Properties.Strings.lbl_şifretekrar;
            
        }
    }
}
