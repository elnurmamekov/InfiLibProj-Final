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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();

            LoadData("lent_books");
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

            issueBooksDataGrid.DataSource = dt;
        }

        private int findId(String tableName, String row, String preferedValue)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT `id` FROM `" + tableName + "` WHERE `" + row + "` = '" + preferedValue + "';", db.getConnection());
            db.openConnection();

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `lent_books` (`book_id`, `student_id`, `issue_date`, `return_date`) VALUES (@bookId, @studentId, @issueDate, @returnDate);", db.getConnection());

            command.Parameters.Add("@bookId", MySqlDbType.Int32).Value = issueBookId.Text;
            command.Parameters.Add("@studentId", MySqlDbType.Int64).Value = IssueStudentId.Text;
            command.Parameters.Add("@issueDate", MySqlDbType.Date).Value = issueBookIssueDate.Text;
            command.Parameters.Add("@returnDate", MySqlDbType.Date).Value = issueBookReturnDate.Text;

            int id = findId("books", "id", issueBookId.Text);

            MySqlCommand makeIssued = new MySqlCommand("UPDATE `books` SET `issued` = 1 WHERE id = " + id.ToString() + ";", db.getConnection());

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `lent_books` AUTO_INCREMENT=1;", db.getConnection());

            db.openConnection();

            makeIssued.ExecuteNonQuery();

            refreshIncrement.ExecuteNonQuery();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Entry was added succesfully.");
            }
            else
                MessageBox.Show("Entry was NOT added.");

            LoadData("lent_books");

            db.closeConnection();
        }

        private void issueBookUpdateBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `lent_books` SET `book_id` = @bookId, `student_id` = @studentId, `issue_date` = @issueDate, `return_date` = @returnDate WHERE id = @id;", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = issueBookEntryId.Text;
            command.Parameters.Add("@bookId", MySqlDbType.Int32).Value = issueBookId.Text;
            command.Parameters.Add("@studentId", MySqlDbType.Int64).Value = IssueStudentId.Text;
            command.Parameters.Add("@issueDate", MySqlDbType.Date).Value = issueBookIssueDate.Text;
            command.Parameters.Add("@returnDate", MySqlDbType.Date).Value = issueBookReturnDate.Text;

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `lent_books` AUTO_INCREMENT=1;", db.getConnection());

            db.openConnection();

            refreshIncrement.ExecuteNonQuery();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Entry was changed succesfully.");
            }
            else
                MessageBox.Show("Entry was NOT changed.");

            LoadData("lent_books");

            db.closeConnection();
        }
    }
}
