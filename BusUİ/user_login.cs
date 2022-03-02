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
    public partial class user_login : Form
    {
        public user_login()
        {
            InitializeComponent();
        }
        static public long id;
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        private void user_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool kullanıcıvarmi = false;
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from tbl_Kullanıcıbilgiler where Kullanıcı_TC='" + txt_id.Text + "' and Kullanıcı_Şifre='" + txt_password.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {



                kullanıcıvarmi = true;
                id = Convert.ToInt64(oku["Kullanıcı_TC"]);

            }
            if (txt_id.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Boş bırakılamaz");

            }
            else if (kullanıcıvarmi)
            {
                
                MessageBox.Show("Giriş Başarılı");
                user_form user_form = new user_form();
                user_form.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
            baglanti.Close();
            komut.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new_user new_user = new new_user();
            new_user.Show();
            
        }

    

    }
}
