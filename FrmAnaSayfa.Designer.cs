namespace Ay_Yıldız_Pansiyon_Ve_Dinlenme_Tesisleri
{
    partial class FrmAnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            btn_AdminGiris = new Button();
            btn_YeniMusteri = new Button();
            btn_odalar = new Button();
            SuspendLayout();
            // 
            // btn_AdminGiris
            // 
            btn_AdminGiris.BackColor = Color.LightCoral;
            btn_AdminGiris.BackgroundImageLayout = ImageLayout.None;
            btn_AdminGiris.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_AdminGiris.Location = new Point(630, 9);
            btn_AdminGiris.Name = "btn_AdminGiris";
            btn_AdminGiris.Size = new Size(158, 70);
            btn_AdminGiris.TabIndex = 0;
            btn_AdminGiris.Text = "Admin Giriş";
            btn_AdminGiris.UseVisualStyleBackColor = false;
            btn_AdminGiris.Click += btn_AdminGiris_Click;
            // 
            // btn_YeniMusteri
            // 
            btn_YeniMusteri.BackColor = Color.LightCoral;
            btn_YeniMusteri.BackgroundImageLayout = ImageLayout.None;
            btn_YeniMusteri.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_YeniMusteri.Location = new Point(630, 85);
            btn_YeniMusteri.Name = "btn_YeniMusteri";
            btn_YeniMusteri.Size = new Size(158, 70);
            btn_YeniMusteri.TabIndex = 1;
            btn_YeniMusteri.Text = "Yeni Müşteri";
            btn_YeniMusteri.UseVisualStyleBackColor = false;
            btn_YeniMusteri.Click += btn_YeniMusteri_Click;
            // 
            // btn_odalar
            // 
            btn_odalar.BackColor = Color.LightCoral;
            btn_odalar.BackgroundImageLayout = ImageLayout.None;
            btn_odalar.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_odalar.Location = new Point(630, 161);
            btn_odalar.Name = "btn_odalar";
            btn_odalar.Size = new Size(158, 70);
            btn_odalar.TabIndex = 2;
            btn_odalar.Text = "Odalar";
            btn_odalar.UseVisualStyleBackColor = false;
            // 
            // FrmAnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_odalar);
            Controls.Add(btn_YeniMusteri);
            Controls.Add(btn_AdminGiris);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmAnaForm";
            Text = "Ana Sayfa";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_AdminGiris;
        private Button btn_YeniMusteri;
        private Button btn_odalar;
    }
}
