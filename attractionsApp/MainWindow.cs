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
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using MySqlX.XDevAPI.Relational;
using System.Xml.Linq;

namespace attractionsApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            filters.Add(museum);
            filters.Add(monument);
            filters.Add(chruch);
            filters.Add(park);
            filters.Add(nature);
            filters.Add(mall);

            InitializeComponent();
            GetInfoForAddAttraction();


        }

        Filter museum = new Filter("museum","музей", 0);
        Filter monument = new Filter("monument", "музей", 0);
        Filter chruch = new Filter("chruch", "музей", 0);
        Filter park = new Filter("park", "музей", 0);
        Filter nature = new Filter("nature", "музей", 0);
        Filter mall = new Filter("mall", "музей", 0);
        List<Filter> filters = new List<Filter>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        public void GetInfoForAddAttraction()
        {
            DBcon db = new DBcon();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM attractions WHERE removed = 0", db.getConnection()); // sql комманда
            MySqlDataReader reader = command.ExecuteReader();
            MySqlDataReader s;
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

        public void AddAttractionPanel( int id, string name, string path)
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
            pictureBoxFavorites.Image = GetImage(id);
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
        private Bitmap GetImage(int id_attraction)
        {
            string path = $"..\\..\\Resources\\account.txt";
            // асинхронное чтение
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM favorites WHERE id_attraction = @uA AND id_user = @uI AND removed = @re", db.getConnection());
            //MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.getConnection());
            command.Parameters.Add("@uA", MySqlDbType.Int32).Value = id_attraction;
            command.Parameters.Add("@uI", MySqlDbType.Int32).Value = id_user;
            command.Parameters.Add("@re", MySqlDbType.Int32).Value = 0;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.closeConnection();
            if (table.Rows.Count > 0)
            {
                return Properties.Resources.red;
            }
            else
            {
                return Properties.Resources.black;
            }

        }
        private void linkLblAddNewAttraction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewAttraction addNewAttraction = new AddNewAttraction();
            addNewAttraction.Show();
        }

        private void linkLblMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel lbl = (LinkLabel)sender;
            string[] Text = lbl.Name.ToString().Split(' ');
            DetailedInformation detailedInformation = new DetailedInformation(int.Parse(Text[Text.Length - 1]));
            detailedInformation.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

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
            MySqlCommand command = new MySqlCommand("SELECT * FROM favorites WHERE id_attraction = @uA AND id_user = @uI", db.getConnection());
            //MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.getConnection());
            command.Parameters.Add("@uA", MySqlDbType.Int32).Value = id_attraction;
            command.Parameters.Add("@uI", MySqlDbType.Int32).Value = id_user;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            MySqlDataReader readerr = command.ExecuteReader();

            byte removed;

            if (table.Rows.Count > 0)
            {
                readerr.Read();
                removed = readerr.GetByte(3);
                int id = readerr.GetInt32(0);
                if (removed == 0)
                {
                    db.closeConnection();
                    db.openConnection();
                    command = new MySqlCommand("UPDATE `attractions_db`.`favorites` SET `removed` = '1' WHERE (`id` = @i)", db.getConnection());
                    command.Parameters.Add("@i", MySqlDbType.Int32).Value = id;
                    if (command.ExecuteNonQuery() == 1)
                    {
                        foreach (PictureBox picture in pictureBoxes)
                        {
                            string[] idSt2 = picture.Name.Split(' ');
                            int id_attraction2 = int.Parse(idSt2[idSt2.Length - 1]);
                            if (id_attraction2 == id_attraction)
                            {
                                picture.Image = Properties.Resources.black;
                            }
                        }
                    }


                }
                else
                {
                    db.closeConnection();
                    db.openConnection();
                    command = new MySqlCommand("UPDATE `attractions_db`.`favorites` SET `removed` = '0' WHERE (`id` = @i)", db.getConnection());
                    command.Parameters.Add("@i", MySqlDbType.Int32).Value = id;
                    if (command.ExecuteNonQuery() == 1)
                    {
                        foreach (PictureBox picture in pictureBoxes)
                        {
                            string[] idSt2 = picture.Name.Split(' ');
                            int id_attraction2 = int.Parse(idSt2[idSt2.Length - 1]);
                            if (id_attraction2 == id_attraction)
                            {
                                picture.Image = Properties.Resources.red;
                            }
                        }
                    }

                }
            }
            else
            {
                db.closeConnection();
                db.openConnection();
                command = new MySqlCommand("INSERT INTO `attractions_db`.`favorites` (`id_user`, `id_attraction`, `removed`) VALUES (@uI, @uA, @re)", db.getConnection());
                command.Parameters.Add("@uI", MySqlDbType.Int32).Value = id_user;
                command.Parameters.Add("@uA", MySqlDbType.Int32).Value = id_attraction;
                command.Parameters.Add("@re", MySqlDbType.Int16).Value = 0;
                if (command.ExecuteNonQuery() == 1)
                {
                    foreach (PictureBox picture in pictureBoxes)
                    {
                        string[] idSt2 = picture.Name.Split(' ');
                        int id_attraction2 = int.Parse(idSt2[idSt2.Length - 1]);
                        if (id_attraction2 == id_attraction)
                        {
                            picture.Image = Properties.Resources.red;
                            db.closeConnection();
                            return;
                        }
                    }
                }
            }
            adapter.SelectCommand = command;
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            flowLayoutPanel1.Controls.Clear();
            GetInfoForAddAttraction();
        }

        private void linkLblWantToVisit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLblFavorites_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Favorites favorites = new Favorites();
            favorites.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            GetInfoForAddAttraction();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                string s = "";
                for (int x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
                {
                    s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";
                }
                if (checkedListBox1.CheckedIndices.Contains(0))
                    museum.checked_ = 1;
                else
                    museum.checked_ = 0;
                if (checkedListBox1.CheckedIndices.Contains(1))
                    monument.checked_ = 1;
                else
                    monument.checked_ = 0;
                if (checkedListBox1.CheckedIndices.Contains(2))
                    chruch.checked_ = 1;
                else
                    chruch.checked_ = 0;
                if (checkedListBox1.CheckedIndices.Contains(3))
                    park.checked_ = 1;
                else
                    park.checked_ = 0;
                if (checkedListBox1.CheckedIndices.Contains(4))
                    museum.checked_ = 1;
                else
                    museum.checked_ = 0;
                if (checkedListBox1.CheckedIndices.Contains(5))
                    museum.checked_ = 1;
                else
                    museum.checked_ = 0; 
            }
        }

        private void btnGetFiler_Click(object sender, EventArgs e)
        {
            foreach (Filter filter in filters)
            {
                
            }
            DBcon db = new DBcon();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM attractions WHERE removed = 0", db.getConnection()); // sql комманда
            MySqlDataReader reader = command.ExecuteReader();
            MySqlDataReader s;
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
    }
}
