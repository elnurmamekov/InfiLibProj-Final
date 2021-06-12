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
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void BookListForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void BookListForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoadData(MySqlCommand commandName)
        {
            DB db = new DB();
            db.openConnection();

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(commandName);

            da.Fill(dt);
            db.closeConnection();
            da.Dispose();

            DataGridBookList.DataSource = dt;
        }

        private void SearchBtnBookList_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand searchById = new MySqlCommand("SELECT * FROM `books` WHERE id = @bookId;", db.getConnection());
            searchById.Parameters.Add("@bookId", MySqlDbType.Int64).Value = SearchLineBookList.Text;

            MySqlCommand searchByName = new MySqlCommand("SELECT * FROM `books` WHERE name = @bookName;", db.getConnection());
            searchByName.Parameters.Add("@bookName", MySqlDbType.VarChar).Value = SearchLineBookList.Text;

            MySqlCommand searchByAuthor = new MySqlCommand("SELECT * FROM `books` WHERE author = @bookAuthor;", db.getConnection());
            searchByAuthor.Parameters.Add("@bookAuthor", MySqlDbType.Int64).Value = SearchLineBookList.Text;

            MySqlCommand searchByGenre = new MySqlCommand("SELECT * FROM `books` WHERE genre = @bookGenre;", db.getConnection());
            searchByGenre.Parameters.Add("@bookGenre", MySqlDbType.Int64).Value = SearchLineBookList.Text;

            MySqlCommand searchByIssue = new MySqlCommand("SELECT * FROM `books` WHERE issued = @bookIssue;", db.getConnection());
            searchByIssue.Parameters.Add("@bookIssue", MySqlDbType.Int64).Value = SearchLineBookList.Text;

            db.openConnection();

            if (BookSearchRadioId.Checked == false && BookSearchRadioBookName.Checked == false && BookSearchRadioAuthor.Checked == false && BookSearchRadioGenre.Checked == false && BookSearchIssueRadio.Checked == false)
            {
                MessageBox.Show("Please choose one option!");
                db.closeConnection();
                return;
            }

            if (BookSearchRadioId.Checked)
            {
                LoadData(searchById);
                return;
            }

            if (BookSearchRadioBookName.Checked)
            {
                LoadData(searchByName);
                return;
            }

            if (BookSearchRadioAuthor.Checked)
            {
                LoadData(searchByAuthor);
                return;
            }

            if (BookSearchRadioGenre.Checked)
            {
                LoadData(searchByGenre);
                return;
            }

            if (BookSearchIssueRadio.Checked)
            {
                LoadData(searchByIssue);
                return;
            }

            db.closeConnection();
        }

        private void DataGridBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridBookList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridBookList.CurrentRow.Selected = true;
                BookIdInfo.Text = DataGridBookList.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                BookNameInfo.Text = DataGridBookList.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                BookAuthorInfo.Text = DataGridBookList.Rows[e.RowIndex].Cells["author"].FormattedValue.ToString();
                BookGenreInfo.Text = DataGridBookList.Rows[e.RowIndex].Cells["genre"].FormattedValue.ToString();
                BookIssueInfo.Text = DataGridBookList.Rows[e.RowIndex].Cells["issued"].FormattedValue.ToString();
                BookPictureBoxInfo.ImageLocation = DataGridBookList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString();
            }
            else
                MessageBox.Show("Data entered is not found!");
        }

        private void BookListShowAllButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand searchAll = new MySqlCommand("SELECT * FROM `books`;", db.getConnection());

            LoadData(searchAll);
        }
    }
}
