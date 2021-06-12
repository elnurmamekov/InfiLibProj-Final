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
    public partial class MenuForm : Form
    {
        private Form currentChildForm;

        public MenuForm()
        {
            InitializeComponent();
            customizeDesign();
            OpenChildForm(new DashboardForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LibrariansForm LibForm = new LibrariansForm();

            LibForm.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LoginForm LogForm = new LoginForm();

            LogForm.Show();
            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());
            hideSubMenu();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            showSubMenu(studentDropDPanel);
        }


        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            showSubMenu(BooksPanel);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IssueBook());
            hideSubMenu();
        }

        Point lastPoint;

        private void MenuForm_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReturnBook());
            hideSubMenu();
        }

        private void MenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelChildForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelChildForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void customizeDesign()
        {
            BooksPanel.Visible = false;
            GenresPanel.Visible = false;
            AuthorsPanel.Visible = false;
            studentDropDPanel.Visible = false;
            EventsPanel.Visible = false;
        }

        public void hideSubMenu()
        {
            if (studentDropDPanel.Visible == true)
                studentDropDPanel.Visible = false;
            if (BooksPanel.Visible == true)
                BooksPanel.Visible = false;
            if (GenresPanel.Visible == true)
                GenresPanel.Visible = false;
            if (AuthorsPanel.Visible == true)
                AuthorsPanel.Visible = false;
            if (EventsPanel.Visible == true)
                EventsPanel.Visible = false;
        }

        public void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void StAddBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStudentForm());
        }

        private void StEditBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditStudentForm());
        }

        private void StDeleteBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteStudentForm());
        }

        private void StListBtn_Click(object sender, EventArgs e)
        {
            StudentListForm stList = new StudentListForm();

            stList.Show();
        }

        private void AddBooksBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddBookForm());
        }

        private void ManageAuthorsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AuthorsForm());
            hideSubMenu();
        }

        private void ManGenreBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GenresForm());
            hideSubMenu();
        }

        private void EditBooksBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditBookForm());
        }

        private void DeleteBooksBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteBookForm());
        }

        private void BooksListBtn_Click(object sender, EventArgs e)
        {
            BookListForm bookList = new BookListForm();

            bookList.Show();
        }

        private void GenresBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(GenresPanel);
        }

        private void AuthorsBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(AuthorsPanel);
        }

        private void EventsBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(EventsPanel);
        }
    }
}
