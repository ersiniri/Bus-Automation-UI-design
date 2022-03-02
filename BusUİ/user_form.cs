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
    public partial class user_form : Form
    {
        public user_form()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        private void userform_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Kullanıcıbilgiler where Kullanıcı_TC=" + Convert.ToInt64(user_login.id) + "", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

           
                pictureBox1.ImageLocation = oku["Resim_url"].ToString();


            }
            baglanti.Close();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btn_userinformation_Click(object sender, EventArgs e)
        {
            //..

            //..
            openChildForm(new user_information());
        }

        private void user_buyticket_Click(object sender, EventArgs e)
        {
            //..
            
            //..
            openChildForm(new user_buyticket());
        }

        private void user_activeticket_Click(object sender, EventArgs e)
        {
            //..

            //..
            openChildForm(new user_activeticket());
        }

        private void user_allticket_Click(object sender, EventArgs e)
        {
            //..

            //..
            openChildForm(new user_allticket());
        }

        private void user_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_picture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;


            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_Kullanıcıbilgiler set Resim_url='" + pictureBox1.ImageLocation + "' where Kullanıcı_TC=" + Convert.ToInt64(user_login.id) + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(Properties.Strings.mesajresim, Properties.Strings.mesajbilgi, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
    }
}
