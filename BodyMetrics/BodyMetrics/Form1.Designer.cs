namespace BodyMetrics
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.boy = new System.Windows.Forms.TextBox();
            this.kilo = new System.Windows.Forms.TextBox();
            this.yas = new System.Windows.Forms.TextBox();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.liste = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Boy(cm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(61, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kilo(kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(95, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(56, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(157, 56);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(170, 22);
            this.ad.TabIndex = 6;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(157, 94);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(170, 22);
            this.soyad.TabIndex = 7;
            // 
            // boy
            // 
            this.boy.Location = new System.Drawing.Point(157, 127);
            this.boy.Name = "boy";
            this.boy.Size = new System.Drawing.Size(170, 22);
            this.boy.TabIndex = 8;
            // 
            // kilo
            // 
            this.kilo.Location = new System.Drawing.Point(157, 166);
            this.kilo.Name = "kilo";
            this.kilo.Size = new System.Drawing.Size(170, 22);
            this.kilo.TabIndex = 9;
            // 
            // yas
            // 
            this.yas.Location = new System.Drawing.Point(157, 209);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(170, 22);
            this.yas.TabIndex = 10;
            // 
            // cinsiyet
            // 
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyet.Location = new System.Drawing.Point(157, 245);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(170, 24);
            this.cinsiyet.TabIndex = 11;
            // 
            // liste
            // 
            this.liste.BackColor = System.Drawing.SystemColors.Info;
            this.liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.liste.FormattingEnabled = true;
            this.liste.ItemHeight = 22;
            this.liste.Location = new System.Drawing.Point(345, 56);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(448, 202);
            this.liste.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(79, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.kilo);
            this.Controls.Add(this.boy);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox boy;
        private System.Windows.Forms.TextBox kilo;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.ComboBox cinsiyet;
        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.Button button1;
    }
}

