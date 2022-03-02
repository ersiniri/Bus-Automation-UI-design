namespace BusUİ
{
    partial class user_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_form));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.user_allticket = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.user_activeticket = new System.Windows.Forms.Button();
            this.user_buyticket = new System.Windows.Forms.Button();
            this.btn_userinformation = new System.Windows.Forms.Button();
            this.btn_picture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSidebar.Controls.Add(this.user_allticket);
            this.panelSidebar.Controls.Add(this.user_activeticket);
            this.panelSidebar.Controls.Add(this.user_buyticket);
            this.panelSidebar.Controls.Add(this.btn_userinformation);
            this.panelSidebar.Controls.Add(this.btn_picture);
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(180, 561);
            this.panelSidebar.TabIndex = 1;
            // 
            // user_allticket
            // 
            this.user_allticket.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_allticket.FlatAppearance.BorderSize = 0;
            this.user_allticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_allticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.user_allticket.ForeColor = System.Drawing.Color.White;
            this.user_allticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_allticket.ImageKey = "two_tickets_96px.png";
            this.user_allticket.ImageList = this.ımageList1;
            this.user_allticket.Location = new System.Drawing.Point(0, 374);
            this.user_allticket.Name = "user_allticket";
            this.user_allticket.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.user_allticket.Size = new System.Drawing.Size(180, 55);
            this.user_allticket.TabIndex = 4;
            this.user_allticket.Text = "Tüm Biletlerim";
            this.user_allticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.user_allticket.UseVisualStyleBackColor = true;
            this.user_allticket.Click += new System.EventHandler(this.user_allticket_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "user_96px.png");
            this.ımageList1.Images.SetKeyName(1, "add_user_male_96px.png");
            this.ımageList1.Images.SetKeyName(2, "new_ticket_96px.png");
            this.ımageList1.Images.SetKeyName(3, "ticket_96px.png");
            this.ımageList1.Images.SetKeyName(4, "login_96px.png");
            this.ımageList1.Images.SetKeyName(5, "camera_96px.png");
            this.ımageList1.Images.SetKeyName(6, "more_info_96px.png");
            this.ımageList1.Images.SetKeyName(7, "two_tickets_96px.png");
            // 
            // user_activeticket
            // 
            this.user_activeticket.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_activeticket.FlatAppearance.BorderSize = 0;
            this.user_activeticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_activeticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.user_activeticket.ForeColor = System.Drawing.Color.White;
            this.user_activeticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_activeticket.ImageKey = "ticket_96px.png";
            this.user_activeticket.ImageList = this.ımageList1;
            this.user_activeticket.Location = new System.Drawing.Point(0, 319);
            this.user_activeticket.Name = "user_activeticket";
            this.user_activeticket.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.user_activeticket.Size = new System.Drawing.Size(180, 55);
            this.user_activeticket.TabIndex = 3;
            this.user_activeticket.Text = "Aktif Biletlerim";
            this.user_activeticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.user_activeticket.UseVisualStyleBackColor = true;
            this.user_activeticket.Click += new System.EventHandler(this.user_activeticket_Click);
            // 
            // user_buyticket
            // 
            this.user_buyticket.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_buyticket.FlatAppearance.BorderSize = 0;
            this.user_buyticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_buyticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.user_buyticket.ForeColor = System.Drawing.Color.White;
            this.user_buyticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_buyticket.ImageKey = "new_ticket_96px.png";
            this.user_buyticket.ImageList = this.ımageList1;
            this.user_buyticket.Location = new System.Drawing.Point(0, 264);
            this.user_buyticket.Name = "user_buyticket";
            this.user_buyticket.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.user_buyticket.Size = new System.Drawing.Size(180, 55);
            this.user_buyticket.TabIndex = 2;
            this.user_buyticket.Text = "Bilet Al";
            this.user_buyticket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.user_buyticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.user_buyticket.UseVisualStyleBackColor = true;
            this.user_buyticket.Click += new System.EventHandler(this.user_buyticket_Click);
            // 
            // btn_userinformation
            // 
            this.btn_userinformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_userinformation.FlatAppearance.BorderSize = 0;
            this.btn_userinformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_userinformation.ForeColor = System.Drawing.Color.White;
            this.btn_userinformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_userinformation.ImageKey = "more_info_96px.png";
            this.btn_userinformation.ImageList = this.ımageList1;
            this.btn_userinformation.Location = new System.Drawing.Point(0, 209);
            this.btn_userinformation.Name = "btn_userinformation";
            this.btn_userinformation.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_userinformation.Size = new System.Drawing.Size(180, 55);
            this.btn_userinformation.TabIndex = 1;
            this.btn_userinformation.Text = "Kullanıcı Bilgiler";
            this.btn_userinformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_userinformation.UseVisualStyleBackColor = true;
            this.btn_userinformation.Click += new System.EventHandler(this.btn_userinformation_Click);
            // 
            // btn_picture
            // 
            this.btn_picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_picture.FlatAppearance.BorderSize = 0;
            this.btn_picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_picture.ForeColor = System.Drawing.Color.White;
            this.btn_picture.ImageKey = "camera_96px.png";
            this.btn_picture.ImageList = this.ımageList1;
            this.btn_picture.Location = new System.Drawing.Point(0, 154);
            this.btn_picture.Name = "btn_picture";
            this.btn_picture.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_picture.Size = new System.Drawing.Size(180, 55);
            this.btn_picture.TabIndex = 1;
            this.btn_picture.UseVisualStyleBackColor = true;
            this.btn_picture.Click += new System.EventHandler(this.btn_picture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(180, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(904, 561);
            this.panelChildForm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "bY ExtrmeR";
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "update_96px.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "user_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.user_form_FormClosed);
            this.Load += new System.EventHandler(this.userform_Load);
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_userinformation;
        private System.Windows.Forms.Button btn_picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button user_allticket;
        private System.Windows.Forms.Button user_activeticket;
        private System.Windows.Forms.Button user_buyticket;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}