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
    public partial class MainArchivistForm : Form
    {
        public MainArchivistForm()
        {
            InitializeComponent();
        }

        public static ModelEF Model = new ModelEF();
        List<Book> Books = Model.Book.ToList();
       

        private void button4_Click(object sender, EventArgs e)
        {
            ReaderListForm form = new ReaderListForm();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private List<string> GetProp<T>(T o)
        {
            List<string> strings = new List<string>();
            strings = typeof(T).GetProperties().
               Where(x => !x.SetMethod.Attributes.ToString().Contains("Virtual")).
               Select(p => p.Name).ToList();
            return strings;
        }

        private void MainArchivistForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveDataSet.Book". При необходимости она может быть перемещена или удалена.
            
        }



        private void Load1()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in Books)
            {
                BookProperties bookProperties = new BookProperties();
                bookProperties.Fill(item);
                flowLayoutPanel1.Controls.Add(bookProperties);
            }
        }

        private void MainArchivistForm_Load_1(object sender, EventArgs e)
        {
            Load1();
        }
    }
}
