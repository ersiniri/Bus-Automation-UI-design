namespace BusUİ
{
    partial class user_information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_information));
            this.btn_update = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblsoyisim = new System.Windows.Forms.Label();
            this.lblisim = new System.Windows.Forms.Label();
            this.lblşifre = new System.Windows.Forms.Label();
            this.lblkadı = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.txt_kşifre = new System.Windows.Forms.TextBox();
            this.txt_kadı = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.ImageKey = "update_96px.png";
            this.btn_update.ImageList = this.ımageList2;
            this.btn_update.Location = new System.Drawing.Point(217, 282);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(148, 69);
            this.btn_update.TabIndex = 70;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "update_96px.png");
            // 
            // lblsoyisim
            // 
            this.lblsoyisim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblsoyisim.AutoSize = true;
            this.lblsoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyisim.ForeColor = System.Drawing.Color.White;
            this.lblsoyisim.Location = new System.Drawing.Point(145, 97);
            this.lblsoyisim.Name = "lblsoyisim";
            this.lblsoyisim.Size = new System.Drawing.Size(85, 24);
            this.lblsoyisim.TabIndex = 66;
            this.lblsoyisim.Text = "Soyisim :";
            // 
            // lblisim
            // 
            this.lblisim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblisim.AutoSize = true;
            this.lblisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblisim.ForeColor = System.Drawing.Color.White;
            this.lblisim.Location = new System.Drawing.Point(177, 62);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(53, 24);
            this.lblisim.TabIndex = 65;
            this.lblisim.Text = "İsim :";
            // 
            // lblşifre
            // 
            this.lblşifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblşifre.AutoSize = true;
            this.lblşifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblşifre.ForeColor = System.Drawing.Color.White;
            this.lblşifre.Location = new System.Drawing.Point(168, 202);
            this.lblşifre.Name = "lblşifre";
            this.lblşifre.Size = new System.Drawing.Size(62, 24);
            this.lblşifre.TabIndex = 69;
            this.lblşifre.Text = "Şifre : ";
            // 
            // lblkadı
            // 
            this.lblkadı.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblkadı.AutoSize = true;
            this.lblkadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkadı.ForeColor = System.Drawing.Color.White;
            this.lblkadı.Location = new System.Drawing.Point(107, 167);
            this.lblkadı.Name = "lblkadı";
            this.lblkadı.Size = new System.Drawing.Size(123, 24);
            this.lblkadı.TabIndex = 68;
            this.lblkadı.Text = "Kullanıcı Adı :";
            // 
            // lbltel
            // 
            this.lbltel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltel.ForeColor = System.Drawing.Color.White;
            this.lbltel.Location = new System.Drawing.Point(146, 132);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(84, 24);
            this.lbltel.TabIndex = 67;
            this.lbltel.Text = "Telefon :";
            // 
            // txt_kşifre
            // 
            this.txt_kşifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kşifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kşifre.Location = new System.Drawing.Point(256, 199);
            this.txt_kşifre.Name = "txt_kşifre";
            this.txt_kşifre.Size = new System.Drawing.Size(198, 29);
            this.txt_kşifre.TabIndex = 62;
            // 
            // txt_kadı
            // 
            this.txt_kadı.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kadı.Enabled = false;
            this.txt_kadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kadı.Location = new System.Drawing.Point(256, 164);
            this.txt_kadı.Name = "txt_kadı";
            this.txt_kadı.Size = new System.Drawing.Size(198, 29);
            this.txt_kadı.TabIndex = 63;
            // 
            // txt_tel
            // 
            this.txt_tel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tel.Enabled = false;
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tel.Location = new System.Drawing.Point(256, 129);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(198, 29);
            this.txt_tel.TabIndex = 64;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_soyad.Enabled = false;
            this.txt_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(256, 94);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(198, 29);
            this.txt_soyad.TabIndex = 60;
            // 
            // txt_ad
            // 
            this.txt_ad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ad.Enabled = false;
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(256, 59);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(198, 29);
            this.txt_ad.TabIndex = 61;
            // 
            // user_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(589, 387);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lblsoyisim);
            this.Controls.Add(this.lblisim);
            this.Controls.Add(this.lblşifre);
            this.Controls.Add(this.lblkadı);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.txt_kşifre);
            this.Controls.Add(this.txt_kadı);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Name = "user_information";
            this.Load += new System.EventHandler(this.user_information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lblsoyisim;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.Label lblşifre;
        private System.Windows.Forms.Label lblkadı;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.TextBox txt_kşifre;
        private System.Windows.Forms.TextBox txt_kadı;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.ImageList ımageList2;
    }
}