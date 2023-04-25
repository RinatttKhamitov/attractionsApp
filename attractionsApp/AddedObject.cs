using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attractionsApp
{
    public partial class AddedObject : Form
    {
        public AddedObject()
        {
            InitializeComponent();
            GetInfoForAddAttraction();
        }
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        public void GetInfoForAddAttraction()
        {
            int id_user;
            using (StreamReader readerr = new StreamReader($"..\\..\\Resources\\account.txt"))
            {
                string text = readerr.ReadLine().Split(';')[0];
                id_user = int.Parse(text);
            }

            // асинхронное чтение
            DBcon db = new DBcon();
            db.openConnection();

            string query = $"SELECT * FROM attractions WHERE whoAdded = {id_user} and removed = 0";
            MySqlCommand command = new MySqlCommand(query, db.getConnection()); // sql комманда
            MySqlDataReader reader = command.ExecuteReader();
            // путь к файлу
            //string path = $"..\\..\\Resources\\{(string)reader["image"]}";


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
            pictureBox.Image = System.Drawing.Image.FromFile(path);

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
            linkLblMoreInfo.Name = $"linkLblMoreInfo {id}";
            linkLblMoreInfo.Size = new Size(55, 13);
            linkLblMoreInfo.TabIndex = 2;
            linkLblMoreInfo.TabStop = true;
            linkLblMoreInfo.Text = "Подробная информация";
            linkLblMoreInfo.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLblMoreInfo_LinkClicked);

            // создание элемента изображение/кнопка добавть в избранное
            PictureBox pictureBoxFavorites = new PictureBox();
            pictureBoxFavorites.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFavorites.Location = new Point(186, 143);
            pictureBoxFavorites.Name = $"pictureBoxFavorites {id}";
            pictureBoxFavorites.Size = new Size(26, 26);
            pictureBoxFavorites.TabIndex = 3;
            pictureBoxFavorites.TabStop = false;
            pictureBoxFavorites.Image = Properties.Resources.delete;
            pictureBoxFavorites.Click += new EventHandler(pictureBoxFavorites_Click);
            pictureBoxes.Add(pictureBoxFavorites);

            // lblId.Visible = false;

            // создание панели для элементов
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
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
        
        private void linkLblMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] Text = sender.ToString().Split(' ');
            DetailedInformation detailedInformation = new DetailedInformation(int.Parse(Text[Text.Length - 1]));
            detailedInformation.Show();
        }

        private void pictureBoxFavorites_Click(object sender, EventArgs e)
        {
            
            PictureBox pictureBox = (PictureBox)sender;
            string[] idSt = pictureBox.Name.Split(' ');
            int id_attraction = int.Parse(idSt[idSt.Length - 1]);

            string path = $"..\\..\\Resources\\account.txt";
            int id_user;
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadLine().Split(';')[0];
                id_user = int.Parse(text);
            }
            DBcon db = new DBcon();
            db.openConnection();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE `attractions_db`.`attractions` SET `removed` = '1' WHERE (`id` = @uA);", db.getConnection());
            //MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.getConnection());
            command.Parameters.Add("@uA", MySqlDbType.Int32).Value = id_attraction;
            adapter.SelectCommand = command;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(id_attraction.ToString());
            }
            db.closeConnection();
        }
    }
}
