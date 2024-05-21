using NormDiplom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormDiplom
{
    public partial class EditBookForm : Form
    {
        public EditBookForm()
        {
            InitializeComponent();
        }
        


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        
        public void Load1(Book book)
        {
            textBoxName.Text = book.Name;
            //textboxA.Text = book.Author.Abbreviation.ToString();
            textBoxPublisher.Text = book.Publisher.Name.ToString();
            textBoxISBN.Text = book.ISBN.ToString();
            // tex.Text = book.Disciplines.ToString();
            textBoxYear.Text = book.Year.ToString();
            pictureBox1.Image = Image.FromFile($@"{book.Photo}");
        }

        private void EditBookForm_Load(object sender, EventArgs e )
        {
            Book book = new Book();
            
        }
    }
}
