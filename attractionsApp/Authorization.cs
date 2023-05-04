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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // функция для авторизации 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string textUser = textBoxUser.Text;
            string textPassword = textBoxPassword.Text;


            DBcon db = new DBcon();
            db.openConnection();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE user = @uL AND password = @uP", db.getConnection());
            //MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = textPassword;

            MySqlDataReader reader = command.ExecuteReader();
            

            if (reader.Read())
            {
                Hide();

                string path = $"..\\..\\Resources\\account.txt";
                string text = $"{reader["id"].ToString()};{reader["user"].ToString()};{reader["password"].ToString()}";

                // полная перезапись файла 
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.WriteLine(text);
                }

                MainWindow form1 = new MainWindow();
                form1.Show();
                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Ошибка: Неверный логин или пароль");
                db.closeConnection();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
