namespace MarketDatabase
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnSube = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnCalisan = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.Location = new System.Drawing.Point(46, 69);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(130, 108);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "Müşteri Yönetim Paneli";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnSube
            // 
            this.btnSube.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSube.Location = new System.Drawing.Point(318, 69);
            this.btnSube.Name = "btnSube";
            this.btnSube.Size = new System.Drawing.Size(130, 108);
            this.btnSube.TabIndex = 0;
            this.btnSube.Text = "Şube Yönetim Paneli";
            this.btnSube.UseVisualStyleBackColor = true;
            this.btnSube.Click += new System.EventHandler(this.btnSube_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrun.Location = new System.Drawing.Point(454, 69);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(130, 108);
            this.btnUrun.TabIndex = 0;
            this.btnUrun.Text = "Ürün Yönetim Paneli";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnCalisan
            // 
            this.btnCalisan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisan.Location = new System.Drawing.Point(182, 69);
            this.btnCalisan.Name = "btnCalisan";
            this.btnCalisan.Size = new System.Drawing.Size(130, 108);
            this.btnCalisan.TabIndex = 0;
            this.btnCalisan.Text = "Çalışan Yönetim Paneli";
            this.btnCalisan.UseVisualStyleBackColor = true;
            this.btnCalisan.Click += new System.EventHandler(this.btnCalisan_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(591, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 30);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 293);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.btnCalisan);
            this.Controls.Add(this.btnSube);
            this.Controls.Add(this.btnMusteri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserStart_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserStart_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserStart_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnSube;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnCalisan;
        private System.Windows.Forms.Button btnKapat;
    }
}