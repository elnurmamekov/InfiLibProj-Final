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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();

            LoadData("returned_books");
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

            returnBookDataTable.DataSource = dt;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `returned_books` (`issue_id`, `return_date`) VALUES (@issueId, @returnDate);", db.getConnection());

            MySqlCommand getBookId = new MySqlCommand("SELECT `book_id` FROM `lent_books` WHERE id = @issueId;", db.getConnection());

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `returned_books` AUTO_INCREMENT=1;", db.getConnection());

            command.Parameters.Add("@issueId", MySqlDbType.Int32).Value = returnBookIssueId.Text;
            getBookId.Parameters.Add("@issueId", MySqlDbType.Int32).Value = returnBookIssueId.Text;
            command.Parameters.Add("@returnDate", MySqlDbType.Date).Value = returnBookReturnDate.Text;

            db.openConnection();

            if (returnBookIssueId.Text == "" || returnBookIssueId.Text == "" || returnBookReturnDate.Text == "")
            {
                MessageBox.Show("Not all fields were filled!");
                db.closeConnection();
                return;
            }

            MySqlCommand makeNotIssued = new MySqlCommand("UPDATE `books` SET `issued` = 0 WHERE id = " + getBookId.ExecuteNonQuery() + ";", db.getConnection());

            makeNotIssued.ExecuteNonQuery();

            refreshIncrement.ExecuteNonQuery();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Entry was added succesfully.");
            }
            else
                MessageBox.Show("Entry was NOT added.");

            LoadData("returned_books");

            db.closeConnection();
        }

        private void returnBookUpdateBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand commandIssueId = new MySqlCommand("UPDATE `returned_books` SET `issue_id` = @issueId WHERE id = @returnId;", db.getConnection());

            MySqlCommand commandDate = new MySqlCommand("UPDATE `returned_books` SET `return_date` = @returnDate WHERE id = @returnId;", db.getConnection());

            if (returnBookIssueId.Text != "")
            {
                commandIssueId.Parameters.Add("@returnId", MySqlDbType.Int64).Value = returnBookEntryId.Text;
                commandIssueId.Parameters.Add("@issueId", MySqlDbType.Int64).Value = returnBookIssueId.Text;
            }

            if (returnBookReturnDate.Text != "")
            {
                commandDate.Parameters.Add("@returnId", MySqlDbType.Int64).Value = returnBookEntryId.Text;
                commandDate.Parameters.Add("@returnDate", MySqlDbType.Date).Value = returnBookReturnDate.Text;
            }

            db.openConnection();

            if (returnBookIssueId.Text != "")
            {
                if (commandIssueId.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Entry was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Entry was NOT changed.");
                }
            }

            if (returnBookReturnDate.Text != "")
            {
                if (commandDate.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Entry was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Entry was NOT changed.");
                }
            }

            LoadData("returned_books");

            db.closeConnection();
        }
    }
}
