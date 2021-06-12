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
    public partial class DeleteStudentForm : Form
    {
        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        private void DeleteStudentBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `students` WHERE id = @id;", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.Int64).Value = StIDDelete.Text;

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
        }
    }
}
