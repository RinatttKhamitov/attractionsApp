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
        private string path;
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
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    path = dlg.FileName;
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }
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

        private void btnReady_Click(object sender, EventArgs e)
        {

            if (path == null)
            {
                return;
            }

            int id_user;
            string pathh = $"..\\..\\Resources\\account.txt";
            using (StreamReader readerr = new StreamReader(pathh))
            {
                string text = readerr.ReadLine().Split(';')[0];
                id_user = int.Parse(text);
            }


            DBcon db = new DBcon();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            string[] spPath = path.Split('\\');
            string nameFile = spPath[spPath.Length - 1];
            MySqlCommand command = new MySqlCommand("UPDATE users SET `image` = @uIm WHERE `id` = @uId", db.getConnection());
            command.Parameters.Add("@uIm", MySqlDbType.VarChar).Value = nameFile;
            command.Parameters.Add("@uId", MySqlDbType.VarChar).Value = id_user;
            adapter.SelectCommand = command;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");

            }
            if (File.Exists($"..\\..\\Resources\\{nameFile}"))
            {
                return;
            }
            File.Copy(path, $"..\\..\\Resources\\{nameFile}");
            db.closeConnection();
        }
    }
}
