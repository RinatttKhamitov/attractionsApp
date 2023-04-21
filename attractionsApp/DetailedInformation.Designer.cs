namespace attractionsApp
{
    partial class DetailedInformation
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
            this.lblImage = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelkrOp = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxKrOp = new System.Windows.Forms.TextBox();
            this.btnWantToVisit = new System.Windows.Forms.Button();
            this.btnAddFav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(123, 7);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(35, 13);
            this.lblImage.TabIndex = 0;
            this.lblImage.Text = "Фото";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::attractionsApp.Properties.Resources.caption;
            this.pictureBox.Location = new System.Drawing.Point(47, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(201, 141);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(47, 183);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(201, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(47, 167);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Название";
            // 
            // labelkrOp
            // 
            this.labelkrOp.AutoSize = true;
            this.labelkrOp.Location = new System.Drawing.Point(47, 248);
            this.labelkrOp.Name = "labelkrOp";
            this.labelkrOp.Size = new System.Drawing.Size(100, 13);
            this.labelkrOp.TabIndex = 6;
            this.labelkrOp.Text = "Краткое описание";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(47, 225);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(201, 20);
            this.textBoxAdress.TabIndex = 5;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(47, 209);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(38, 13);
            this.labelAdress.TabIndex = 8;
            this.labelAdress.Text = "Адрес";
            // 
            // textBoxKrOp
            // 
            this.textBoxKrOp.Location = new System.Drawing.Point(47, 269);
            this.textBoxKrOp.Multiline = true;
            this.textBoxKrOp.Name = "textBoxKrOp";
            this.textBoxKrOp.Size = new System.Drawing.Size(201, 91);
            this.textBoxKrOp.TabIndex = 7;
            // 
            // btnWantToVisit
            // 
            this.btnWantToVisit.Location = new System.Drawing.Point(87, 366);
            this.btnWantToVisit.Name = "btnWantToVisit";
            this.btnWantToVisit.Size = new System.Drawing.Size(117, 23);
            this.btnWantToVisit.TabIndex = 9;
            this.btnWantToVisit.Text = "Хочу посетить";
            this.btnWantToVisit.UseVisualStyleBackColor = true;
            // 
            // btnAddFav
            // 
            this.btnAddFav.Location = new System.Drawing.Point(87, 404);
            this.btnAddFav.Name = "btnAddFav";
            this.btnAddFav.Size = new System.Drawing.Size(117, 23);
            this.btnAddFav.TabIndex = 10;
            this.btnAddFav.Text = "Добавить в избранное";
            this.btnAddFav.UseVisualStyleBackColor = true;
            // 
            // DetailedInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.btnAddFav);
            this.Controls.Add(this.btnWantToVisit);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.textBoxKrOp);
            this.Controls.Add(this.labelkrOp);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblImage);
            this.Name = "DetailedInformation";
            this.Text = "DetailedInformation";
            this.Load += new System.EventHandler(this.DetailedInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelkrOp;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxKrOp;
        private System.Windows.Forms.Button btnWantToVisit;
        private System.Windows.Forms.Button btnAddFav;
    }
}