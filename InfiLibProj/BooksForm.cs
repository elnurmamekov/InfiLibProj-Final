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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();

            LoadData("books");
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

            BooksFormDataGrid.DataSource = dt;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `books` (`name`, `author`, `issued`) VALUES (@bookName, @author, @bookIssued);", db.getConnection());

            command.Parameters.Add("@bookName", MySqlDbType.VarChar).Value = BookName.Text;
            command.Parameters.Add("@author", MySqlDbType.Int64).Value = Author.Text;

            if (bookIssued.Text == "")
            {
                command.Parameters.Add("@bookIssued", MySqlDbType.Int32).Value = "0";
            }
            else
            {
                command.Parameters.Add("@bookIssued", MySqlDbType.Int32).Value = bookIssued.Text;
            }

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `books` AUTO_INCREMENT=1;", db.getConnection());

            db.openConnection();

            if (BookName.Text == "" || Author.Text == "")
            {
                MessageBox.Show("Not all fields were filled!");
                db.closeConnection();
                return;
            }

            refreshIncrement.ExecuteNonQuery();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Book was added succesfully.");
            }
            else
                MessageBox.Show("Book was NOT added.");

            LoadData("books");

            db.closeConnection();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand commandName = new MySqlCommand("UPDATE `books` SET `name` = @bookName WHERE id = @bookId;", db.getConnection());

            MySqlCommand commandAuthor = new MySqlCommand("UPDATE `books` SET `author` = @author WHERE id = @bookId;", db.getConnection());

            MySqlCommand commandIssue = new MySqlCommand("UPDATE `books` SET `issued` = @bookIssued WHERE id = @bookId;", db.getConnection());

            if (BookName.Text != "")
            {
                commandName.Parameters.Add("@bookId", MySqlDbType.Int64).Value = BookId.Text;
                commandName.Parameters.Add("@bookName", MySqlDbType.VarChar).Value = BookName.Text;
            }

            if (Author.Text != "")
            {
                commandAuthor.Parameters.Add("@bookId", MySqlDbType.Int64).Value = BookId.Text;
                commandAuthor.Parameters.Add("@author", MySqlDbType.Int64).Value = Author.Text;
            }

            if (bookIssued.Text != "")
            {
                commandIssue.Parameters.Add("@bookId", MySqlDbType.Int64).Value = BookId.Text;
                commandIssue.Parameters.Add("@bookIssued", MySqlDbType.Int64).Value = bookIssued.Text;
            }

            db.openConnection();

            if (BookName.Text != "")
            {
                if (commandName.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Book name was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Book name was NOT changed.");
                }
            }

            if (Author.Text != "")
            {
                if (commandAuthor.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Book's author was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Book's author was NOT changed.");
                }
            }

            if (bookIssued.Text != "")
            {
                if (commandIssue.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Book's issue status was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Book's issue status was NOT changed.");
                }
            }

            LoadData("books");

            db.closeConnection();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `books` WHERE id = @bookId;", db.getConnection());

            command.Parameters.Add("@bookId", MySqlDbType.Int64).Value = BookId.Text;

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `books` AUTO_INCREMENT=1;", db.getConnection());

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Book was deleted succesfully.");
            }
            else
            {
                MessageBox.Show("Book was NOT deleted.");
            }

            refreshIncrement.ExecuteNonQuery();

            LoadData("books");

            db.closeConnection();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            BookSearchForm bookSearchForm = new BookSearchForm();

            bookSearchForm.Show();

        }
    }
}
