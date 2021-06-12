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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void SelectBtnAdd_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "jpg files(.*jpg) | *.jpg | PNG files(.*png) | *.png | All Files(*.*) | *.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    AddPictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand noIdAdd = new MySqlCommand("INSERT INTO `students` (`f_name`, `l_name`, `gender`, `email`, `phone`, `image`) VALUES (@f_name, @l_name, @gender, @email, @phone, @image);", db.getConnection());

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `books` AUTO_INCREMENT=1;", db.getConnection());

            noIdAdd.Parameters.Add("@f_name", MySqlDbType.VarChar).Value = StFNameAdd.Text;
            noIdAdd.Parameters.Add("@l_name", MySqlDbType.VarChar).Value = StLNameAdd.Text;
            noIdAdd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = StGenderAdd.Text;
            noIdAdd.Parameters.Add("@email", MySqlDbType.VarChar).Value = StEmailAdd.Text;
            noIdAdd.Parameters.Add("@phone", MySqlDbType.Int64).Value = StPhoneAdd.Text;
            noIdAdd.Parameters.Add("@image", MySqlDbType.VarChar).Value = AddPictureBox.ImageLocation;

            db.openConnection();

            if (StFNameAdd.Text == "" || StLNameAdd.Text == "" || StGenderAdd.Text == "" || StEmailAdd.Text == "" || StPhoneAdd.Text == "")
            {
                MessageBox.Show("Not all fields were filled!");
                db.closeConnection();
                return;
            }

            if (noIdAdd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Student was added succesfully.");
            }
            else
                MessageBox.Show("Student was NOT added.");    

            refreshIncrement.ExecuteNonQuery();

            db.closeConnection();
        }
    }
}
