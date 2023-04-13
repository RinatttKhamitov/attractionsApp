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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=attractions_db;password=0000;");
            connection.Open();
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

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE user = @uL AND password = @uP", db.getConnection());
            //MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = textPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("1");
            }
            else
            {
                MessageBox.Show("2");
            }
        }
    }
}
