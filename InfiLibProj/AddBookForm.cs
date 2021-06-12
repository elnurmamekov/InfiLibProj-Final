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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();

            DB db = new DB();
            MySqlCommand authorCountSql = new MySqlCommand("SELECT COUNT(*) FROM `authors`;", db.getConnection());
            MySqlCommand genreCountSql = new MySqlCommand("SELECT COUNT(*) FROM `genre`;", db.getConnection());
            db.openConnection();

            object proxy1 = authorCountSql.ExecuteScalar();
            object proxy2 = genreCountSql.ExecuteScalar();

            int authorCount = Convert.ToInt32(proxy1);
            int genreCount = Convert.ToInt32(proxy2);

            db.closeConnection();

            String query = "";

            for (int i = 1; i <= authorCount; i++)
            {
                ComboboxItem itemAuthor = new ComboboxItem();
                query = "SELECT `name` FROM `authors` WHERE id = " + i.ToString() + ";";
                MySqlCommand getAuthorName = new MySqlCommand(query, db.getConnection());
                db.openConnection();

                itemAuthor.Text = getAuthorName.ExecuteScalar().ToString();
                itemAuthor.Value = i;

                db.closeConnection();

                BookAddComboBoxAuthor.Items.Add(itemAuthor);
            }
            BookAddComboBoxAuthor.SelectedIndex = 0;

            query = "";

            for (int i = 1; i <= genreCount; i++)
            {
                ComboboxItem itemGenre = new ComboboxItem();
                query = "SELECT `name` FROM `genre` WHERE id = " + i.ToString() + ";";

                MySqlCommand getGenreName = new MySqlCommand(query, db.getConnection());
                db.openConnection();

                itemGenre.Text = getGenreName.ExecuteScalar().ToString();
                itemGenre.Value = i;

                db.closeConnection();

                BookAddComboBoxGenre.Items.Add(itemGenre);
            }
            BookAddComboBoxGenre.SelectedIndex = 0;
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

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand noIdAdd = new MySqlCommand("INSERT INTO `books` (`name`, `author`, `genre`, `description`, `issued`, `image`) VALUES (@name, @author, @genre, @desc, @issued, @image);", db.getConnection());

            MySqlCommand refreshIncrement = new MySqlCommand("ALTER TABLE `books` AUTO_INCREMENT=1;", db.getConnection());

            noIdAdd.Parameters.Add("@name", MySqlDbType.VarChar).Value = BookNameAdd.Text;
            noIdAdd.Parameters.Add("@author", MySqlDbType.VarChar).Value = BookAddComboBoxAuthor.Text;
            noIdAdd.Parameters.Add("@genre", MySqlDbType.VarChar).Value = BookAddComboBoxGenre.Text;
            noIdAdd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = BookDescriptionBoxAdd.Text;
            noIdAdd.Parameters.Add("@issued", MySqlDbType.Int64).Value = 0;
            noIdAdd.Parameters.Add("@image", MySqlDbType.VarChar).Value = AddPictureBox.ImageLocation;

            db.openConnection();

            if (BookNameAdd.Text == "" || BookAddComboBoxAuthor.Text == "" || BookAddComboBoxGenre.Text == "" || AddPictureBox.ImageLocation == "")
            {
                MessageBox.Show("Not all fields were filled!");
                db.closeConnection();
                return;
            }

            if (noIdAdd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Book was added succesfully.");
            }
            else
                MessageBox.Show("Book was NOT added.");

            refreshIncrement.ExecuteNonQuery();

            db.closeConnection();
        }
    }
}
