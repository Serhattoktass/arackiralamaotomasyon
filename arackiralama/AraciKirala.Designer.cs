namespace arackiralama
{
    partial class AraciKirala
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textGuvenlik = new System.Windows.Forms.TextBox();
            this.textKartAit = new System.Windows.Forms.TextBox();
            this.textKartNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(117, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart Numarası :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(136, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kart Sahibi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(76, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Son Geçerlilik Süresi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(118, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Güvenlik Kodu :";
            // 
            // textGuvenlik
            // 
            this.textGuvenlik.Location = new System.Drawing.Point(245, 290);
            this.textGuvenlik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textGuvenlik.MaxLength = 3;
            this.textGuvenlik.Name = "textGuvenlik";
            this.textGuvenlik.Size = new System.Drawing.Size(166, 20);
            this.textGuvenlik.TabIndex = 6;
            // 
            // textKartAit
            // 
            this.textKartAit.Location = new System.Drawing.Point(245, 219);
            this.textKartAit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textKartAit.MaxLength = 30;
            this.textKartAit.Name = "textKartAit";
            this.textKartAit.Size = new System.Drawing.Size(166, 20);
            this.textKartAit.TabIndex = 8;
            // 
            // textKartNo
            // 
            this.textKartNo.Location = new System.Drawing.Point(245, 190);
            this.textKartNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textKartNo.MaxLength = 16;
            this.textKartNo.Name = "textKartNo";
            this.textKartNo.Size = new System.Drawing.Size(166, 20);
            this.textKartNo.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 252);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 6, 6, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(76, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 1, 0, 0, 0, 0);
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(263, 332);
            this.btnOdeme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(132, 49);
            this.btnOdeme.TabIndex = 11;
            this.btnOdeme.Text = "Ödeme gerçekleştir";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::arackiralama.Properties.Resources.kredi_karti_odeme;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(184, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 68);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AraciKirala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textKartNo);
            this.Controls.Add(this.textKartAit);
            this.Controls.Add(this.textGuvenlik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AraciKirala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AraciKirala";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AraciKirala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textGuvenlik;
        private System.Windows.Forms.TextBox textKartAit;
        private System.Windows.Forms.TextBox textKartNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button button1;
    }
}