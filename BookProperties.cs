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
    public partial class BookProperties : UserControl
    {
        public BookProperties()
        {
            InitializeComponent();
        }

        public void Fill(Book book)
        {
            labelBookName.Text = book.Name;
            labelAuthor.Text = book.AuthorID.ToString();
            labelPublisher.Text = book.PublisherID.ToString();
            labelISBN.Text = book.ISBN.ToString();
            labelDiscipline.Text = book.Disciplines.ToString();
            labelYear.Text = book.Year.ToString();
            pictureBox1.Image = Image.FromFile($@"{book.Photo}");
        }
        
    }
}
