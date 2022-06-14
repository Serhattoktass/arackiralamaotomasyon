namespace arackiralama
{
    partial class userMenu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.plakaClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subeClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markaClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yakitClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vitesClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ucretClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vitesBox = new System.Windows.Forms.ComboBox();
            this.vitesLbl = new System.Windows.Forms.Label();
            this.yakitBox = new System.Windows.Forms.ComboBox();
            this.yakitbl = new System.Windows.Forms.Label();
            this.ucretLbl = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.markaBox = new System.Windows.Forms.ComboBox();
            this.modelLbl = new System.Windows.Forms.Label();
            this.markaLbl = new System.Windows.Forms.Label();
            this.subeLbl = new System.Windows.Forms.Label();
            this.plakaTxt = new System.Windows.Forms.TextBox();
            this.plakaLbl = new System.Windows.Forms.Label();
            this.aracekleBtn = new System.Windows.Forms.Button();
            this.subeBox = new System.Windows.Forms.ComboBox();
            this.geriBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.DateBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblgunsayisi = new System.Windows.Forms.Label();
            this.ucretBox = new System.Windows.Forms.TextBox();
            this.txttoplam = new System.Windows.Forms.TextBox();
            this.aracresmi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aracresmi)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.plakaClm,
            this.subeClm,
            this.markaClm,
            this.modelClm,
            this.yakitClm,
            this.vitesClm,
            this.ucretClm,
            this.idClm});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 24);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1007, 253);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // plakaClm
            // 
            this.plakaClm.Text = "Plaka";
            this.plakaClm.Width = 172;
            // 
            // subeClm
            // 
            this.subeClm.Text = "Şube";
            this.subeClm.Width = 110;
            // 
            // markaClm
            // 
            this.markaClm.Text = "Marka";
            this.markaClm.Width = 120;
            // 
            // modelClm
            // 
            this.modelClm.Text = "Model";
            this.modelClm.Width = 120;
            // 
            // yakitClm
            // 
            this.yakitClm.Text = "Yakıt Türü";
            this.yakitClm.Width = 110;
            // 
            // vitesClm
            // 
            this.vitesClm.Text = "Vites";
            this.vitesClm.Width = 172;
            // 
            // ucretClm
            // 
            this.ucretClm.Text = "Ücret";
            this.ucretClm.Width = 110;
            // 
            // idClm
            // 
            this.idClm.Text = "";
            this.idClm.Width = 0;
            // 
            // vitesBox
            // 
            this.vitesBox.Enabled = false;
            this.vitesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vitesBox.FormattingEnabled = true;
            this.vitesBox.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik",
            "Yarı Otomatik"});
            this.vitesBox.Location = new System.Drawing.Point(135, 390);
            this.vitesBox.Name = "vitesBox";
            this.vitesBox.Size = new System.Drawing.Size(120, 25);
            this.vitesBox.TabIndex = 34;
            // 
            // vitesLbl
            // 
            this.vitesLbl.AutoSize = true;
            this.vitesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vitesLbl.Location = new System.Drawing.Point(89, 392);
            this.vitesLbl.Name = "vitesLbl";
            this.vitesLbl.Size = new System.Drawing.Size(51, 17);
            this.vitesLbl.TabIndex = 33;
            this.vitesLbl.Text = "Vites : ";
            // 
            // yakitBox
            // 
            this.yakitBox.Enabled = false;
            this.yakitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yakitBox.FormattingEnabled = true;
            this.yakitBox.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin&LPG",
            "Hybrid",
            "Elektrik"});
            this.yakitBox.Location = new System.Drawing.Point(134, 328);
            this.yakitBox.Name = "yakitBox";
            this.yakitBox.Size = new System.Drawing.Size(121, 25);
            this.yakitBox.TabIndex = 30;
            // 
            // yakitbl
            // 
            this.yakitbl.AutoSize = true;
            this.yakitbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yakitbl.Location = new System.Drawing.Point(64, 328);
            this.yakitbl.Name = "yakitbl";
            this.yakitbl.Size = new System.Drawing.Size(85, 17);
            this.yakitbl.TabIndex = 29;
            this.yakitbl.Text = "Yakıt Türü : ";
            // 
            // ucretLbl
            // 
            this.ucretLbl.AutoSize = true;
            this.ucretLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucretLbl.Location = new System.Drawing.Point(37, 457);
            this.ucretLbl.Name = "ucretLbl";
            this.ucretLbl.Size = new System.Drawing.Size(103, 17);
            this.ucretLbl.TabIndex = 28;
            this.ucretLbl.Text = "Günlük Ücret : ";
            // 
            // modelBox
            // 
            this.modelBox.Enabled = false;
            this.modelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(135, 483);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(120, 25);
            this.modelBox.TabIndex = 27;
            // 
            // markaBox
            // 
            this.markaBox.Enabled = false;
            this.markaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaBox.FormattingEnabled = true;
            this.markaBox.Items.AddRange(new object[] {
            "Hyundai",
            "Opel",
            "Renault",
            "Honda"});
            this.markaBox.Location = new System.Drawing.Point(135, 421);
            this.markaBox.Name = "markaBox";
            this.markaBox.Size = new System.Drawing.Size(120, 25);
            this.markaBox.TabIndex = 26;
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelLbl.Location = new System.Drawing.Point(76, 490);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(58, 17);
            this.modelLbl.TabIndex = 25;
            this.modelLbl.Text = "Model : ";
            // 
            // markaLbl
            // 
            this.markaLbl.AutoSize = true;
            this.markaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaLbl.Location = new System.Drawing.Point(82, 423);
            this.markaLbl.Name = "markaLbl";
            this.markaLbl.Size = new System.Drawing.Size(59, 17);
            this.markaLbl.TabIndex = 23;
            this.markaLbl.Text = "Marka : ";
            // 
            // subeLbl
            // 
            this.subeLbl.AutoSize = true;
            this.subeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeLbl.Location = new System.Drawing.Point(88, 362);
            this.subeLbl.Name = "subeLbl";
            this.subeLbl.Size = new System.Drawing.Size(53, 17);
            this.subeLbl.TabIndex = 21;
            this.subeLbl.Text = "Şube : ";
            // 
            // plakaTxt
            // 
            this.plakaTxt.Enabled = false;
            this.plakaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plakaTxt.Location = new System.Drawing.Point(134, 294);
            this.plakaTxt.Name = "plakaTxt";
            this.plakaTxt.Size = new System.Drawing.Size(121, 23);
            this.plakaTxt.TabIndex = 20;
            // 
            // plakaLbl
            // 
            this.plakaLbl.AutoSize = true;
            this.plakaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plakaLbl.Location = new System.Drawing.Point(86, 294);
            this.plakaLbl.Name = "plakaLbl";
            this.plakaLbl.Size = new System.Drawing.Size(55, 17);
            this.plakaLbl.TabIndex = 19;
            this.plakaLbl.Text = "Plaka : ";
            // 
            // aracekleBtn
            // 
            this.aracekleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracekleBtn.Location = new System.Drawing.Point(458, 437);
            this.aracekleBtn.Name = "aracekleBtn";
            this.aracekleBtn.Size = new System.Drawing.Size(173, 37);
            this.aracekleBtn.TabIndex = 18;
            this.aracekleBtn.Text = "Aracı Kirala";
            this.aracekleBtn.UseVisualStyleBackColor = true;
            this.aracekleBtn.Click += new System.EventHandler(this.aracekleBtn_Click);
            // 
            // subeBox
            // 
            this.subeBox.Enabled = false;
            this.subeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeBox.FormattingEnabled = true;
            this.subeBox.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin&LPG",
            "Hybrid",
            "Elektrik"});
            this.subeBox.Location = new System.Drawing.Point(134, 360);
            this.subeBox.Name = "subeBox";
            this.subeBox.Size = new System.Drawing.Size(121, 25);
            this.subeBox.TabIndex = 35;
            // 
            // geriBtn
            // 
            this.geriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBtn.Location = new System.Drawing.Point(298, 537);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(128, 46);
            this.geriBtn.TabIndex = 5;
            this.geriBtn.Text = "Oturumu Kapat ve Ana Menüye Dön";
            this.geriBtn.UseVisualStyleBackColor = true;
            this.geriBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(332, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Başlangıç Tarih :";
            // 
            // DateBaslangic
            // 
            this.DateBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DateBaslangic.Location = new System.Drawing.Point(449, 318);
            this.DateBaslangic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateBaslangic.MinDate = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.DateBaslangic.Name = "DateBaslangic";
            this.DateBaslangic.Size = new System.Drawing.Size(227, 23);
            this.DateBaslangic.TabIndex = 40;
            this.DateBaslangic.Value = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.DateBaslangic.ValueChanged += new System.EventHandler(this.DateBaslangic_ValueChanged);
            // 
            // DateBitis
            // 
            this.DateBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.DateBitis.Location = new System.Drawing.Point(449, 347);
            this.DateBitis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateBitis.Name = "DateBitis";
            this.DateBitis.Size = new System.Drawing.Size(227, 23);
            this.DateBitis.TabIndex = 42;
            this.DateBitis.Value = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            this.DateBitis.ValueChanged += new System.EventHandler(this.txtBitis_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(362, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Bitiş Tarih :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(395, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Toplam Tutar :";
            // 
            // lblgunsayisi
            // 
            this.lblgunsayisi.AutoSize = true;
            this.lblgunsayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgunsayisi.Location = new System.Drawing.Point(412, 372);
            this.lblgunsayisi.Name = "lblgunsayisi";
            this.lblgunsayisi.Size = new System.Drawing.Size(84, 17);
            this.lblgunsayisi.TabIndex = 47;
            this.lblgunsayisi.Text = "Gün Sayısı :";
            // 
            // ucretBox
            // 
            this.ucretBox.Enabled = false;
            this.ucretBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ucretBox.Location = new System.Drawing.Point(135, 455);
            this.ucretBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucretBox.Name = "ucretBox";
            this.ucretBox.Size = new System.Drawing.Size(120, 23);
            this.ucretBox.TabIndex = 48;
            // 
            // txttoplam
            // 
            this.txttoplam.Enabled = false;
            this.txttoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txttoplam.Location = new System.Drawing.Point(501, 392);
            this.txttoplam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttoplam.Name = "txttoplam";
            this.txttoplam.Size = new System.Drawing.Size(120, 23);
            this.txttoplam.TabIndex = 49;
            // 
            // aracresmi
            // 
            this.aracresmi.Location = new System.Drawing.Point(709, 294);
            this.aracresmi.Name = "aracresmi";
            this.aracresmi.Size = new System.Drawing.Size(328, 287);
            this.aracresmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aracresmi.TabIndex = 50;
            this.aracresmi.TabStop = false;
            // 
            // userMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 593);
            this.Controls.Add(this.aracresmi);
            this.Controls.Add(this.txttoplam);
            this.Controls.Add(this.ucretBox);
            this.Controls.Add(this.lblgunsayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateBitis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subeBox);
            this.Controls.Add(this.vitesBox);
            this.Controls.Add(this.vitesLbl);
            this.Controls.Add(this.yakitBox);
            this.Controls.Add(this.yakitbl);
            this.Controls.Add(this.ucretLbl);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.markaBox);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.markaLbl);
            this.Controls.Add(this.subeLbl);
            this.Controls.Add(this.plakaTxt);
            this.Controls.Add(this.plakaLbl);
            this.Controls.Add(this.aracekleBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.geriBtn);
            this.Name = "userMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userMenu_FormClosed);
            this.Load += new System.EventHandler(this.userMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aracresmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader plakaClm;
        private System.Windows.Forms.ColumnHeader subeClm;
        private System.Windows.Forms.ColumnHeader markaClm;
        private System.Windows.Forms.ColumnHeader modelClm;
        private System.Windows.Forms.ColumnHeader yakitClm;
        private System.Windows.Forms.ColumnHeader vitesClm;
        private System.Windows.Forms.ColumnHeader ucretClm;
        private System.Windows.Forms.ColumnHeader idClm;
        public System.Windows.Forms.ComboBox vitesBox;
        public System.Windows.Forms.Label vitesLbl;
        public System.Windows.Forms.ComboBox yakitBox;
        public System.Windows.Forms.Label yakitbl;
        public System.Windows.Forms.Label ucretLbl;
        public System.Windows.Forms.ComboBox modelBox;
        public System.Windows.Forms.ComboBox markaBox;
        public System.Windows.Forms.Label modelLbl;
        public System.Windows.Forms.Label markaLbl;
        public System.Windows.Forms.Label subeLbl;
        public System.Windows.Forms.TextBox plakaTxt;
        public System.Windows.Forms.Label plakaLbl;
        public System.Windows.Forms.Button aracekleBtn;
        public System.Windows.Forms.ComboBox subeBox;
        public System.Windows.Forms.Button geriBtn;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateBaslangic;
        private System.Windows.Forms.DateTimePicker DateBitis;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblgunsayisi;
        private System.Windows.Forms.TextBox ucretBox;
        private System.Windows.Forms.TextBox txttoplam;
        private System.Windows.Forms.PictureBox aracresmi;
    }
}