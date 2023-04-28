using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace attractionsApp
{
    public partial class AddNewAttraction : Form
    {
        private string path;
        public AddNewAttraction()
        {
            InitializeComponent();
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    path = dlg.FileName;
                    pictureBox.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // INSERT INTO `attractions_db`.`attractions` (``name`, `image`, `museum`, `monument`, `church`, `park`, `nature`, `mall`) VALUES ('2', '3', '0', '0', '0', '0', '0', '0');
            if (path == null)
            {
                return;
            }
            if (textBox1.Text == null)
            {
                return;
            }
            if (checkedListBoxFilter.SelectedIndices == null)
            {
                return;
            }

            // длинна фильтра
            int len = 6;

            int[] select = new int[len];
            foreach (int i in checkedListBoxFilter.SelectedIndices)
            {
                select[i] = 1;
            }

            DBcon db = new DBcon();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            string[] spPath = path.Split('\\');
            string nameFile = spPath[spPath.Length - 1];
            MySqlCommand command = new MySqlCommand("INSERT INTO `attractions_db`.`attractions` (`name`, `image`, `description`,  `adress`, `museum`, `monument`, `church`, `park`, `nature`, `mall`) VALUES (@aN, @aI, @aD, @aA, @aMu, @aMo, @aC, @aP, @aNa, @aMa)", db.getConnection());
            // @aN, @aI, @aMu, @aMo, @aC, @aP, @aN, @aMa
            command.Parameters.Add("@aN", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@aI", MySqlDbType.VarChar).Value = nameFile;
            command.Parameters.Add("@aD", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@aA", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@aMu", MySqlDbType.VarChar).Value = select[0];
            command.Parameters.Add("@aMo", MySqlDbType.VarChar).Value = select[1];
            command.Parameters.Add("@aC", MySqlDbType.VarChar).Value = select[2];
            command.Parameters.Add("@aP", MySqlDbType.VarChar).Value = select[3];
            command.Parameters.Add("@aNa", MySqlDbType.VarChar).Value = select[4];
            command.Parameters.Add("@aMa", MySqlDbType.VarChar).Value = select[5];

            adapter.SelectCommand = command;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");

            }
            File.Copy(path, $"..\\..\\Resources\\{nameFile}");
            db.closeConnection();



        }
    }
}
