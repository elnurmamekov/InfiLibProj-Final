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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void StudentListForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void StudentListForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoadData(MySqlCommand commandName)
        {
            DB db = new DB();

            string query = "SELECT *  FROM `students`;";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            db.openConnection();

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(commandName);

            da.Fill(dt);
            db.closeConnection();
            da.Dispose();

            DataGridStList.DataSource = dt;
        }

        private void SearchBtnStList_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand searchById = new MySqlCommand("SELECT * FROM `students` WHERE id = @studentId;", db.getConnection());
            searchById.Parameters.Add("@studentId", MySqlDbType.Int64).Value = SearchLineStList.Text;

            MySqlCommand searchByFName = new MySqlCommand("SELECT * FROM `students` WHERE f_name = @studentFName;", db.getConnection());
            searchByFName.Parameters.Add("@studentFName", MySqlDbType.VarChar).Value = SearchLineStList.Text;

            MySqlCommand searchByLName = new MySqlCommand("SELECT * FROM `students` WHERE l_name = @studentLName;", db.getConnection());
            searchByLName.Parameters.Add("@studentLName", MySqlDbType.VarChar).Value = SearchLineStList.Text;

            MySqlCommand searchByEmail = new MySqlCommand("SELECT * FROM `students` WHERE email = @studentEmail;", db.getConnection());
            searchByEmail.Parameters.Add("@studentEmail", MySqlDbType.Int64).Value = SearchLineStList.Text;

            db.openConnection();

            if (searchRadioId.Checked == false && searchRadioFName.Checked == false && searchRadioLName.Checked == false && searchRadioEmail.Checked == false)
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

            if (searchRadioFName.Checked)
            {
                LoadData(searchByFName);
                return;
            }

            if (searchRadioLName.Checked)
            {
                LoadData(searchByLName);
                return;
            }

            if (searchRadioEmail.Checked)
            {
                LoadData(searchByEmail);
                return;
            }

            db.closeConnection();
        }

        private void DataGridStList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridStList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridStList.CurrentRow.Selected = true;
                fNameInfo.Text = DataGridStList.Rows[e.RowIndex].Cells["f_name"].FormattedValue.ToString();
                lNameInfo.Text = DataGridStList.Rows[e.RowIndex].Cells["l_name"].FormattedValue.ToString();
                emailInfo.Text = DataGridStList.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                PhoneInfo.Text = DataGridStList.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
                genderInfo.Text = DataGridStList.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString();
                PictureBoxInfo.ImageLocation = DataGridStList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString();
            } else
                MessageBox.Show("Data entered is not found!");
        }

        private void ShowButtonStList_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand searchAll = new MySqlCommand("SELECT * FROM `students`;", db.getConnection());

            LoadData(searchAll);
        }
    }
}
