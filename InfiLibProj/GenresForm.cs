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

namespace InfiLibProj
{
    public partial class GenresForm : Form
    {
        public GenresForm()
        {
            InitializeComponent();

            LoadData("genre");
        }

        private void LoadData(String tableName)
        {
            DB db = new DB();

            string query = "SELECT * FROM `" + tableName + "`;";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            db.openConnection();

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            db.closeConnection();
            da.Dispose();

            GenresFormDataGrid.DataSource = dt;
        }

        private void GenreAddBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `genre` (`name`) VALUES (@genreName);", db.getConnection());

            command.Parameters.Add("@genreName", MySqlDbType.VarChar).Value = GenreName.Text;

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `genre` AUTO_INCREMENT=1;", db.getConnection());

            db.openConnection();

            if (GenreName.Text == "")
            {
                MessageBox.Show("Not all fields were filled!");
                db.closeConnection();
                return;
            }

            refreshIncrement.ExecuteNonQuery();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Genre was added succesfully.");
            }
            else
                MessageBox.Show("Genre was NOT added.");

            LoadData("genre");

            db.closeConnection();
        }

        private void GenreUpdateBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand commandName = new MySqlCommand("UPDATE `genre` SET `name` = @genreName WHERE id = @genreId;", db.getConnection());

            if (GenreName.Text != "")
            {
                commandName.Parameters.Add("@genreId", MySqlDbType.Int64).Value = GenreId.Text;
                commandName.Parameters.Add("@genreName", MySqlDbType.VarChar).Value = GenreName.Text;
            }

            db.openConnection();

            if (GenreName.Text != "")
            {
                if (commandName.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Genre's name passage was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Genre's name passage was NOT changed.");
                }
            }

            LoadData("genre");

            db.closeConnection();
        }

        private void GenreDeleteBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `genre` WHERE id = @genreId;", db.getConnection());

            command.Parameters.Add("@genreId", MySqlDbType.Int64).Value = GenreId.Text;

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `genre` AUTO_INCREMENT=1;", db.getConnection());

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Genre was deleted succesfully.");
            }
            else
            {
                MessageBox.Show("Genre was NOT deleted.");
            }

            refreshIncrement.ExecuteNonQuery();

            LoadData("genre");

            db.closeConnection();
        }
    }
}
