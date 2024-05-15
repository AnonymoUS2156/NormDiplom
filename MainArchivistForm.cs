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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MainArchivistForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.archiveDataSet.Book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveDataSet.Author". При необходимости она может быть перемещена или удалена.
            this.authorTableAdapter.Fill(this.archiveDataSet.Author);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReaderListForm form = new ReaderListForm();
            this.Hide();
            form.Show();
        }
    }
}
