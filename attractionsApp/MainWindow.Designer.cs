namespace attractionsApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxFavorites = new System.Windows.Forms.PictureBox();
            this.linkLblMoreInfo = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.linkLblAddNewAttraction = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetFiler = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLblFavorites = new System.Windows.Forms.LinkLabel();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.linkLblRecommended = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavorites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(227, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(495, 366);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.pictureBoxFavorites);
            this.panel.Controls.Add(this.linkLblMoreInfo);
            this.panel.Controls.Add(this.lblName);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(215, 175);
            this.panel.TabIndex = 3;
            // 
            // pictureBoxFavorites
            // 
            this.pictureBoxFavorites.Location = new System.Drawing.Point(186, 143);
            this.pictureBoxFavorites.Name = "pictureBoxFavorites";
            this.pictureBoxFavorites.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxFavorites.TabIndex = 3;
            this.pictureBoxFavorites.TabStop = false;
            this.pictureBoxFavorites.Click += new System.EventHandler(this.pictureBoxFavorites_Click);
            // 
            // linkLblMoreInfo
            // 
            this.linkLblMoreInfo.AutoSize = true;
            this.linkLblMoreInfo.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLblMoreInfo.Location = new System.Drawing.Point(6, 156);
            this.linkLblMoreInfo.Name = "linkLblMoreInfo";
            this.linkLblMoreInfo.Size = new System.Drawing.Size(55, 13);
            this.linkLblMoreInfo.TabIndex = 2;
            this.linkLblMoreInfo.TabStop = true;
            this.linkLblMoreInfo.Text = "linkLabel1";
            this.linkLblMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblMoreInfo_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(215, 140);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // linkLblAddNewAttraction
            // 
            this.linkLblAddNewAttraction.AutoSize = true;
            this.linkLblAddNewAttraction.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLblAddNewAttraction.Location = new System.Drawing.Point(8, 312);
            this.linkLblAddNewAttraction.Name = "linkLblAddNewAttraction";
            this.linkLblAddNewAttraction.Size = new System.Drawing.Size(130, 13);
            this.linkLblAddNewAttraction.TabIndex = 2;
            this.linkLblAddNewAttraction.TabStop = true;
            this.linkLblAddNewAttraction.Text = "Добавить свой элемент";
            this.linkLblAddNewAttraction.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblAddNewAttraction_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.btnGetFiler);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 68);
            this.panel1.TabIndex = 4;
            // 
            // btnGetFiler
            // 
            this.btnGetFiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFiler.Location = new System.Drawing.Point(669, 28);
            this.btnGetFiler.Name = "btnGetFiler";
            this.btnGetFiler.Size = new System.Drawing.Size(34, 23);
            this.btnGetFiler.TabIndex = 12;
            this.btnGetFiler.Text = "поиск";
            this.btnGetFiler.UseVisualStyleBackColor = true;
            this.btnGetFiler.Click += new System.EventHandler(this.btnGetFiler_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(489, 30);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(174, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::attractionsApp.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFilter.Location = new System.Drawing.Point(12, 84);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(55, 13);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Фильтры";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "музей",
            "памятник",
            "церковь",
            "парк",
            "природа",
            "торговый центр"});
            this.checkedListBox1.Location = new System.Drawing.Point(11, 100);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(177, 90);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.Click += new System.EventHandler(this.checkedListBox1_Click);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCity.Location = new System.Drawing.Point(12, 201);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Город";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Москва",
            "Санкт-Петербург",
            "Новосибирск",
            "Екатеринбург",
            "Казань"});
            this.comboBox1.Location = new System.Drawing.Point(11, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // linkLblFavorites
            // 
            this.linkLblFavorites.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLblFavorites.AutoSize = true;
            this.linkLblFavorites.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLblFavorites.Location = new System.Drawing.Point(9, 288);
            this.linkLblFavorites.Name = "linkLblFavorites";
            this.linkLblFavorites.Size = new System.Drawing.Size(63, 13);
            this.linkLblFavorites.TabIndex = 8;
            this.linkLblFavorites.TabStop = true;
            this.linkLblFavorites.Text = "Избранное";
            this.linkLblFavorites.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblFavorites_LinkClicked);
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Image = global::attractionsApp.Properties.Resources._88016;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(193, 74);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(32, 33);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpdate.TabIndex = 11;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.pictureBoxUpdate_Click);
            // 
            // linkLblRecommended
            // 
            this.linkLblRecommended.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLblRecommended.AutoSize = true;
            this.linkLblRecommended.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLblRecommended.Location = new System.Drawing.Point(9, 261);
            this.linkLblRecommended.Name = "linkLblRecommended";
            this.linkLblRecommended.Size = new System.Drawing.Size(102, 13);
            this.linkLblRecommended.TabIndex = 12;
            this.linkLblRecommended.TabStop = true;
            this.linkLblRecommended.Text = "Рекомендованные";
            this.linkLblRecommended.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.linkLblRecommended);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.linkLblFavorites);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.linkLblAddNewAttraction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavorites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLblAddNewAttraction;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxFavorites;
        private System.Windows.Forms.LinkLabel linkLblMoreInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel linkLblFavorites;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.Button btnGetFiler;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.LinkLabel linkLblRecommended;
    }
}

