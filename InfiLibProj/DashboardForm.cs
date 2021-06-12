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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            getTotalBooksNumber();
            getTotalStudentsNumber();
            getTotalIssuesNumber();
            getTotalAuthorsNumber();    
        }

        private void getTotalBooksNumber()
        {
            DB db = new DB();

            string query = "SELECT COUNT(*) FROM `books`;";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            db.openConnection();

            object sqlValue = cmd.ExecuteScalar();

            totalBooksNumber.Text = sqlValue.ToString();

            db.closeConnection();
        }

        private void getTotalStudentsNumber()
        {
            DB db = new DB();

            string query = "SELECT COUNT(*) FROM `students`;";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            db.openConnection();

            object sqlValue = cmd.ExecuteScalar();

            totalStudentsNumber.Text = sqlValue.ToString();

            db.closeConnection();
        }

        private void getTotalIssuesNumber()
        {
            DB db = new DB();

            string query = "SELECT COUNT(*) FROM `lent_books`;";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            db.openConnection();

            object sqlValue = cmd.ExecuteScalar();

            totalIssuesNumber.Text = sqlValue.ToString();

            db.closeConnection();
        }

        private void getTotalAuthorsNumber()
        {
            DB db = new DB();

            string query = "SELECT COUNT(*) FROM `authors`;";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            db.openConnection();

            object sqlValue = cmd.ExecuteScalar();

            totalAuthorsNumber.Text = sqlValue.ToString();

            db.closeConnection();
        }
    }
}
