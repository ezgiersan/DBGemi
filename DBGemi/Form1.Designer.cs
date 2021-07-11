
namespace DBGemi
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
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxİletisim = new System.Windows.Forms.TextBox();
            this.textBoxÜlke = new System.Windows.Forms.TextBox();
            this.textBoxGemiAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGemiID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Location = new System.Drawing.Point(526, 149);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(113, 34);
            this.buttonGüncelle.TabIndex = 23;
            this.buttonGüncelle.Text = "GÜNCELLE";
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(526, 93);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(113, 34);
            this.buttonSil.TabIndex = 22;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(526, 47);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(113, 34);
            this.buttonEkle.TabIndex = 21;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTel.Location = new System.Drawing.Point(227, 177);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(220, 24);
            this.textBoxTel.TabIndex = 20;
            // 
            // textBoxİletisim
            // 
            this.textBoxİletisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxİletisim.Location = new System.Drawing.Point(227, 142);
            this.textBoxİletisim.Name = "textBoxİletisim";
            this.textBoxİletisim.Size = new System.Drawing.Size(220, 24);
            this.textBoxİletisim.TabIndex = 19;
            // 
            // textBoxÜlke
            // 
            this.textBoxÜlke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxÜlke.Location = new System.Drawing.Point(227, 103);
            this.textBoxÜlke.Name = "textBoxÜlke";
            this.textBoxÜlke.Size = new System.Drawing.Size(220, 24);
            this.textBoxÜlke.TabIndex = 18;
            // 
            // textBoxGemiAdi
            // 
            this.textBoxGemiAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGemiAdi.Location = new System.Drawing.Point(227, 61);
            this.textBoxGemiAdi.Name = "textBoxGemiAdi";
            this.textBoxGemiAdi.Size = new System.Drawing.Size(220, 24);
            this.textBoxGemiAdi.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 247);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "İletişim Bilgileri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ülke:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gemi Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "GemiID:";
            // 
            // textBoxGemiID
            // 
            this.textBoxGemiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGemiID.Location = new System.Drawing.Point(227, 24);
            this.textBoxGemiID.Name = "textBoxGemiID";
            this.textBoxGemiID.Size = new System.Drawing.Size(220, 24);
            this.textBoxGemiID.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 493);
            this.Controls.Add(this.textBoxGemiID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxİletisim);
            this.Controls.Add(this.textBoxÜlke);
            this.Controls.Add(this.textBoxGemiAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxİletisim;
        private System.Windows.Forms.TextBox textBoxÜlke;
        private System.Windows.Forms.TextBox textBoxGemiAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGemiID;
    }
}

