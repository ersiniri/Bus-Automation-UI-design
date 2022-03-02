namespace BusUİ
{
    partial class user_buyticket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_buyticket));
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lblkoltukno = new System.Windows.Forms.Label();
            this.lblsefertarih = new System.Windows.Forms.Label();
            this.lblsefersaat = new System.Windows.Forms.Label();
            this.lblseferadı = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_koltuk = new System.Windows.Forms.TextBox();
            this.cb_tarih = new System.Windows.Forms.ComboBox();
            this.cb_sefersaati = new System.Windows.Forms.ComboBox();
            this.cb_gidiş = new System.Windows.Forms.ComboBox();
            this.cb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.lbltc = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.lblsoyisim = new System.Windows.Forms.Label();
            this.lblisim = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btn_buy = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(70, 159);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(51, 20);
            this.lblfiyat.TabIndex = 24;
            this.lblfiyat.Text = "Fiyat :";
            // 
            // lblkoltukno
            // 
            this.lblkoltukno.AutoSize = true;
            this.lblkoltukno.Location = new System.Drawing.Point(36, 127);
            this.lblkoltukno.Name = "lblkoltukno";
            this.lblkoltukno.Size = new System.Drawing.Size(85, 20);
            this.lblkoltukno.TabIndex = 25;
            this.lblkoltukno.Text = "Koltuk No :";
            // 
            // lblsefertarih
            // 
            this.lblsefertarih.AutoSize = true;
            this.lblsefertarih.Location = new System.Drawing.Point(7, 60);
            this.lblsefertarih.Name = "lblsefertarih";
            this.lblsefertarih.Size = new System.Drawing.Size(115, 20);
            this.lblsefertarih.TabIndex = 23;
            this.lblsefertarih.Text = "Sefer Tarihleri :";
            // 
            // lblsefersaat
            // 
            this.lblsefersaat.AutoSize = true;
            this.lblsefersaat.Location = new System.Drawing.Point(7, 94);
            this.lblsefersaat.Name = "lblsefersaat";
            this.lblsefersaat.Size = new System.Drawing.Size(114, 20);
            this.lblsefersaat.TabIndex = 22;
            this.lblsefersaat.Text = "Sefer Saatleri :";
            // 
            // lblseferadı
            // 
            this.lblseferadı.AutoSize = true;
            this.lblseferadı.Location = new System.Drawing.Point(38, 26);
            this.lblseferadı.Name = "lblseferadı";
            this.lblseferadı.Size = new System.Drawing.Size(83, 20);
            this.lblseferadı.TabIndex = 21;
            this.lblseferadı.Text = "Sefer Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(148, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 20;
            // 
            // txt_koltuk
            // 
            this.txt_koltuk.Enabled = false;
            this.txt_koltuk.Location = new System.Drawing.Point(148, 124);
            this.txt_koltuk.Name = "txt_koltuk";
            this.txt_koltuk.Size = new System.Drawing.Size(121, 26);
            this.txt_koltuk.TabIndex = 18;
            // 
            // cb_tarih
            // 
            this.cb_tarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tarih.FormattingEnabled = true;
            this.cb_tarih.Location = new System.Drawing.Point(148, 57);
            this.cb_tarih.Name = "cb_tarih";
            this.cb_tarih.Size = new System.Drawing.Size(121, 28);
            this.cb_tarih.TabIndex = 5;
            this.cb_tarih.SelectedIndexChanged += new System.EventHandler(this.cb_tarih_SelectedIndexChanged);
            // 
            // cb_sefersaati
            // 
            this.cb_sefersaati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sefersaati.FormattingEnabled = true;
            this.cb_sefersaati.Location = new System.Drawing.Point(148, 91);
            this.cb_sefersaati.Name = "cb_sefersaati";
            this.cb_sefersaati.Size = new System.Drawing.Size(121, 28);
            this.cb_sefersaati.TabIndex = 5;
            this.cb_sefersaati.SelectedIndexChanged += new System.EventHandler(this.cb_sefersaati_SelectedIndexChanged);
            // 
            // cb_gidiş
            // 
            this.cb_gidiş.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gidiş.FormattingEnabled = true;
            this.cb_gidiş.Location = new System.Drawing.Point(148, 23);
            this.cb_gidiş.Name = "cb_gidiş";
            this.cb_gidiş.Size = new System.Drawing.Size(121, 28);
            this.cb_gidiş.TabIndex = 1;
            this.cb_gidiş.SelectedIndexChanged += new System.EventHandler(this.cb_gidiş_SelectedIndexChanged);
            // 
            // cb_cinsiyet
            // 
            this.cb_cinsiyet.BackColor = System.Drawing.Color.White;
            this.cb_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cinsiyet.FormattingEnabled = true;
            this.cb_cinsiyet.Items.AddRange(new object[] {
            "",
            "Bay",
            "Bayan"});
            this.cb_cinsiyet.Location = new System.Drawing.Point(152, 153);
            this.cb_cinsiyet.Name = "cb_cinsiyet";
            this.cb_cinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cb_cinsiyet.TabIndex = 19;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(152, 121);
            this.txt_tel.MaxLength = 11;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(121, 26);
            this.txt_tel.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cb_cinsiyet);
            this.groupBox2.Controls.Add(this.txt_tel);
            this.groupBox2.Controls.Add(this.lbltel);
            this.groupBox2.Controls.Add(this.txt_tc);
            this.groupBox2.Controls.Add(this.lbltc);
            this.groupBox2.Controls.Add(this.txt_soyisim);
            this.groupBox2.Controls.Add(this.txt_isim);
            this.groupBox2.Controls.Add(this.lblcinsiyet);
            this.groupBox2.Controls.Add(this.lblsoyisim);
            this.groupBox2.Controls.Add(this.lblisim);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(280, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 201);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişisel Bilgiler";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(28, 124);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(70, 20);
            this.lbltel.TabIndex = 16;
            this.lbltel.Text = "Telefon :";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(152, 25);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(121, 26);
            this.txt_tc.TabIndex = 15;
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(6, 28);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(92, 21);
            this.lbltc.TabIndex = 14;
            this.lbltc.Text = "T.C. Kimlik :\r\n";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(152, 89);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(121, 26);
            this.txt_soyisim.TabIndex = 13;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(152, 57);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(121, 26);
            this.txt_isim.TabIndex = 10;
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(26, 159);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(72, 20);
            this.lblcinsiyet.TabIndex = 0;
            this.lblcinsiyet.Text = "Cinsiyet :";
            // 
            // lblsoyisim
            // 
            this.lblsoyisim.AutoSize = true;
            this.lblsoyisim.Location = new System.Drawing.Point(27, 94);
            this.lblsoyisim.Name = "lblsoyisim";
            this.lblsoyisim.Size = new System.Drawing.Size(71, 20);
            this.lblsoyisim.TabIndex = 0;
            this.lblsoyisim.Text = "Soyisim :";
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(52, 60);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(46, 20);
            this.lblisim.TabIndex = 0;
            this.lblisim.Text = "İsim :";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kapı.png");
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 514);
            this.panel1.TabIndex = 121;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ImageKey = "kapı.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(152, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 49);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblfiyat);
            this.groupBox1.Controls.Add(this.lblkoltukno);
            this.groupBox1.Controls.Add(this.lblsefertarih);
            this.groupBox1.Controls.Add(this.lblsefersaat);
            this.groupBox1.Controls.Add(this.lblseferadı);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_koltuk);
            this.groupBox1.Controls.Add(this.cb_tarih);
            this.groupBox1.Controls.Add(this.cb_sefersaati);
            this.groupBox1.Controls.Add(this.cb_gidiş);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(601, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 201);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer İşlemleri ";
            // 
            // btn_new
            // 
            this.btn_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_new.ImageKey = "add_user_male_96px.png";
            this.btn_new.ImageList = this.ımageList2;
            this.btn_new.Location = new System.Drawing.Point(601, 384);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(161, 88);
            this.btn_new.TabIndex = 124;
            this.btn_new.Text = "Yeni Kayıt";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "update_96px.png");
            this.ımageList2.Images.SetKeyName(1, "new_ticket_96px.png");
            this.ımageList2.Images.SetKeyName(2, "add_user_male_96px.png");
            // 
            // btn_buy
            // 
            this.btn_buy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buy.ImageKey = "new_ticket_96px.png";
            this.btn_buy.ImageList = this.ımageList2;
            this.btn_buy.Location = new System.Drawing.Point(380, 384);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(178, 88);
            this.btn_buy.TabIndex = 125;
            this.btn_buy.Text = "Satın Al";
            this.btn_buy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // user_buyticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(891, 538);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "user_buyticket";
            this.Text = "user_buyticket";
            this.Load += new System.EventHandler(this.user_buyticket_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lblkoltukno;
        private System.Windows.Forms.Label lblsefertarih;
        private System.Windows.Forms.Label lblsefersaat;
        private System.Windows.Forms.Label lblseferadı;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_koltuk;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ComboBox cb_tarih;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.ComboBox cb_sefersaati;
        private System.Windows.Forms.ComboBox cb_gidiş;
        private System.Windows.Forms.ComboBox cb_cinsiyet;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.Label lblsoyisim;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList ımageList2;

    }
}