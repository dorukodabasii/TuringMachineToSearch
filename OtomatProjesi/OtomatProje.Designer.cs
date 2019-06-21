namespace OtomatProjesi
{
    partial class OtomatProje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtomatProje));
            this.txtTextSayisi = new DevExpress.XtraEditors.TextEdit();
            this.btnTextSayisi = new DevExpress.XtraEditors.SimpleButton();
            this.btnSıfırla = new DevExpress.XtraEditors.SimpleButton();
            this.btnTuringOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.Okİsareti = new DevExpress.XtraEditors.PictureEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtDegerAra = new DevExpress.XtraEditors.TextEdit();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.lblOkunanDeger = new System.Windows.Forms.Label();
            this.lblAranan = new System.Windows.Forms.Label();
            this.listBulunanlar = new System.Windows.Forms.ListBox();
            this.btnOtomatHizlandir = new DevExpress.XtraEditors.SimpleButton();
            this.btnOtomatYavaslat = new DevExpress.XtraEditors.SimpleButton();
            this.lblNot = new System.Windows.Forms.Label();
            this.lblNot2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtTextSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Okİsareti.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDegerAra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTextSayisi
            // 
            this.txtTextSayisi.Location = new System.Drawing.Point(389, 23);
            this.txtTextSayisi.Name = "txtTextSayisi";
            this.txtTextSayisi.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTextSayisi.Properties.Appearance.Options.UseBackColor = true;
            this.txtTextSayisi.Size = new System.Drawing.Size(255, 22);
            this.txtTextSayisi.TabIndex = 0;
            this.txtTextSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTextSayisi_KeyPress);
            this.txtTextSayisi.Leave += new System.EventHandler(this.txtTextSayisi_Leave);
            // 
            // btnTextSayisi
            // 
            this.btnTextSayisi.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTextSayisi.Appearance.Options.UseFont = true;
            this.btnTextSayisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTextSayisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTextSayisi.ImageOptions.Image")));
            this.btnTextSayisi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnTextSayisi.Location = new System.Drawing.Point(389, 51);
            this.btnTextSayisi.Name = "btnTextSayisi";
            this.btnTextSayisi.Size = new System.Drawing.Size(115, 29);
            this.btnTextSayisi.TabIndex = 1;
            this.btnTextSayisi.Text = "Oluştur";
            this.btnTextSayisi.Click += new System.EventHandler(this.btnTextSayisi_Click);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıfırla.Appearance.Options.UseFont = true;
            this.btnSıfırla.Enabled = false;
            this.btnSıfırla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSıfırla.ImageOptions.Image")));
            this.btnSıfırla.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSıfırla.Location = new System.Drawing.Point(510, 51);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(134, 29);
            this.btnSıfırla.TabIndex = 2;
            this.btnSıfırla.Text = "Sıfırla";
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // btnTuringOlustur
            // 
            this.btnTuringOlustur.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTuringOlustur.Appearance.Options.UseFont = true;
            this.btnTuringOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTuringOlustur.ImageOptions.Image")));
            this.btnTuringOlustur.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnTuringOlustur.Location = new System.Drawing.Point(308, 273);
            this.btnTuringOlustur.Name = "btnTuringOlustur";
            this.btnTuringOlustur.Size = new System.Drawing.Size(395, 29);
            this.btnTuringOlustur.TabIndex = 3;
            this.btnTuringOlustur.Text = "Turing Makinesini Oluştur";
            this.btnTuringOlustur.Visible = false;
            this.btnTuringOlustur.Click += new System.EventHandler(this.btnTuringOlustur_Click);
            // 
            // Okİsareti
            // 
            this.Okİsareti.EditValue = ((object)(resources.GetObject("Okİsareti.EditValue")));
            this.Okİsareti.Location = new System.Drawing.Point(43, 175);
            this.Okİsareti.Name = "Okİsareti";
            this.Okİsareti.Properties.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Okİsareti.Properties.Appearance.Options.UseBackColor = true;
            this.Okİsareti.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Okİsareti.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.Okİsareti.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Okİsareti.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchVertical;
            this.Okİsareti.Properties.ZoomPercent = 200D;
            this.Okİsareti.Size = new System.Drawing.Size(30, 40);
            this.Okİsareti.TabIndex = 5;
            this.Okİsareti.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtDegerAra
            // 
            this.txtDegerAra.Location = new System.Drawing.Point(697, 23);
            this.txtDegerAra.Name = "txtDegerAra";
            this.txtDegerAra.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDegerAra.Properties.Appearance.Options.UseBackColor = true;
            this.txtDegerAra.Size = new System.Drawing.Size(152, 22);
            this.txtDegerAra.TabIndex = 6;
            this.txtDegerAra.Visible = false;
            this.txtDegerAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDegerAra_KeyPress);
            // 
            // BtnAra
            // 
            this.BtnAra.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Appearance.Options.UseFont = true;
            this.BtnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.ImageOptions.Image")));
            this.BtnAra.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.BtnAra.Location = new System.Drawing.Point(697, 51);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(152, 29);
            this.BtnAra.TabIndex = 7;
            this.BtnAra.Text = "Ara";
            this.BtnAra.Visible = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // lblOkunanDeger
            // 
            this.lblOkunanDeger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOkunanDeger.Location = new System.Drawing.Point(868, 21);
            this.lblOkunanDeger.Name = "lblOkunanDeger";
            this.lblOkunanDeger.Size = new System.Drawing.Size(187, 37);
            this.lblOkunanDeger.TabIndex = 8;
            this.lblOkunanDeger.Text = "Okunan Deger :";
            this.lblOkunanDeger.Visible = false;
            // 
            // lblAranan
            // 
            this.lblAranan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAranan.Location = new System.Drawing.Point(868, 55);
            this.lblAranan.Name = "lblAranan";
            this.lblAranan.Size = new System.Drawing.Size(187, 37);
            this.lblAranan.TabIndex = 9;
            this.lblAranan.Text = "Aranan Deger  :";
            this.lblAranan.Visible = false;
            // 
            // listBulunanlar
            // 
            this.listBulunanlar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.listBulunanlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBulunanlar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBulunanlar.FormattingEnabled = true;
            this.listBulunanlar.ItemHeight = 23;
            this.listBulunanlar.Location = new System.Drawing.Point(308, 309);
            this.listBulunanlar.Name = "listBulunanlar";
            this.listBulunanlar.Size = new System.Drawing.Size(395, 140);
            this.listBulunanlar.TabIndex = 10;
            this.listBulunanlar.Visible = false;
            // 
            // btnOtomatHizlandir
            // 
            this.btnOtomatHizlandir.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOtomatHizlandir.Appearance.Options.UseFont = true;
            this.btnOtomatHizlandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOtomatHizlandir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOtomatHizlandir.ImageOptions.Image")));
            this.btnOtomatHizlandir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnOtomatHizlandir.Location = new System.Drawing.Point(144, 21);
            this.btnOtomatHizlandir.Name = "btnOtomatHizlandir";
            this.btnOtomatHizlandir.Size = new System.Drawing.Size(213, 24);
            this.btnOtomatHizlandir.TabIndex = 11;
            this.btnOtomatHizlandir.Text = "Otomatı Hızlandır";
            this.btnOtomatHizlandir.Visible = false;
            this.btnOtomatHizlandir.Click += new System.EventHandler(this.btnOtomatHizlandir_Click);
            // 
            // btnOtomatYavaslat
            // 
            this.btnOtomatYavaslat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOtomatYavaslat.Appearance.Options.UseFont = true;
            this.btnOtomatYavaslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOtomatYavaslat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOtomatYavaslat.ImageOptions.Image")));
            this.btnOtomatYavaslat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnOtomatYavaslat.Location = new System.Drawing.Point(144, 56);
            this.btnOtomatYavaslat.Name = "btnOtomatYavaslat";
            this.btnOtomatYavaslat.Size = new System.Drawing.Size(213, 24);
            this.btnOtomatYavaslat.TabIndex = 12;
            this.btnOtomatYavaslat.Text = "Otomatı Yavaşlat";
            this.btnOtomatYavaslat.Visible = false;
            this.btnOtomatYavaslat.Click += new System.EventHandler(this.btnOtomatYavaslat_Click);
            // 
            // lblNot
            // 
            this.lblNot.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblNot.ForeColor = System.Drawing.Color.Red;
            this.lblNot.Location = new System.Drawing.Point(303, 242);
            this.lblNot.Name = "lblNot";
            this.lblNot.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblNot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNot.Size = new System.Drawing.Size(400, 28);
            this.lblNot.TabIndex = 13;
            this.lblNot.Text = "Kırmızıdan önceki textboxlar okunmuştur!\r\n";
            this.lblNot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNot.Visible = false;
            // 
            // lblNot2
            // 
            this.lblNot2.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblNot2.ForeColor = System.Drawing.Color.Red;
            this.lblNot2.Location = new System.Drawing.Point(304, 273);
            this.lblNot2.Name = "lblNot2";
            this.lblNot2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblNot2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNot2.Size = new System.Drawing.Size(400, 33);
            this.lblNot2.TabIndex = 14;
            this.lblNot2.Text = "Ok İşareti Şuanda Okunan değeri Gösterir!.";
            this.lblNot2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNot2.Visible = false;
            // 
            // OtomatProje
            // 
            this.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1045, 464);
            this.Controls.Add(this.lblNot2);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.btnOtomatYavaslat);
            this.Controls.Add(this.btnOtomatHizlandir);
            this.Controls.Add(this.listBulunanlar);
            this.Controls.Add(this.lblAranan);
            this.Controls.Add(this.lblOkunanDeger);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.txtDegerAra);
            this.Controls.Add(this.Okİsareti);
            this.Controls.Add(this.btnTuringOlustur);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.btnTextSayisi);
            this.Controls.Add(this.txtTextSayisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OtomatProje";
            this.Text = "OtomatProje";
            ((System.ComponentModel.ISupportInitialize)(this.txtTextSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Okİsareti.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDegerAra.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTextSayisi;
        private DevExpress.XtraEditors.SimpleButton btnTextSayisi;
        private DevExpress.XtraEditors.SimpleButton btnSıfırla;
        private DevExpress.XtraEditors.SimpleButton btnTuringOlustur;
        private DevExpress.XtraEditors.PictureEdit Okİsareti;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.TextEdit txtDegerAra;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private System.Windows.Forms.Label lblOkunanDeger;
        private System.Windows.Forms.Label lblAranan;
        private System.Windows.Forms.ListBox listBulunanlar;
        private DevExpress.XtraEditors.SimpleButton btnOtomatHizlandir;
        private DevExpress.XtraEditors.SimpleButton btnOtomatYavaslat;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Label lblNot2;
    }
}