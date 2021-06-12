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
    public partial class LibrariansForm : Form
    {
        public LibrariansForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            MenuForm MenuForm = new MenuForm();

            MenuForm.Show();
            this.Hide();
        }
    }
}
