namespace NormDiplom
{
    partial class MainArchivistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.archiveDataSet = new NormDiplom.ArchiveDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.archiveDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new NormDiplom.ArchiveDataSetTableAdapters.AuthorTableAdapter();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new NormDiplom.ArchiveDataSetTableAdapters.BookTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Заголовок = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scypher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_Sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disciplines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishinghouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scypherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorSignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AuthorID,
            this.Заголовок,
            this.PublisherID,
            this.Year,
            this.Pages,
            this.ISBN,
            this.Price,
            this.Scypher,
            this.Author_Sign,
            this.Disciplines,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorIDDataGridViewTextBoxColumn,
            this.publisherIDDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.pagesDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.publishinghouseDataGridViewTextBoxColumn,
            this.scypherDataGridViewTextBoxColumn,
            this.authorSignDataGridViewTextBoxColumn,
            this.disciplinesDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataMember = "Book";
            this.bookBindingSource1.DataSource = this.archiveDataSet;
            // 
            // archiveDataSet
            // 
            this.archiveDataSet.DataSetName = "ArchiveDataSet";
            this.archiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить книгу";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Поиск";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(572, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Сортировка";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(572, 265);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(605, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 48);
            this.button3.TabIndex = 6;
            this.button3.Text = "Создать отчет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // archiveDataSetBindingSource
            // 
            this.archiveDataSetBindingSource.DataSource = this.archiveDataSet;
            this.archiveDataSetBindingSource.Position = 0;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.archiveDataSetBindingSource;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.archiveDataSetBindingSource;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(605, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Открыть список читателей";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // AuthorID
            // 
            this.AuthorID.DataPropertyName = "AuthorID";
            this.AuthorID.HeaderText = "Автор";
            this.AuthorID.Name = "AuthorID";
            // 
            // Заголовок
            // 
            this.Заголовок.DataPropertyName = "Name";
            this.Заголовок.HeaderText = "Заголовок";
            this.Заголовок.Name = "Заголовок";
            // 
            // PublisherID
            // 
            this.PublisherID.DataPropertyName = "PublisherID";
            this.PublisherID.HeaderText = "Издатель";
            this.PublisherID.Name = "PublisherID";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Год создания";
            this.Year.Name = "Year";
            // 
            // Pages
            // 
            this.Pages.DataPropertyName = "Pages";
            this.Pages.HeaderText = "Страницы";
            this.Pages.Name = "Pages";
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "Код ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // Scypher
            // 
            this.Scypher.DataPropertyName = "Scypher";
            this.Scypher.HeaderText = "Шифр";
            this.Scypher.Name = "Scypher";
            // 
            // Author_Sign
            // 
            this.Author_Sign.DataPropertyName = "Author_Sign";
            this.Author_Sign.HeaderText = "Авторский знак";
            this.Author_Sign.Name = "Author_Sign";
            // 
            // Disciplines
            // 
            this.Disciplines.DataPropertyName = "Disciplines";
            this.Disciplines.HeaderText = "Предмет/жанр";
            this.Disciplines.Name = "Disciplines";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            // 
            // publisherIDDataGridViewTextBoxColumn
            // 
            this.publisherIDDataGridViewTextBoxColumn.DataPropertyName = "PublisherID";
            this.publisherIDDataGridViewTextBoxColumn.HeaderText = "PublisherID";
            this.publisherIDDataGridViewTextBoxColumn.Name = "publisherIDDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // publishinghouseDataGridViewTextBoxColumn
            // 
            this.publishinghouseDataGridViewTextBoxColumn.DataPropertyName = "Publishing_house";
            this.publishinghouseDataGridViewTextBoxColumn.HeaderText = "Publishing_house";
            this.publishinghouseDataGridViewTextBoxColumn.Name = "publishinghouseDataGridViewTextBoxColumn";
            // 
            // scypherDataGridViewTextBoxColumn
            // 
            this.scypherDataGridViewTextBoxColumn.DataPropertyName = "Scypher";
            this.scypherDataGridViewTextBoxColumn.HeaderText = "Scypher";
            this.scypherDataGridViewTextBoxColumn.Name = "scypherDataGridViewTextBoxColumn";
            // 
            // authorSignDataGridViewTextBoxColumn
            // 
            this.authorSignDataGridViewTextBoxColumn.DataPropertyName = "Author_Sign";
            this.authorSignDataGridViewTextBoxColumn.HeaderText = "Author_Sign";
            this.authorSignDataGridViewTextBoxColumn.Name = "authorSignDataGridViewTextBoxColumn";
            // 
            // disciplinesDataGridViewTextBoxColumn
            // 
            this.disciplinesDataGridViewTextBoxColumn.DataPropertyName = "Disciplines";
            this.disciplinesDataGridViewTextBoxColumn.HeaderText = "Disciplines";
            this.disciplinesDataGridViewTextBoxColumn.Name = "disciplinesDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // MainArchivistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainArchivistForm";
            this.Text = "MainArchivistForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource archiveDataSetBindingSource;
        private ArchiveDataSet archiveDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private ArchiveDataSetTableAdapters.AuthorTableAdapter authorTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private ArchiveDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Заголовок;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scypher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_Sign;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disciplines;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishinghouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scypherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorSignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
    }
}