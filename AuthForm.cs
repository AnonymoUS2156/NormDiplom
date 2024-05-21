using NormDiplom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormDiplom
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainArchivistForm mainArchivistForm = new MainArchivistForm();
            mainArchivistForm.Show();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
