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
    public partial class EditBookForm : Form
    {
        public EditBookForm()
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

                AuthorComboBoxEdit.Items.Add(itemAuthor);
            }

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

                GenreComboBoxEdit.Items.Add(itemGenre);
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

        private int findId(String tableName, String row, String preferedValue)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT `id` FROM `" + tableName + "` WHERE `" + row + "` = '" + preferedValue + "';", db.getConnection());
            db.openConnection();

            return Convert.ToInt32(cmd.ExecuteScalar());
        }


        private void SearchBtnEdit_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection();
            MySqlCommand cmd = db.getConnection().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from `books` WHERE `id` = '" + BookIDEdit.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                BookNameEdit.Text = dr["name"].ToString();
                AuthorComboBoxEdit.SelectedIndex = findId("authors", "name", dr["author"].ToString()) - 1;
                GenreComboBoxEdit.SelectedIndex = findId("genre", "name", dr["genre"].ToString()) - 1;
                BookDescriptionBoxEdit.Text = dr["description"].ToString();
                BookIssueEdit.Checked = Convert.ToBoolean(dr["issued"]);
                EditPictureBox.ImageLocation = dr["image"].ToString();
            }

            db.closeConnection();
        }

        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand NameEdit = new MySqlCommand("UPDATE `books` SET `name` = @name where id = @id;", db.getConnection());
            MySqlCommand AuthorEdit = new MySqlCommand("UPDATE `books` SET `author` = @author where id = @id;", db.getConnection());
            MySqlCommand GenreEdit = new MySqlCommand("UPDATE `books` SET  `genre` = @genre where id = @id;", db.getConnection());
            MySqlCommand DescriptionEdit = new MySqlCommand("UPDATE `books` SET `description` = @description where id = @id;", db.getConnection());
            MySqlCommand IssuedEdit = new MySqlCommand("UPDATE `books` SET `issued` = @issued where id = @id;", db.getConnection());
            MySqlCommand ImageEdit = new MySqlCommand("UPDATE `books` SET `image` = @image where id = @id;", db.getConnection());

            NameEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = BookIDEdit.Text;
            AuthorEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = BookIDEdit.Text;
            GenreEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = BookIDEdit.Text;
            DescriptionEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = BookIDEdit.Text;
            IssuedEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = BookIDEdit.Text;
            ImageEdit.Parameters.Add("@id", MySqlDbType.Int64).Value = BookIDEdit.Text;

            NameEdit.Parameters.Add("@name", MySqlDbType.VarChar).Value = BookNameEdit.Text;
            AuthorEdit.Parameters.Add("@author", MySqlDbType.VarChar).Value = AuthorComboBoxEdit.Text;
            GenreEdit.Parameters.Add("@genre", MySqlDbType.VarChar).Value = GenreComboBoxEdit.Text;
            DescriptionEdit.Parameters.Add("@description", MySqlDbType.VarChar).Value = BookDescriptionBoxEdit.Text;
            IssuedEdit.Parameters.Add("@issued", MySqlDbType.Int64).Value = Convert.ToInt64(BookIssueEdit.Checked);
            ImageEdit.Parameters.Add("@image", MySqlDbType.VarChar).Value = EditPictureBox.ImageLocation;

            db.openConnection();

            if (BookNameEdit.Text != "")
            {
                NameEdit.ExecuteNonQuery();
            }
            if (AuthorComboBoxEdit.Text != "")
            {
                AuthorEdit.ExecuteNonQuery();
            }
            if (GenreComboBoxEdit.Text != "")
            {
                GenreEdit.ExecuteNonQuery();
            }
            if (BookDescriptionBoxEdit.Text != "")
            {
                DescriptionEdit.ExecuteNonQuery();
            }
            if (BookIssueEdit.Text != "")
            {
                IssuedEdit.ExecuteNonQuery();
            }
            
            ImageEdit.ExecuteNonQuery();

            MessageBox.Show("Book was changed successfully.");
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
    }
}
