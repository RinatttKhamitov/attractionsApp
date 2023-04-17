using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;

namespace attractionsApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            GetInfoForAddAttraction();

        }

        public void GetInfoForAddAttraction()
        {
            DBcon db = new DBcon();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM attractions", db.getConnection()); // sql комманда
            MySqlDataReader reader = command.ExecuteReader();
            MySqlDataReader s;
            // путь к файлу
            //string path = $"..\\..\\Resources\\{(string)reader["image"]}";


            int i = 3;
            while (reader.Read())
            {
                // получаем значения полей текущей строки
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string image = reader.GetString(2);
                string path = $"..\\..\\Resources\\{image}";
                AddAttractionPanel(id, name, path);

            }


            db.closeConnection();
        }

        public void AddAttractionPanel(int id, string name, string path)
        {

            // создание элемента изображение
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(215, 140);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Image = Image.FromFile(path);

            // создание элемента название объекта
            Label lblName = new Label();
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 143);
            lblName.Name = "lblName";
            lblName.Size = new Size(35, 13);
            lblName.TabIndex = 1;
            lblName.Text = name;

            // создание элемента ссылка на подробную информацию
            LinkLabel linkLblMoreInfo = new LinkLabel();
            linkLblMoreInfo.ActiveLinkColor = Color.Red;
            linkLblMoreInfo.AutoSize = true;
            linkLblMoreInfo.LinkColor = Color.DarkRed;
            linkLblMoreInfo.Location = new Point(6, 156);
            linkLblMoreInfo.Name = "linkLblMoreInfo";
            linkLblMoreInfo.Size = new Size(55, 13);
            linkLblMoreInfo.TabIndex = 2;
            linkLblMoreInfo.TabStop = true;
            linkLblMoreInfo.Text = $"Подробная информация {id}";
            linkLblMoreInfo.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLblMoreInfo_LinkClicked);

            // создание элемента изображение/кнопка добавть в избранное
            PictureBox pictureBoxFavorites = new PictureBox();
            pictureBoxFavorites.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFavorites.Location = new Point(186, 143);
            pictureBoxFavorites.Name = "pictureBoxFavorites";
            pictureBoxFavorites.Size = new Size(26, 26);
            pictureBoxFavorites.TabIndex = 3;
            pictureBoxFavorites.TabStop = false;

            // создание элементы id 
            Label lblId = new Label();
            lblId.AutoSize = true;
            lblId.Location = new Point(131, 156);
            lblId.Name = "lblId";
            lblId.Size = new Size(13, 13);
            lblId.TabIndex = 4;
            lblId.Text = id.ToString();
            // lblId.Visible = false;

            // создание панели для элементов
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(lblId);
            panel.Controls.Add(pictureBoxFavorites);
            panel.Controls.Add(linkLblMoreInfo);
            panel.Controls.Add(lblName);
            panel.Controls.Add(pictureBox);
            panel.Location = new Point(6, 97);
            panel.Name = "panel";
            panel.Size = new Size(215, 175);
            panel.TabIndex = 3;

            flowLayoutPanel1.Controls.Add(panel);
        }

        private void linkLblAddNewAttraction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewAttraction addNewAttraction = new AddNewAttraction();
            addNewAttraction.Show();
        }

        private void linkLblMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] Text = sender.ToString().Split( ' ' );
            DetailedInformation detailedInformation = new DetailedInformation(int.Parse(Text[Text.Length - 1]));
            detailedInformation.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
