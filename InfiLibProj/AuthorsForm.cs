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
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();

            LoadData("authors");
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

            AuthorsFormDataGrid.DataSource = dt;
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `authors` (`name`, `about`) VALUES (@authorName, @authorAbout);", db.getConnection());

            command.Parameters.Add("@authorName", MySqlDbType.VarChar).Value = AuthorFirstName.Text;
            command.Parameters.Add("@authorAbout", MySqlDbType.VarChar).Value = AboutAuthorBox.Text;

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `authors` AUTO_INCREMENT=1;", db.getConnection());

            db.openConnection();

            if (AuthorFirstName.Text == "" || AboutAuthorBox.Text == "")
            {
                MessageBox.Show("Not all fields were filled!");
                db.closeConnection();
                return;
            }

            refreshIncrement.ExecuteNonQuery();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Author was added succesfully.");
            }
            else
                MessageBox.Show("Author was NOT added.");

            LoadData("authors");

            db.closeConnection();
        }

        private void AuthorsUpdateBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand commandName = new MySqlCommand("UPDATE `authors` SET `name` = @authorName WHERE id = @authorId;", db.getConnection());

            MySqlCommand commandAbout = new MySqlCommand("UPDATE `authors` SET `about` = @authorAbout WHERE id = @authorId;", db.getConnection());

            if (AuthorFirstName.Text != "")
            {
                commandName.Parameters.Add("@authorId", MySqlDbType.Int64).Value = AuthorId.Text;
                commandName.Parameters.Add("@authorName", MySqlDbType.VarChar).Value = AuthorFirstName.Text;
            }

            if (AboutAuthorBox.Text != "")
            {
                commandAbout.Parameters.Add("@authorId", MySqlDbType.Int64).Value = AuthorId.Text;
                commandAbout.Parameters.Add("@authorAbout", MySqlDbType.VarChar).Value = AboutAuthorBox.Text;
            }

            db.openConnection();

            if (AuthorFirstName.Text != "")
            {
                if (commandName.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Author's first name was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Author's first name was NOT changed.");
                }
            }

            if (AboutAuthorBox.Text != "")
            {
                if (commandAbout.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Author's about passage was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Author's about passage was NOT changed.");
                }
            }

            LoadData("authors");

            db.closeConnection();
        }

        private void AuthorsDeleteBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `authors` WHERE id = @authorId;", db.getConnection());

            command.Parameters.Add("@authorId", MySqlDbType.Int64).Value = AuthorId.Text;

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `authors` AUTO_INCREMENT=1;", db.getConnection());

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Author was deleted succesfully.");
            }
            else
            {
                MessageBox.Show("Author was NOT deleted.");
            }

            refreshIncrement.ExecuteNonQuery();

            LoadData("authors");

            db.closeConnection();
        }
    }
}
