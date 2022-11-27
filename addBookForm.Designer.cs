
namespace LibraryProjectWithDB
{
    partial class addBookForm
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxYearPublished = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxCategoryID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPublisherID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearPublishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIBDATABASEDataSet5 = new LibraryProjectWithDB.LIBDATABASEDataSet5();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.bookTableAdapter = new LibraryProjectWithDB.LIBDATABASEDataSet5TableAdapters.BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Location = new System.Drawing.Point(222, 184);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 2);
            this.panel7.TabIndex = 32;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRemarks.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemarks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxRemarks.Location = new System.Drawing.Point(222, 159);
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(220, 19);
            this.textBoxRemarks.TabIndex = 24;
            this.textBoxRemarks.Text = "Remarks";
            this.textBoxRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRemarks.TextChanged += new System.EventHandler(this.textBoxRemarks_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(433, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 2);
            this.panel6.TabIndex = 31;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // textBoxYearPublished
            // 
            this.textBoxYearPublished.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxYearPublished.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYearPublished.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYearPublished.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxYearPublished.Location = new System.Drawing.Point(433, 70);
            this.textBoxYearPublished.Name = "textBoxYearPublished";
            this.textBoxYearPublished.Size = new System.Drawing.Size(220, 19);
            this.textBoxYearPublished.TabIndex = 23;
            this.textBoxYearPublished.Text = "Year Published";
            this.textBoxYearPublished.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYearPublished.TextChanged += new System.EventHandler(this.textBoxYearPublished_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(433, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 2);
            this.panel5.TabIndex = 28;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAuthorName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAuthorName.Location = new System.Drawing.Point(433, 20);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(220, 19);
            this.textBoxAuthorName.TabIndex = 26;
            this.textBoxAuthorName.Text = "Author Name";
            this.textBoxAuthorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAuthorName.TextChanged += new System.EventHandler(this.textBoxAuthorName_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(433, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 2);
            this.panel4.TabIndex = 27;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // textBoxCategoryID
            // 
            this.textBoxCategoryID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCategoryID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategoryID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxCategoryID.Location = new System.Drawing.Point(433, 116);
            this.textBoxCategoryID.Name = "textBoxCategoryID";
            this.textBoxCategoryID.Size = new System.Drawing.Size(220, 19);
            this.textBoxCategoryID.TabIndex = 22;
            this.textBoxCategoryID.Text = "Category ID";
            this.textBoxCategoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCategoryID.TextChanged += new System.EventHandler(this.textBoxCategoryID_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(12, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 2);
            this.panel3.TabIndex = 29;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBoxPublisherID
            // 
            this.textBoxPublisherID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxPublisherID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPublisherID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisherID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPublisherID.Location = new System.Drawing.Point(12, 116);
            this.textBoxPublisherID.Name = "textBoxPublisherID";
            this.textBoxPublisherID.Size = new System.Drawing.Size(220, 19);
            this.textBoxPublisherID.TabIndex = 21;
            this.textBoxPublisherID.Text = "Publisher ID";
            this.textBoxPublisherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPublisherID.TextChanged += new System.EventHandler(this.textBoxPublisherID_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(12, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 2);
            this.panel2.TabIndex = 30;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBookName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBookName.Location = new System.Drawing.Point(12, 70);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(220, 19);
            this.textBoxBookName.TabIndex = 20;
            this.textBoxBookName.Text = "Book Name";
            this.textBoxBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBookName.TextChanged += new System.EventHandler(this.textBoxBookName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 2);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFields.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClearFields.Location = new System.Drawing.Point(272, 80);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(121, 63);
            this.buttonClearFields.TabIndex = 18;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxBookID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBookID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBookID.Location = new System.Drawing.Point(12, 20);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(220, 19);
            this.textBoxBookID.TabIndex = 17;
            this.textBoxBookID.Text = "ID";
            this.textBoxBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBookID.TextChanged += new System.EventHandler(this.textBoxBookID_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.publisherIDDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.yearPublishedDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 198);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // publisherIDDataGridViewTextBoxColumn
            // 
            this.publisherIDDataGridViewTextBoxColumn.DataPropertyName = "Publisher_ID";
            this.publisherIDDataGridViewTextBoxColumn.HeaderText = "Publisher_ID";
            this.publisherIDDataGridViewTextBoxColumn.Name = "publisherIDDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // yearPublishedDataGridViewTextBoxColumn
            // 
            this.yearPublishedDataGridViewTextBoxColumn.DataPropertyName = "Year_Published";
            this.yearPublishedDataGridViewTextBoxColumn.HeaderText = "Year_Published";
            this.yearPublishedDataGridViewTextBoxColumn.Name = "yearPublishedDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.lIBDATABASEDataSet5;
            // 
            // lIBDATABASEDataSet5
            // 
            this.lIBDATABASEDataSet5.DataSetName = "LIBDATABASEDataSet5";
            this.lIBDATABASEDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddBook.Location = new System.Drawing.Point(182, 420);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(310, 36);
            this.buttonAddBook.TabIndex = 15;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // addBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(665, 476);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBoxYearPublished);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxAuthorName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxCategoryID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxPublisherID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddBook);
            this.Name = "addBookForm";
            this.Text = "addBookForm";
            this.Load += new System.EventHandler(this.addBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxYearPublished;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxCategoryID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxPublisherID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddBook;
        private LIBDATABASEDataSet5 lIBDATABASEDataSet5;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LIBDATABASEDataSet5TableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearPublishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}