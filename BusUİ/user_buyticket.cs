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
    public partial class user_buyticket : Form
    {
        public user_buyticket()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EXTRMER\\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        public string Koltuk_No = "";
        void koltukrengi()
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_BiletBilgiler where Sefer_Adı='" + cb_gidiş.Text + "'", baglanti);

            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ((Button)panel1.Controls["btn" + oku["Koltuk_No"].ToString()]).BackColor = Color.Red;


            }
            oku.Dispose();
            baglanti.Close();
        }
        private void yenidenrenklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void kullanıcıbilgi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_KullanıcıBilgiler where Kullanıcı_TC=" + Convert.ToInt64(user_login.id) + "", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txt_tc.Text = oku["Kullanıcı_TC"].ToString();
                txt_isim.Text = oku["Kullanıcı_Adı"].ToString();
                txt_soyisim.Text = oku["Kullanıcı_Soyadı"].ToString();
                txt_tel.Text = oku["Kullanıcı_Tel"].ToString();

            }
            baglanti.Close();
        }
        private void sefertarihleri()
        {
            SqlCommand komut1 = new SqlCommand();
            baglanti.Open();
            komut1.Connection = baglanti;
            komut1.CommandText = "SELECT * FROM Seferler where Sefer_Adı='" + cb_gidiş.SelectedItem + "'";

            SqlDataReader oku1 = komut1.ExecuteReader();
            try
            {
                while (oku1.Read())
                {
                    if (DateTime.Parse(oku1["Sefer_Tarihi"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        if (!cb_tarih.Items.Contains(oku1["Sefer_Tarihi"].ToString()))
                        {

                        }
                        cb_tarih.Items.Add(oku1["Sefer_Tarihi"].ToString());

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


            baglanti.Close();
        }
        private void illerigetir()
        {
            SqlCommand komut1 = new SqlCommand();
            baglanti.Open();
            komut1.Connection = baglanti;
            komut1.CommandText = "SELECT * FROM Seferbilgiler";
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                cb_gidiş.Items.Add(oku1["Sefer_Adı"]);


            }
            baglanti.Close();
        }
        private void fiyatgetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select* from seferler where Sefer_Adı='" + cb_gidiş.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox1.Text = oku["Fiyat"].ToString();
            }
            baglanti.Close();
        }
        private void sefersaatleri()
        {
            SqlCommand komut1 = new SqlCommand();
            baglanti.Open();
            komut1.Connection = baglanti;
            komut1.CommandText = "SELECT * FROM Seferler where Sefer_Adı='" + cb_gidiş.SelectedItem + "' and Sefer_Tarihi='" + cb_tarih.SelectedItem + "'";
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {

                cb_sefersaati.Items.Add(oku1["Sefer_Saati"]);
            }

            baglanti.Close();
        }
        private void Koltuklar()
        {
            int x = 50, y = 50, sayac = 1, pad = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 2)
                    {
                        continue;
                    }
                    if (i == 5 && j > 1)
                    {
                        continue;
                    }
                    Button btn = new Button();
                    btn.Width = btn.Height = 50;
                    btn.Left = x * j + pad;
                    btn.Top = y * i;
                    btn.BackColor = Color.Gray;
                    btn.Text = sayac.ToString();
                    btn.Name = "btn" + sayac.ToString();
                    sayac++;
                    btn.Click += new EventHandler(Btn_Click);
                    panel1.Controls.Add(btn);
                }
                pad = 0;

            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Koltuk_No = ((Button)sender).Text;
            txt_koltuk.Text = Koltuk_No;
        }
        public int VarMi(string aranan)
        {
            int sonuc;

            string sorgu = "Select COUNT(Koltuk_No) from tbl_Biletbilgiler WHERE Sefer_Adı='" + cb_gidiş.SelectedItem + "' and Sefer_Tarihi='" + cb_tarih.SelectedItem + "'and Sefer_Saati='" + cb_sefersaati.SelectedItem + "'and Koltuk_No='" + aranan + "'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();

            sonuc = Convert.ToInt32(komut.ExecuteScalar());

            baglanti.Close();
            return sonuc;
        }

        private void user_buyticket_Load(object sender, EventArgs e)
        {
            yenidenrenklendir();
            Koltuklar();
            koltukrengi();
            illerigetir();
            kullanıcıbilgi();
            panel1.Visible = false;
            lblseferadı.Text = Properties.Strings.lbl_seferadı;
            lblfiyat.Text = Properties.Strings.lbl_fiyat;
            lblsefersaat.Text = Properties.Strings.lbl_sefersaat;
            lblisim.Text = Properties.Strings.lbl_isim;
            lblsoyisim.Text = Properties.Strings.lbl_soyisim;
            lblcinsiyet.Text = Properties.Strings.combocinsiyet;
            lbltc.Text = Properties.Strings.lbl_tc;
            lbltel.Text = Properties.Strings.lbl_tel;
            lblkoltukno.Text = Properties.Strings.lbl_koltukno;
            lblsefertarih.Text = Properties.Strings.lbl_sefertarih;
            groupBox1.Text = Properties.Strings.grup_seferişlemleri;
            groupBox2.Text = Properties.Strings.grup_kişisel;
           btn_buy.Text = Properties.Strings.buttonsatınal;
            btn_new.Text = Properties.Strings.buttonyeni;

        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (VarMi(txt_koltuk.Text) != 0)
            {
                yenidenrenklendir();
                MessageBox.Show(Properties.Strings.mesajkoltuk, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_isim.Text == "" || txt_soyisim.Text == "" || txt_tc.Text == "" || txt_tel.Text == "" || cb_cinsiyet.Text == "" || cb_gidiş.Text == "" || cb_tarih.Text == "" || cb_sefersaati.Text == "")
            {
                MessageBox.Show(Properties.Strings.mesajboş, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_koltuk.Text == "")
            {
                MessageBox.Show(Properties.Strings.mesajkoltukseç, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string message = Properties.Strings.mesajemin;
                string caption = Properties.Strings.mesajbilgi;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    yenidenrenklendir();
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Delete  From tbl_BiletBilgiler Where Sefer_Adı='" + cb_sefersaati.SelectedItem + "' and Koltuk_No='" + Koltuk_No + "'", baglanti);
                    komut.ExecuteNonQuery();
                    komut = new SqlCommand("INSERT INTO tbl_BiletBilgiler (Kullanıcı_TC,Kullanıcı_Adı,Kullanıcı_Soyadı,Kullanıcı_Cinsiyet,Kullanıcı_Tel,Koltuk_No,Sefer_Adı,Sefer_Tarihi,Sefer_Saati,Fiyat) values(@tc,@adı,@soyadı,@cinsiyet,@tel,@koltukno,@seferadı,@sefertarihi,@sefersaati,@fiyat)", baglanti);
                    komut.Parameters.AddWithValue("@tc", txt_tc.Text);
                    komut.Parameters.AddWithValue("@adı", txt_isim.Text);
                    komut.Parameters.AddWithValue("@soyadı", txt_soyisim.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", cb_cinsiyet.Text);
                    komut.Parameters.AddWithValue("@tel", txt_tel.Text);
                    komut.Parameters.AddWithValue("@koltukno", Koltuk_No);
                    komut.Parameters.AddWithValue("@seferadı", cb_gidiş.Text);
                    komut.Parameters.AddWithValue("@sefertarihi", cb_tarih.Text);
                    komut.Parameters.AddWithValue("@sefersaati", cb_sefersaati.Text);
                    komut.Parameters.AddWithValue("@fiyat", textBox1.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show(Properties.Strings.mesajkayıt, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    komut = new SqlCommand("Select * from tbl_BiletBilgiler where Sefer_Adı='" + cb_gidiş.Text + "' and Sefer_Tarihi='" + cb_tarih.Text + "' and Sefer_Saati='" + cb_sefersaati.Text + "'", baglanti);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {

                        ((Button)panel1.Controls["btn" + oku["Koltuk_No"].ToString()]).BackColor = Color.Red;


                    }
                    baglanti.Close();
                    komut.Parameters.Clear();
                    
                }
                else
                {
                    yenidenrenklendir();
                }
            }
        }

        private void cb_gidiş_SelectedIndexChanged(object sender, EventArgs e)
        {
            yenidenrenklendir();
            cb_sefersaati.Text = "";
            cb_tarih.Text = "";
            cb_sefersaati.Items.Clear();
            cb_tarih.Items.Clear();
            sefertarihleri();
            fiyatgetir();
        }

        private void cb_tarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            yenidenrenklendir();
            cb_sefersaati.Items.Clear();
            
            sefersaatleri();
        }

        private void cb_sefersaati_SelectedIndexChanged(object sender, EventArgs e)
        {
            yenidenrenklendir();
            SqlCommand komut = new SqlCommand("Select * from tbl_BiletBilgiler where Sefer_Adı='" + cb_gidiş.Text + "' and Sefer_Tarihi='" + cb_tarih.Text + "' and Sefer_Saati='" + cb_sefersaati.Text + "'", baglanti);

            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ((Button)panel1.Controls["btn" + oku["Koltuk_No"].ToString()]).BackColor = Color.Red;


            }
            if (cb_sefersaati.Text == "" || cb_tarih.Text == "" || cb_gidiş.Text == "")
            {
                MessageBox.Show(Properties.Strings.mesajboş, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                panel1.Visible = true;

            }

            oku.Dispose();

            baglanti.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_tc.Text = txt_isim.Text = txt_soyisim.Text = txt_tel.Text = cb_cinsiyet.Text = "";
        }
    }
}
