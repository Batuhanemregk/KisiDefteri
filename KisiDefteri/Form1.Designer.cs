namespace KisiDefteri
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnEkle = new Button();
            lstKisiler = new ListBox();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnYukari = new Button();
            btnAsagi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 35);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(16, 61);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(137, 61);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(261, 60);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstKisiler
            // 
            lstKisiler.DisplayMember = "TamAd";
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 15;
            lstKisiler.Location = new Point(16, 90);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(320, 259);
            lstKisiler.TabIndex = 3;
            lstKisiler.KeyDown += lstKisiler_KeyDown;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(12, 355);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(75, 23);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(93, 355);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYukari
            // 
            btnYukari.BackgroundImage = (Image)resources.GetObject("btnYukari.BackgroundImage");
            btnYukari.BackgroundImageLayout = ImageLayout.Zoom;
            btnYukari.Location = new Point(342, 171);
            btnYukari.Name = "btnYukari";
            btnYukari.Size = new Size(32, 32);
            btnYukari.TabIndex = 6;
            btnYukari.UseVisualStyleBackColor = true;
            btnYukari.Click += btnYukari_Click;
            // 
            // btnAsagi
            // 
            btnAsagi.BackgroundImage = (Image)resources.GetObject("btnAsagi.BackgroundImage");
            btnAsagi.BackgroundImageLayout = ImageLayout.Zoom;
            btnAsagi.Location = new Point(342, 209);
            btnAsagi.Name = "btnAsagi";
            btnAsagi.Size = new Size(32, 32);
            btnAsagi.TabIndex = 7;
            btnAsagi.UseVisualStyleBackColor = true;
            btnAsagi.Click += btnAsagi_Click;
            // 
            // Form1
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 393);
            Controls.Add(btnAsagi);
            Controls.Add(btnYukari);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(lstKisiler);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kişi Defteri";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnEkle;
        private ListBox lstKisiler;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnYukari;
        private Button btnAsagi;
    }
}