namespace Ay_Yıldız_Pansiyon_Ve_Dinlenme_Tesisleri
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            label1 = new Label();
            label2 = new Label();
            txtSifre = new TextBox();
            txtKullanıcıAdi = new TextBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(192, 151);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(291, 205);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSifre.Location = new Point(374, 203);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(174, 30);
            txtSifre.TabIndex = 2;
            // 
            // txtKullanıcıAdi
            // 
            txtKullanıcıAdi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtKullanıcıAdi.Location = new Point(374, 149);
            txtKullanıcıAdi.Name = "txtKullanıcıAdi";
            txtKullanıcıAdi.Size = new Size(174, 30);
            txtKullanıcıAdi.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = SystemColors.InactiveCaption;
            btnGirisYap.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.Location = new Point(428, 252);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(120, 35);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGirisYap);
            Controls.Add(txtKullanıcıAdi);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmAdminGiris";
            Text = "Admin Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSifre;
        private TextBox txtKullanıcıAdi;
        private Button btnGirisYap;
    }
}