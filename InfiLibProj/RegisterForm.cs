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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {

            if (UserName.Text == "")
            {
                MessageBox.Show("Please, enter your name!");
                return;
            }

            if (UserSurname.Text == "")
            {
                MessageBox.Show("Please, enter your surname!");
                return;
            }
            
            if (NewtxtLogin.Text == "")
            {
                MessageBox.Show("Please, enter login!");
                return;
            }
            
            if (NewtxtPassword.Text == "")
            {
                MessageBox.Show("Please, enter password!");
                return;
            }

            if (isUserExist())
                return;
            
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @pass, @name,@surname);", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = NewtxtLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = NewtxtPassword.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurname.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account was created succesfully.");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Account was NOT created succesfully.");


            db.closeConnection();
        }

        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE 'login' = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = NewtxtLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User name already exists!");
                return true;
            }
            else
                return false;
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();

            logForm.Show();
            this.Hide();
        }

        private void signInBtn2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }

        Point lastPoint;
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
