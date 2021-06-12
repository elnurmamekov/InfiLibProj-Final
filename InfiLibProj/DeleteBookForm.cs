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
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `books` WHERE id = @id;", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.Int64).Value = BookIDDelete.Text;

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `books` AUTO_INCREMENT=1;", db.getConnection());

            db.openConnection();

            if (command.ExecuteNonQuery() == 1 && refreshIncrement.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Book was deleted succesfully.");
            }
            else
            {
                MessageBox.Show("Book was NOT deleted.");
            }
        }
    }
}
