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
    public partial class user_activeticket : Form
    {
        public user_activeticket()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        private void user_activeticket_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from tbl_Biletbilgiler where Kullanıcı_TC=" + Convert.ToInt64(user_login.id) + "", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                if (DateTime.Parse(oku2["Sefer_Tarihi"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    int sira = listView1.Items.Count;

                    listView1.Items.Add(oku2["Sefer_Tarihi"].ToString());
                    listView1.Items[sira].SubItems.Add(oku2["Sefer_Adı"].ToString());
                    listView1.Items[sira].SubItems.Add(oku2["Sefer_Saati"].ToString());
                    listView1.Items[sira].SubItems.Add(oku2["Koltuk_No"].ToString());
                    listView1.Items[sira].SubItems.Add(oku2["Fiyat"].ToString());
                }
            }
            baglanti.Close();
        }
    }
}
