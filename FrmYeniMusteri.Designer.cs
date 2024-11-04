namespace Ay_Yıldız_Pansiyon_Ve_Dinlenme_Tesisleri
{
    partial class FrmYeniMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniMusteri));
            groupBox1 = new GroupBox();
            lbl_günadet = new Label();
            cb_cinsiyet = new ComboBox();
            text_ücret = new TextBox();
            btn_ücret = new Label();
            btnKaydet = new Button();
            text_odaNo = new TextBox();
            text_tck_no = new TextBox();
            text_mail = new TextBox();
            dtp_cıkısTarihi = new DateTimePicker();
            dtp_girisTarihi = new DateTimePicker();
            maskedText_tlfn_No = new MaskedTextBox();
            text_soyadi = new TextBox();
            text_adi = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            oda_Dolu = new Button();
            oda306 = new Button();
            oda_Bos = new Button();
            oda305 = new Button();
            oda304 = new Button();
            oda303 = new Button();
            oda302 = new Button();
            oda301 = new Button();
            oda206 = new Button();
            oda205 = new Button();
            oda204 = new Button();
            oda203 = new Button();
            oda202 = new Button();
            oda201 = new Button();
            oda106 = new Button();
            oda105 = new Button();
            oda103 = new Button();
            oda102 = new Button();
            oda104 = new Button();
            oda101 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_günadet);
            groupBox1.Controls.Add(cb_cinsiyet);
            groupBox1.Controls.Add(text_ücret);
            groupBox1.Controls.Add(btn_ücret);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(text_odaNo);
            groupBox1.Controls.Add(text_tck_no);
            groupBox1.Controls.Add(text_mail);
            groupBox1.Controls.Add(dtp_cıkısTarihi);
            groupBox1.Controls.Add(dtp_girisTarihi);
            groupBox1.Controls.Add(maskedText_tlfn_No);
            groupBox1.Controls.Add(text_soyadi);
            groupBox1.Controls.Add(text_adi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 500);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Bilgileri:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lbl_günadet
            // 
            lbl_günadet.AutoSize = true;
            lbl_günadet.Location = new Point(55, 462);
            lbl_günadet.Name = "lbl_günadet";
            lbl_günadet.Size = new Size(19, 23);
            lbl_günadet.TabIndex = 39;
            lbl_günadet.Text = "0";
            lbl_günadet.Visible = false;
            // 
            // cb_cinsiyet
            // 
            cb_cinsiyet.BackColor = SystemColors.InactiveCaption;
            cb_cinsiyet.FormattingEnabled = true;
            cb_cinsiyet.Items.AddRange(new object[] { "Bay", "Bayan" });
            cb_cinsiyet.Location = new Point(189, 127);
            cb_cinsiyet.Name = "cb_cinsiyet";
            cb_cinsiyet.Size = new Size(189, 31);
            cb_cinsiyet.TabIndex = 38;
            // 
            // text_ücret
            // 
            text_ücret.BackColor = SystemColors.InactiveCaption;
            text_ücret.Enabled = false;
            text_ücret.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            text_ücret.Location = new Point(189, 337);
            text_ücret.Name = "text_ücret";
            text_ücret.Size = new Size(189, 31);
            text_ücret.TabIndex = 37;
            // 
            // btn_ücret
            // 
            btn_ücret.AutoSize = true;
            btn_ücret.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            btn_ücret.Location = new Point(110, 341);
            btn_ücret.Name = "btn_ücret";
            btn_ücret.Size = new Size(73, 24);
            btn_ücret.TabIndex = 36;
            btn_ücret.Text = "Ücret:";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.MediumSlateBlue;
            btnKaydet.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = SystemColors.ActiveCaptionText;
            btnKaydet.Location = new Point(284, 453);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 38);
            btnKaydet.TabIndex = 35;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // text_odaNo
            // 
            text_odaNo.BackColor = SystemColors.InactiveCaption;
            text_odaNo.Enabled = false;
            text_odaNo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            text_odaNo.Location = new Point(189, 293);
            text_odaNo.Name = "text_odaNo";
            text_odaNo.Size = new Size(189, 31);
            text_odaNo.TabIndex = 34;
            // 
            // text_tck_no
            // 
            text_tck_no.BackColor = SystemColors.InactiveCaption;
            text_tck_no.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            text_tck_no.Location = new Point(189, 251);
            text_tck_no.MaxLength = 11;
            text_tck_no.Name = "text_tck_no";
            text_tck_no.Size = new Size(189, 31);
            text_tck_no.TabIndex = 33;
            // 
            // text_mail
            // 
            text_mail.BackColor = SystemColors.InactiveCaption;
            text_mail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            text_mail.Location = new Point(189, 208);
            text_mail.Name = "text_mail";
            text_mail.Size = new Size(189, 31);
            text_mail.TabIndex = 32;
            // 
            // dtp_cıkısTarihi
            // 
            dtp_cıkısTarihi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dtp_cıkısTarihi.Location = new Point(189, 418);
            dtp_cıkısTarihi.Name = "dtp_cıkısTarihi";
            dtp_cıkısTarihi.Size = new Size(189, 31);
            dtp_cıkısTarihi.TabIndex = 31;
            dtp_cıkısTarihi.ValueChanged += dtp_cıkısTarihi_ValueChanged;
            // 
            // dtp_girisTarihi
            // 
            dtp_girisTarihi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dtp_girisTarihi.Location = new Point(189, 385);
            dtp_girisTarihi.Name = "dtp_girisTarihi";
            dtp_girisTarihi.Size = new Size(189, 31);
            dtp_girisTarihi.TabIndex = 30;
            // 
            // maskedText_tlfn_No
            // 
            maskedText_tlfn_No.BackColor = SystemColors.InactiveCaption;
            maskedText_tlfn_No.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            maskedText_tlfn_No.Location = new Point(189, 167);
            maskedText_tlfn_No.Mask = "(999) 000-0000";
            maskedText_tlfn_No.Name = "maskedText_tlfn_No";
            maskedText_tlfn_No.Size = new Size(189, 31);
            maskedText_tlfn_No.TabIndex = 29;
            // 
            // text_soyadi
            // 
            text_soyadi.BackColor = SystemColors.InactiveCaption;
            text_soyadi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            text_soyadi.Location = new Point(189, 86);
            text_soyadi.Name = "text_soyadi";
            text_soyadi.Size = new Size(189, 31);
            text_soyadi.TabIndex = 28;
            // 
            // text_adi
            // 
            text_adi.BackColor = SystemColors.InactiveCaption;
            text_adi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            text_adi.Location = new Point(189, 42);
            text_adi.Name = "text_adi";
            text_adi.Size = new Size(189, 31);
            text_adi.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label9.Location = new Point(44, 424);
            label9.Name = "label9";
            label9.Size = new Size(139, 24);
            label9.TabIndex = 26;
            label9.Text = "Çıkış Tarihi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label8.Location = new Point(47, 391);
            label8.Name = "label8";
            label8.Size = new Size(136, 24);
            label8.TabIndex = 25;
            label8.Text = "Giriş Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label7.Location = new Point(81, 133);
            label7.Name = "label7";
            label7.Size = new Size(102, 24);
            label7.TabIndex = 24;
            label7.Text = "Cinsiyet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label6.Location = new Point(92, 297);
            label6.Name = "label6";
            label6.Size = new Size(91, 24);
            label6.TabIndex = 23;
            label6.Text = "Oda No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label5.Location = new Point(19, 255);
            label5.Name = "label5";
            label5.Size = new Size(164, 24);
            label5.TabIndex = 22;
            label5.Text = "T.C Kimlik No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label4.Location = new Point(122, 212);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 21;
            label4.Text = "Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label3.Location = new Point(55, 167);
            label3.Name = "label3";
            label3.Size = new Size(128, 24);
            label3.TabIndex = 20;
            label3.Text = "Telefon No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label2.Location = new Point(98, 90);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 19;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label1.Location = new Point(133, 46);
            label1.Name = "label1";
            label1.Size = new Size(50, 24);
            label1.TabIndex = 18;
            label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(oda_Dolu);
            groupBox2.Controls.Add(oda306);
            groupBox2.Controls.Add(oda_Bos);
            groupBox2.Controls.Add(oda305);
            groupBox2.Controls.Add(oda304);
            groupBox2.Controls.Add(oda303);
            groupBox2.Controls.Add(oda302);
            groupBox2.Controls.Add(oda301);
            groupBox2.Controls.Add(oda206);
            groupBox2.Controls.Add(oda205);
            groupBox2.Controls.Add(oda204);
            groupBox2.Controls.Add(oda203);
            groupBox2.Controls.Add(oda202);
            groupBox2.Controls.Add(oda201);
            groupBox2.Controls.Add(oda106);
            groupBox2.Controls.Add(oda105);
            groupBox2.Controls.Add(oda103);
            groupBox2.Controls.Add(oda102);
            groupBox2.Controls.Add(oda104);
            groupBox2.Controls.Add(oda101);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(485, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 500);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odalar:";
            // 
            // oda_Dolu
            // 
            oda_Dolu.BackColor = Color.MediumSlateBlue;
            oda_Dolu.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda_Dolu.Location = new Point(264, 453);
            oda_Dolu.Name = "oda_Dolu";
            oda_Dolu.Size = new Size(162, 35);
            oda_Dolu.TabIndex = 3;
            oda_Dolu.Text = "Dolu Odalar";
            oda_Dolu.UseVisualStyleBackColor = false;
            oda_Dolu.Click += oda_Dolu_Click;
            // 
            // oda306
            // 
            oda306.BackColor = Color.LightBlue;
            oda306.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda306.Location = new Point(327, 370);
            oda306.Name = "oda306";
            oda306.Size = new Size(102, 46);
            oda306.TabIndex = 17;
            oda306.Text = "306";
            oda306.UseVisualStyleBackColor = false;
            oda306.Click += oda306_Click;
            // 
            // oda_Bos
            // 
            oda_Bos.BackColor = Color.LightBlue;
            oda_Bos.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda_Bos.Location = new Point(7, 453);
            oda_Bos.Name = "oda_Bos";
            oda_Bos.Size = new Size(162, 35);
            oda_Bos.TabIndex = 2;
            oda_Bos.Text = "Boş Odalar";
            oda_Bos.UseVisualStyleBackColor = false;
            oda_Bos.Click += oda_Bos_Click;
            // 
            // oda305
            // 
            oda305.BackColor = Color.LightBlue;
            oda305.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda305.Location = new Point(170, 370);
            oda305.Name = "oda305";
            oda305.Size = new Size(102, 46);
            oda305.TabIndex = 16;
            oda305.Text = "305";
            oda305.UseVisualStyleBackColor = false;
            oda305.Click += oda305_Click;
            // 
            // oda304
            // 
            oda304.BackColor = Color.LightBlue;
            oda304.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda304.Location = new Point(5, 370);
            oda304.Name = "oda304";
            oda304.Size = new Size(102, 46);
            oda304.TabIndex = 15;
            oda304.Text = "304";
            oda304.UseVisualStyleBackColor = false;
            oda304.Click += oda304_Click;
            // 
            // oda303
            // 
            oda303.BackColor = Color.LightBlue;
            oda303.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda303.Location = new Point(327, 303);
            oda303.Name = "oda303";
            oda303.Size = new Size(102, 46);
            oda303.TabIndex = 14;
            oda303.Text = "303";
            oda303.UseVisualStyleBackColor = false;
            oda303.Click += oda303_Click;
            // 
            // oda302
            // 
            oda302.BackColor = Color.LightBlue;
            oda302.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda302.Location = new Point(170, 303);
            oda302.Name = "oda302";
            oda302.Size = new Size(102, 46);
            oda302.TabIndex = 13;
            oda302.Text = "302";
            oda302.UseVisualStyleBackColor = false;
            oda302.Click += oda302_Click;
            // 
            // oda301
            // 
            oda301.BackColor = Color.LightBlue;
            oda301.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda301.Location = new Point(5, 303);
            oda301.Name = "oda301";
            oda301.Size = new Size(102, 46);
            oda301.TabIndex = 12;
            oda301.Text = "301";
            oda301.UseVisualStyleBackColor = false;
            oda301.Click += oda301_Click;
            // 
            // oda206
            // 
            oda206.BackColor = Color.LightBlue;
            oda206.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda206.Location = new Point(327, 234);
            oda206.Name = "oda206";
            oda206.Size = new Size(102, 46);
            oda206.TabIndex = 11;
            oda206.Text = "206";
            oda206.UseVisualStyleBackColor = false;
            oda206.Click += oda206_Click;
            // 
            // oda205
            // 
            oda205.BackColor = Color.LightBlue;
            oda205.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda205.Location = new Point(170, 234);
            oda205.Name = "oda205";
            oda205.Size = new Size(102, 46);
            oda205.TabIndex = 10;
            oda205.Text = "205";
            oda205.UseVisualStyleBackColor = false;
            oda205.Click += oda205_Click;
            // 
            // oda204
            // 
            oda204.BackColor = Color.LightBlue;
            oda204.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda204.Location = new Point(5, 234);
            oda204.Name = "oda204";
            oda204.Size = new Size(102, 46);
            oda204.TabIndex = 9;
            oda204.Text = "204";
            oda204.UseVisualStyleBackColor = false;
            oda204.Click += oda204_Click;
            // 
            // oda203
            // 
            oda203.BackColor = Color.LightBlue;
            oda203.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda203.Location = new Point(327, 167);
            oda203.Name = "oda203";
            oda203.Size = new Size(102, 46);
            oda203.TabIndex = 8;
            oda203.Text = "203";
            oda203.UseVisualStyleBackColor = false;
            oda203.Click += oda203_Click;
            // 
            // oda202
            // 
            oda202.BackColor = Color.LightBlue;
            oda202.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda202.Location = new Point(170, 167);
            oda202.Name = "oda202";
            oda202.Size = new Size(102, 46);
            oda202.TabIndex = 7;
            oda202.Text = "202";
            oda202.UseVisualStyleBackColor = false;
            oda202.Click += oda202_Click;
            // 
            // oda201
            // 
            oda201.BackColor = Color.LightBlue;
            oda201.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda201.Location = new Point(5, 167);
            oda201.Name = "oda201";
            oda201.Size = new Size(102, 46);
            oda201.TabIndex = 6;
            oda201.Text = "201";
            oda201.UseVisualStyleBackColor = false;
            oda201.Click += oda201_Click;
            // 
            // oda106
            // 
            oda106.BackColor = Color.LightBlue;
            oda106.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda106.Location = new Point(327, 101);
            oda106.Name = "oda106";
            oda106.Size = new Size(102, 46);
            oda106.TabIndex = 5;
            oda106.Text = "106";
            oda106.UseVisualStyleBackColor = false;
            oda106.Click += oda106_Click;
            // 
            // oda105
            // 
            oda105.BackColor = Color.LightBlue;
            oda105.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda105.Location = new Point(170, 101);
            oda105.Name = "oda105";
            oda105.Size = new Size(102, 44);
            oda105.TabIndex = 4;
            oda105.Text = "105";
            oda105.UseVisualStyleBackColor = false;
            oda105.Click += oda105_Click;
            // 
            // oda103
            // 
            oda103.BackColor = Color.LightBlue;
            oda103.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda103.Location = new Point(327, 36);
            oda103.Name = "oda103";
            oda103.Size = new Size(102, 46);
            oda103.TabIndex = 3;
            oda103.Text = "103";
            oda103.UseVisualStyleBackColor = false;
            oda103.Click += oda103_Click;
            // 
            // oda102
            // 
            oda102.BackColor = Color.LightBlue;
            oda102.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda102.Location = new Point(170, 36);
            oda102.Name = "oda102";
            oda102.Size = new Size(102, 46);
            oda102.TabIndex = 2;
            oda102.Text = "102";
            oda102.UseVisualStyleBackColor = false;
            oda102.Click += oda102_Click;
            // 
            // oda104
            // 
            oda104.BackColor = Color.LightBlue;
            oda104.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda104.Location = new Point(5, 101);
            oda104.Name = "oda104";
            oda104.Size = new Size(102, 46);
            oda104.TabIndex = 4;
            oda104.Text = "104";
            oda104.UseVisualStyleBackColor = false;
            oda104.Click += oda104_Click;
            // 
            // oda101
            // 
            oda101.BackColor = Color.LightBlue;
            oda101.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold);
            oda101.Location = new Point(7, 36);
            oda101.Name = "oda101";
            oda101.Size = new Size(102, 46);
            oda101.TabIndex = 0;
            oda101.Text = "101";
            oda101.UseVisualStyleBackColor = false;
            oda101.Click += oda101_Click;
            // 
            // FrmYeniMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1029, 567);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmYeniMusteri";
            Text = "Yeni Müşteri Ekle";
            Load += FrmYeniMusteri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnKaydet;
        private TextBox text_odaNo;
        private TextBox text_tck_no;
        private TextBox text_mail;
        private DateTimePicker dtp_cıkısTarihi;
        private DateTimePicker dtp_girisTarihi;
        private MaskedTextBox maskedText_tlfn_No;
        private TextBox text_soyadi;
        private TextBox text_adi;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button oda201;
        private Button oda106;
        private Button oda105;
        private Button oda103;
        private Button oda102;
        private Button oda104;
        private Button oda101;
        private Button oda303;
        private Button oda302;
        private Button oda301;
        private Button oda206;
        private Button oda205;
        private Button oda204;
        private Button oda203;
        private Button oda202;
        private Button oda306;
        private Button oda305;
        private Button oda304;
        private Button oda_Bos;
        private Button oda_Dolu;
        private TextBox text_ücret;
        private Label btn_ücret;
        private ComboBox cb_cinsiyet;
        private Label lbl_günadet;
    }
}