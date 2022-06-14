namespace arackiralama
{
    partial class anasayfa
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
            this.userLbl = new System.Windows.Forms.Label();
            this.pwLbl = new System.Windows.Forms.Label();
            this.kullaniciTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userLbl.Location = new System.Drawing.Point(9, 54);
            this.userLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(116, 20);
            this.userLbl.TabIndex = 0;
            this.userLbl.Text = "Kullanıcı Adı : ";
            // 
            // pwLbl
            // 
            this.pwLbl.AutoSize = true;
            this.pwLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pwLbl.Location = new System.Drawing.Point(66, 102);
            this.pwLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwLbl.Name = "pwLbl";
            this.pwLbl.Size = new System.Drawing.Size(59, 20);
            this.pwLbl.TabIndex = 1;
            this.pwLbl.Text = "Şifre : ";
            // 
            // kullaniciTxt
            // 
            this.kullaniciTxt.Location = new System.Drawing.Point(150, 54);
            this.kullaniciTxt.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciTxt.Name = "kullaniciTxt";
            this.kullaniciTxt.Size = new System.Drawing.Size(143, 22);
            this.kullaniciTxt.TabIndex = 2;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(150, 102);
            this.sifreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(143, 22);
            this.sifreTxt.TabIndex = 3;
            // 
            // LoginBtn
            // 
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginBtn.Location = new System.Drawing.Point(173, 142);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(90, 28);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Giriş";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerBtn.Location = new System.Drawing.Point(1208, 105);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(131, 31);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Yeni Üyelik";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::arackiralama.Properties.Resources.uyelikjpg;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1226, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 86);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1123, 511);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 82);
            this.button2.TabIndex = 9;
            this.button2.Text = "Araçları Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::arackiralama.Properties.Resources.AracKiralamaAnaSayfaj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1352, 623);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.kullaniciTxt);
            this.Controls.Add(this.pwLbl);
            this.Controls.Add(this.userLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.anasayfa_FormClosed);
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label pwLbl;
        private System.Windows.Forms.TextBox kullaniciTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

