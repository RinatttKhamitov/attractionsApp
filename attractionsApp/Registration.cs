
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attractionsApp
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string textUser = textBoxUser.Text;
            string textPassword = textBoxPassword.Text;
            string textMail = textBoxMail.Text;

            DBcon db = new DBcon();
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `attractions_db`.`users` (`user`, `password`, `mail`) VALUES (@uL, @uP, @uM);", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = textPassword;
            command.Parameters.Add("@uM", MySqlDbType.VarChar).Value = textMail;
            adapter.SelectCommand = command;


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");

            }
            db.closeConnection();
        }
    }
}
