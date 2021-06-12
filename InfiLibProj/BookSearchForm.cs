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
    public partial class BookSearchForm : Form
    {
        public BookSearchForm()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Point lastPoint;

        private void BookSearchForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void BookSearchForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadData(MySqlCommand commandName)
        {
            DB db = new DB();

            string query = "SELECT * FROM `books`;";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            db.openConnection();

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(commandName);

            da.Fill(dt);
            db.closeConnection();
            da.Dispose();

            searchDataGrid.DataSource = dt;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand searchById = new MySqlCommand("SELECT * FROM `books` WHERE id = @bookId;", db.getConnection());
            searchById.Parameters.Add("@bookId", MySqlDbType.Int64).Value = searchLine.Text;

            MySqlCommand searchByName = new MySqlCommand("SELECT * FROM `books` WHERE name = @bookName;", db.getConnection());
            searchByName.Parameters.Add("@bookName", MySqlDbType.VarChar).Value = searchLine.Text;

            MySqlCommand searchByAuthor = new MySqlCommand("SELECT * FROM `books` WHERE author = @bookAuthor;", db.getConnection());
            searchByAuthor.Parameters.Add("@bookAuthor", MySqlDbType.VarChar).Value = searchLine.Text;

            MySqlCommand searchByIssued = new MySqlCommand("SELECT * FROM `books` WHERE issued = @bookIssued;", db.getConnection());
            searchByIssued.Parameters.Add("@bookIssued", MySqlDbType.Int64).Value = searchLine.Text;

            db.openConnection();

            if (searchRadioId.Checked == false && searchRadioName.Checked == false && searchRadioAuthor.Checked == false && searchRadioIssue.Checked == false)
            {
                MessageBox.Show("Please choose one option!");
                db.closeConnection();
                return;
            }

            if (searchRadioId.Checked)
            {
                LoadData(searchById);
                return;
            }

            if (searchRadioName.Checked)
            {
                LoadData(searchByName);
                return;
            }

            if (searchRadioAuthor.Checked)
            {
                LoadData(searchByAuthor);
                return;
            }

            if (searchRadioIssue.Checked)
            {
                LoadData(searchByIssued);
                return;
            }

            db.closeConnection();
        }
    }
}
