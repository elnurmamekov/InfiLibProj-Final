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
    public partial class EditStudentForm : Form
    {
        public EditStudentForm()
        {
            InitializeComponent();
        }

        private void SelectBtnEdit_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "jpg files(.*jpg) | *.jpg | PNG files(.*png) | *.png | All Files(*.*) | *.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    EditPictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditStudentBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand FNameEdit = new MySqlCommand("UPDATE `students` SET `f_name` = @f_name WHERE id = @id;", db.getConnection());
            MySqlCommand LNameEdit = new MySqlCommand("UPDATE `students` SET `l_name` = @l_name WHERE id = @id;", db.getConnection());
            MySqlCommand GenderEdit = new MySqlCommand("UPDATE `students` SET  `gender` = @gender WHERE id = @id;", db.getConnection());
            MySqlCommand EmailEdit = new MySqlCommand("UPDATE `students` SET `email` = @email WHERE id = @id;", db.getConnection());
            MySqlCommand PhoneEdit = new MySqlCommand("UPDATE `students` SET `phone` = @phone WHERE id = @id;", db.getConnection());
            MySqlCommand ImageEdit = new MySqlCommand("UPDATE `students` SET `image` = @image WHERE id = @id;", db.getConnection());

            FNameEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = StIDEdit.Text;
            LNameEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = StIDEdit.Text;
            GenderEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = StIDEdit.Text;
            EmailEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = StIDEdit.Text;
            PhoneEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = StIDEdit.Text;
            ImageEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = StIDEdit.Text;

            FNameEdit.Parameters.Add("@f_name", MySqlDbType.VarChar).Value = StFNameEdit.Text;
            LNameEdit.Parameters.Add("@l_name", MySqlDbType.VarChar).Value = StLNameEdit.Text;
            GenderEdit.Parameters.Add("@gender", MySqlDbType.VarChar).Value = StGenderEdit.Text;
            EmailEdit.Parameters.Add("@email", MySqlDbType.VarChar).Value = StEmailEdit.Text;
            PhoneEdit.Parameters.Add("@phone", MySqlDbType.VarChar).Value = StPhoneEdit.Text;
            ImageEdit.Parameters.Add("@image", MySqlDbType.VarChar).Value = EditPictureBox.ImageLocation;

            db.openConnection();

            if (StFNameEdit.Text != "")
            {
                FNameEdit.ExecuteNonQuery();
            }
            if (StLNameEdit.Text != "")
            {
                LNameEdit.ExecuteNonQuery();
            }
            if (StGenderEdit.Text != "")
            {
                GenderEdit.ExecuteNonQuery();
            }
            if (StEmailEdit.Text != "")
            {
                EmailEdit.ExecuteNonQuery();
            }
            if (StPhoneEdit.Text != "")
            {
                PhoneEdit.ExecuteNonQuery();
            }

            ImageEdit.ExecuteNonQuery();

            MessageBox.Show("Student was changed successfully.");
        }

        private void SearchBtnEdit_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection();
            MySqlCommand cmd = db.getConnection().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from `students` WHERE `id` = '" + StIDEdit.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                StFNameEdit.Text = dr["f_name"].ToString();
                StLNameEdit.Text = dr["l_name"].ToString();
                StGenderEdit.Text = dr["gender"].ToString();
                StEmailEdit.Text = dr["email"].ToString();
                StPhoneEdit.Text = dr["phone"].ToString();
                EditPictureBox.ImageLocation = dr["image"].ToString();
            }

            db.closeConnection();

           
        }
    }
}
