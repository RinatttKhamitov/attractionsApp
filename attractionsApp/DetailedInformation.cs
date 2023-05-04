using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attractionsApp
{
    public partial class DetailedInformation : Form
    {
        public DetailedInformation(int id)
        {
            InitializeComponent();
            DBcon db = new DBcon();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM attractions WHERE id = @uI", db.getConnection()); // sql комманда
            command.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
            MySqlDataReader reader = command.ExecuteReader();
            MySqlDataReader s;
            // путь к файлу
            //string path = $"..\\..\\Resources\\{(string)reader["image"]}";

            string name = "";
            string path = "";
            string description = "";
            string addres = "";
            if (reader.Read())
            {
                // получаем значения полей текущей строки
                name = reader.GetString(1);
                path = $"..\\..\\Resources\\{reader.GetString(2)}";
                description = reader.GetString(3);
                addres = reader.GetString(4);

            }
            textBoxName.Text = name;
            pictureBox.Image = Image.FromFile(path);
            textBoxKrOp.Text = description;
            textBoxAdress.Text = addres;


        }

        private void DetailedInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
