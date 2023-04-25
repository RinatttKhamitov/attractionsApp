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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btnAddedObject_Click(object sender, EventArgs e)
        {
            AddedObject addedObject = new AddedObject();
            addedObject.Show();
        }

        private void linkLblChangeIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            DBcon db = new DBcon();
            db.openConnection();
            int id_user;
            string pathh = $"..\\..\\Resources\\account.txt";
            using (StreamReader readerr = new StreamReader(pathh))
            {
                string text = readerr.ReadLine().Split(';')[0];
                id_user = int.Parse(text);
            }

            string query = $"SELECT image FROM users WHERE id={id_user}";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                string imagePath = (string)reader["image"];
                MessageBox.Show(imagePath, id_user.ToString());
                if (imagePath == null)
                {
                    pictureBox1.Image = Properties.Resources.icon;
                    return;
                }
                string path = $"..\\..\\Resources\\{imagePath}";
                pictureBox1.Image = Image.FromFile(path);
                //Далее можно производить нужную обработку данных изображения
            }

            reader.Close();
            db.closeConnection();
            
        }
    }
}
