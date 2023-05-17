namespace ElektroMobil
{
    partial class Voltacar
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voltacar));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.baslat = new System.Windows.Forms.Button();
            this.durdur = new System.Windows.Forms.Button();
            this.sifirla = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kaydet = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // baslat
            // 
            this.baslat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baslat.BackColor = System.Drawing.Color.Black;
            this.baslat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.baslat.FlatAppearance.BorderSize = 0;
            this.baslat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.baslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baslat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslat.ForeColor = System.Drawing.Color.White;
            this.baslat.Image = ((System.Drawing.Image)(resources.GetObject("baslat.Image")));
            this.baslat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.baslat.Location = new System.Drawing.Point(0, 408);
            this.baslat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(120, 60);
            this.baslat.TabIndex = 0;
            this.baslat.Text = "   Başlat";
            this.baslat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baslat.UseVisualStyleBackColor = false;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // durdur
            // 
            this.durdur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.durdur.BackColor = System.Drawing.Color.Black;
            this.durdur.FlatAppearance.BorderSize = 0;
            this.durdur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.durdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.durdur.Font = new System.Drawing.Font("Georgia", 12F);
            this.durdur.ForeColor = System.Drawing.Color.White;
            this.durdur.Image = ((System.Drawing.Image)(resources.GetObject("durdur.Image")));
            this.durdur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.durdur.Location = new System.Drawing.Point(126, 407);
            this.durdur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(120, 61);
            this.durdur.TabIndex = 1;
            this.durdur.Text = " Durdur";
            this.durdur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.durdur.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.durdur.UseVisualStyleBackColor = false;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // sifirla
            // 
            this.sifirla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifirla.BackColor = System.Drawing.Color.Black;
            this.sifirla.FlatAppearance.BorderSize = 0;
            this.sifirla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.sifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifirla.Font = new System.Drawing.Font("Georgia", 12F);
            this.sifirla.ForeColor = System.Drawing.Color.White;
            this.sifirla.Image = ((System.Drawing.Image)(resources.GetObject("sifirla.Image")));
            this.sifirla.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sifirla.Location = new System.Drawing.Point(280, 408);
            this.sifirla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(120, 60);
            this.sifirla.TabIndex = 2;
            this.sifirla.Text = "Sıfırla";
            this.sifirla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sifirla.UseVisualStyleBackColor = false;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(0, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(785, 198);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(572, 19);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(480, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Baud Rate:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // kaydet
            // 
            this.kaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kaydet.Image = ((System.Drawing.Image)(resources.GetObject("kaydet.Image")));
            this.kaydet.Location = new System.Drawing.Point(421, 413);
            this.kaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(45, 45);
            this.kaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaydet.TabIndex = 1;
            this.kaydet.TabStop = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(685, 413);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.Location = new System.Drawing.Point(516, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(0, 484);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(160, 180);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(156, 484);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(160, 180);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(315, 484);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(160, 180);
            this.textBox5.TabIndex = 17;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(468, 484);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(160, 180);
            this.textBox6.TabIndex = 18;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(624, 484);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(160, 180);
            this.textBox7.TabIndex = 19;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.BackColor = System.Drawing.Color.LightGray;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox8.Location = new System.Drawing.Point(0, 465);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(784, 19);
            this.textBox8.TabIndex = 20;
            this.textBox8.Text = "                Tarih                              Hız(Kmh)                      " +
    " Sıcaklık(T)                    Gerilim(V)                   Kalan Enerji(Wh)";
            // 
            // Voltacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 666);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.baslat);
            this.Controls.Add(this.sifirla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Voltacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volta Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Button sifirla;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox kaydet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
}

