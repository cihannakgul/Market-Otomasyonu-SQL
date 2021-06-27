
namespace MarketDatabase
{
    partial class FormBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBranch));
            this.dgwBranch = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddAdress = new System.Windows.Forms.Label();
            this.tbxAddAdress = new System.Windows.Forms.TextBox();
            this.lblAddil = new System.Windows.Forms.Label();
            this.tbxAddil = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.tbxAddName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateAdress = new System.Windows.Forms.Label();
            this.tbxUpdateAdress = new System.Windows.Forms.TextBox();
            this.lblUpdateil = new System.Windows.Forms.Label();
            this.tbxUpdateilId = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.btnBracnhDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBranch
            // 
            this.dgwBranch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBranch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBranch.Location = new System.Drawing.Point(41, 72);
            this.dgwBranch.Margin = new System.Windows.Forms.Padding(2);
            this.dgwBranch.Name = "dgwBranch";
            this.dgwBranch.RowHeadersWidth = 51;
            this.dgwBranch.RowTemplate.Height = 24;
            this.dgwBranch.Size = new System.Drawing.Size(567, 118);
            this.dgwBranch.TabIndex = 0;
            this.dgwBranch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBranch_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(197, 233);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddAdress
            // 
            this.lblAddAdress.AutoSize = true;
            this.lblAddAdress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddAdress.Location = new System.Drawing.Point(38, 288);
            this.lblAddAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddAdress.Name = "lblAddAdress";
            this.lblAddAdress.Size = new System.Drawing.Size(37, 16);
            this.lblAddAdress.TabIndex = 13;
            this.lblAddAdress.Text = "Adres";
            // 
            // tbxAddAdress
            // 
            this.tbxAddAdress.Location = new System.Drawing.Point(88, 286);
            this.tbxAddAdress.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAddAdress.Name = "tbxAddAdress";
            this.tbxAddAdress.Size = new System.Drawing.Size(90, 20);
            this.tbxAddAdress.TabIndex = 12;
            // 
            // lblAddil
            // 
            this.lblAddil.AutoSize = true;
            this.lblAddil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddil.Location = new System.Drawing.Point(61, 262);
            this.lblAddil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddil.Name = "lblAddil";
            this.lblAddil.Size = new System.Drawing.Size(14, 17);
            this.lblAddil.TabIndex = 11;
            this.lblAddil.Text = "İl";
            // 
            // tbxAddil
            // 
            this.tbxAddil.Location = new System.Drawing.Point(88, 260);
            this.tbxAddil.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAddil.Name = "tbxAddil";
            this.tbxAddil.Size = new System.Drawing.Size(90, 20);
            this.tbxAddil.TabIndex = 10;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddName.Location = new System.Drawing.Point(48, 235);
            this.lblAddName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(27, 16);
            this.lblAddName.TabIndex = 9;
            this.lblAddName.Text = "İsim";
            // 
            // tbxAddName
            // 
            this.tbxAddName.Location = new System.Drawing.Point(88, 233);
            this.tbxAddName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAddName.Name = "tbxAddName";
            this.tbxAddName.Size = new System.Drawing.Size(90, 20);
            this.tbxAddName.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(505, 233);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 30);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateAdress
            // 
            this.lblUpdateAdress.AutoSize = true;
            this.lblUpdateAdress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateAdress.Location = new System.Drawing.Point(349, 288);
            this.lblUpdateAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateAdress.Name = "lblUpdateAdress";
            this.lblUpdateAdress.Size = new System.Drawing.Size(37, 16);
            this.lblUpdateAdress.TabIndex = 20;
            this.lblUpdateAdress.Text = "Adres";
            // 
            // tbxUpdateAdress
            // 
            this.tbxUpdateAdress.Location = new System.Drawing.Point(400, 286);
            this.tbxUpdateAdress.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUpdateAdress.Multiline = true;
            this.tbxUpdateAdress.Name = "tbxUpdateAdress";
            this.tbxUpdateAdress.Size = new System.Drawing.Size(89, 33);
            this.tbxUpdateAdress.TabIndex = 19;
            // 
            // lblUpdateil
            // 
            this.lblUpdateil.AutoSize = true;
            this.lblUpdateil.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateil.Location = new System.Drawing.Point(373, 263);
            this.lblUpdateil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateil.Name = "lblUpdateil";
            this.lblUpdateil.Size = new System.Drawing.Size(13, 16);
            this.lblUpdateil.TabIndex = 18;
            this.lblUpdateil.Text = "İl";
            // 
            // tbxUpdateilId
            // 
            this.tbxUpdateilId.Location = new System.Drawing.Point(399, 261);
            this.tbxUpdateilId.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUpdateilId.Name = "tbxUpdateilId";
            this.tbxUpdateilId.Size = new System.Drawing.Size(90, 20);
            this.tbxUpdateilId.TabIndex = 17;
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateName.Location = new System.Drawing.Point(359, 235);
            this.lblUpdateName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(27, 16);
            this.lblUpdateName.TabIndex = 16;
            this.lblUpdateName.Text = "İsim";
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(399, 233);
            this.tbxUpdateName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(90, 20);
            this.tbxUpdateName.TabIndex = 15;
            // 
            // btnBracnhDelete
            // 
            this.btnBracnhDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBracnhDelete.Location = new System.Drawing.Point(505, 276);
            this.btnBracnhDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnBracnhDelete.Name = "btnBracnhDelete";
            this.btnBracnhDelete.Size = new System.Drawing.Size(67, 30);
            this.btnBracnhDelete.TabIndex = 22;
            this.btnBracnhDelete.Text = "Sil";
            this.btnBracnhDelete.UseVisualStyleBackColor = true;
            this.btnBracnhDelete.Click += new System.EventHandler(this.btnBracnhDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShow.Location = new System.Drawing.Point(197, 274);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(67, 30);
            this.btnShow.TabIndex = 23;
            this.btnShow.Text = "Göster";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(610, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 30);
            this.btnKapat.TabIndex = 24;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FormBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnShow;
            this.ClientSize = new System.Drawing.Size(652, 445);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnBracnhDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUpdateAdress);
            this.Controls.Add(this.tbxUpdateAdress);
            this.Controls.Add(this.lblUpdateil);
            this.Controls.Add(this.tbxUpdateilId);
            this.Controls.Add(this.lblUpdateName);
            this.Controls.Add(this.tbxUpdateName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddAdress);
            this.Controls.Add(this.tbxAddAdress);
            this.Controls.Add(this.lblAddil);
            this.Controls.Add(this.tbxAddil);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.tbxAddName);
            this.Controls.Add(this.dgwBranch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBranch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBranch";
            this.Load += new System.EventHandler(this.FormBranch_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserStart_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserStart_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserStart_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBranch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBranch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddAdress;
        private System.Windows.Forms.TextBox tbxAddAdress;
        private System.Windows.Forms.Label lblAddil;
        private System.Windows.Forms.TextBox tbxAddil;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.TextBox tbxAddName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateAdress;
        private System.Windows.Forms.TextBox tbxUpdateAdress;
        private System.Windows.Forms.Label lblUpdateil;
        private System.Windows.Forms.TextBox tbxUpdateilId;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Button btnBracnhDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnKapat;
    }
}