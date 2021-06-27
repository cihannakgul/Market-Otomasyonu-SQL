
namespace MarketDatabase
{
    partial class FormWorkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkers));
            this.dtWorkers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.RichTextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.cmbMevki = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubeID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdtName = new System.Windows.Forms.TextBox();
            this.txtUpdtMaas = new System.Windows.Forms.TextBox();
            this.cmbUpdtMevki = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtWorkers
            // 
            this.dtWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtWorkers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtWorkers.Location = new System.Drawing.Point(53, 64);
            this.dtWorkers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtWorkers.Name = "dtWorkers";
            this.dtWorkers.RowHeadersWidth = 51;
            this.dtWorkers.Size = new System.Drawing.Size(957, 207);
            this.dtWorkers.TabIndex = 0;
            this.dtWorkers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtWorkers_CellClick);
            this.dtWorkers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtWorkers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(147, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(101, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Açık Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(131, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Maaş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(116, 513);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şube ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(128, 554);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mevki:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(147, 596);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "İl ID:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(205, 305);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(184, 22);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(205, 346);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(184, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(205, 386);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(184, 67);
            this.txtAdress.TabIndex = 3;
            this.txtAdress.Text = "";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(205, 470);
            this.txtMaas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(184, 22);
            this.txtMaas.TabIndex = 2;
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(205, 593);
            this.txtIl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(184, 22);
            this.txtIl.TabIndex = 4;
            // 
            // cmbMevki
            // 
            this.cmbMevki.FormattingEnabled = true;
            this.cmbMevki.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Reyon Sorumlusu",
            "Kasiyer"});
            this.cmbMevki.Location = new System.Drawing.Point(205, 551);
            this.cmbMevki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMevki.Name = "cmbMevki";
            this.cmbMevki.Size = new System.Drawing.Size(184, 24);
            this.cmbMevki.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(241, 645);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSubeID
            // 
            this.txtSubeID.Location = new System.Drawing.Point(205, 511);
            this.txtSubeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubeID.Name = "txtSubeID";
            this.txtSubeID.Size = new System.Drawing.Size(184, 22);
            this.txtSubeID.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(592, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "İsim:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(576, 389);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Maaş:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(576, 348);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mevki";
            // 
            // txtUpdtName
            // 
            this.txtUpdtName.Location = new System.Drawing.Point(652, 305);
            this.txtUpdtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdtName.Name = "txtUpdtName";
            this.txtUpdtName.Size = new System.Drawing.Size(197, 22);
            this.txtUpdtName.TabIndex = 11;
            // 
            // txtUpdtMaas
            // 
            this.txtUpdtMaas.Location = new System.Drawing.Point(652, 388);
            this.txtUpdtMaas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdtMaas.Name = "txtUpdtMaas";
            this.txtUpdtMaas.Size = new System.Drawing.Size(197, 22);
            this.txtUpdtMaas.TabIndex = 11;
            // 
            // cmbUpdtMevki
            // 
            this.cmbUpdtMevki.FormattingEnabled = true;
            this.cmbUpdtMevki.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Reyon Sorumlusu",
            "Kasiyer"});
            this.cmbUpdtMevki.Location = new System.Drawing.Point(652, 348);
            this.cmbUpdtMevki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUpdtMevki.Name = "cmbUpdtMevki";
            this.cmbUpdtMevki.Size = new System.Drawing.Size(197, 24);
            this.cmbUpdtMevki.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(699, 439);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(699, 496);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(1011, 15);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(40, 37);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FormWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 732);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbUpdtMevki);
            this.Controls.Add(this.txtUpdtMaas);
            this.Controls.Add(this.txtUpdtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSubeID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbMevki);
            this.Controls.Add(this.txtIl);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtWorkers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWorkers";
            this.Load += new System.EventHandler(this.FormWorkers_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserStart_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserStart_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserStart_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dtWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.RichTextBox txtAdress;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.ComboBox cmbMevki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSubeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdtName;
        private System.Windows.Forms.TextBox txtUpdtMaas;
        private System.Windows.Forms.ComboBox cmbUpdtMevki;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnKapat;
    }
}