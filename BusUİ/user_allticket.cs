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
    public partial class user_allticket : Form
    {
        public user_allticket()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        void kayıtgetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from tbl_BiletBilgiler where Kullanıcı_TC=" + Convert.ToInt64(user_login.id) + "";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void user_allticket_Load(object sender, EventArgs e)
        {
            kayıtgetir();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from tbl_BiletBilgiler where Sefer_Tarihi='" + dateTimePicker1.Text + "'and Kullanıcı_TC=" + Convert.ToInt64(user_login.id) + "";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
