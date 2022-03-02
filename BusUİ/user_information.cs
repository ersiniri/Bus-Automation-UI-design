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
    public partial class user_information : Form
    {
        public user_information()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        private void user_information_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Kullanıcıbilgiler where Kullanıcı_TC=" + Convert.ToInt64(user_login.id) + "", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                txt_ad.Text = oku["Kullanıcı_Adı"].ToString();
                txt_soyad.Text = oku["Kullanıcı_Soyadı"].ToString();
                txt_tel.Text = oku["Kullanıcı_Tel"].ToString();
                txt_kadı.Text = oku["Kullanıcı_Adı"].ToString();
                txt_kşifre.Text = oku["Kullanıcı_Şifre"].ToString();
              


            }
            baglanti.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_Kullanıcıbilgiler set Kullanıcı_Şifre='" + txt_kşifre.Text + "' where Kullanıcı_TC=" + Convert.ToInt64(user_login.id) + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(Properties.Strings.mesajkayıt, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
