using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfiLibProj
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();

            LoadData("students");
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

            guna2DataGridView3.DataSource = dt;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentAddBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `students` (`full_name`, `email`, `phone`) VALUES (@full_name, @email, @phone);", db.getConnection());

            command.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = StudentName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = StudentEmail.Text;
            command.Parameters.Add("@phone", MySqlDbType.Int64).Value = StudentContactNumber.Text;

            db.openConnection();

            if (StudentName.Text == "" || StudentEmail.Text == "" || StudentContactNumber.Text == "")
            {
                MessageBox.Show("Not all fields were filled!");
                db.closeConnection();
                return;
            }

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Student was added succesfully.");
            }
            else
                MessageBox.Show("Student was NOT added.");

            LoadData("students");

            db.closeConnection();
        }

        private void StudentUpdateBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `students` SET `full_name` = @full_name, `email` = @email, `phone` = @phone WHERE id = @id;", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.Int64).Value = StudentId.Text;
            command.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = StudentName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = StudentEmail.Text;
            command.Parameters.Add("@phone", MySqlDbType.Int64).Value = StudentContactNumber.Text;

            MySqlCommand commandName = new MySqlCommand("UPDATE `students` SET `full_name` = @full_name WHERE id = @id;", db.getConnection());

            MySqlCommand commandEmail = new MySqlCommand("UPDATE `students` SET `email` = @email WHERE id = @id;", db.getConnection());

            MySqlCommand commandPhone = new MySqlCommand("UPDATE `students` SET `phone` = @phone WHERE id = @id;", db.getConnection());

            if (StudentName.Text != "")
            {
                commandName.Parameters.Add("@id", MySqlDbType.Int64).Value = StudentId.Text;
                commandName.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = StudentName.Text;
            }

            if (StudentEmail.Text != "")
            {
                commandEmail.Parameters.Add("@id", MySqlDbType.Int64).Value = StudentId.Text;
                commandEmail.Parameters.Add("@email", MySqlDbType.VarChar).Value = StudentEmail.Text;
            }

            if (StudentContactNumber.Text != "")
            {
                commandPhone.Parameters.Add("@id", MySqlDbType.Int64).Value = StudentId.Text;
                commandPhone.Parameters.Add("@phone", MySqlDbType.VarChar).Value = StudentContactNumber.Text;
            }

            db.openConnection();

            if (StudentName.Text != "")
            {
                if (commandName.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Student's name was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Student's name was NOT changed.");
                }
            }

            if (StudentEmail.Text != "")
            {
                if (commandEmail.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Student's Email was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Student's Email was NOT changed.");
                }
            }

            if (StudentContactNumber.Text != "")
            {
                if (commandPhone.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Student's number was changed succesfully.");
                }
                else
                {
                    MessageBox.Show("Student's number was NOT changed.");
                }
            }

            LoadData("students");

            db.closeConnection();
        }

        private void StudentDeleteBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `students` WHERE id = @id;", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.Int64).Value = StudentId.Text;

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `students` AUTO_INCREMENT=1;", db.getConnection());

            db.openConnection();

            if (command.ExecuteNonQuery() == 1 && refreshIncrement.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Student was deleted succesfully.");
            }
            else
            {
                MessageBox.Show("Student was NOT deleted.");
            }

            LoadData("students");

            db.closeConnection();
        }
    }
}
