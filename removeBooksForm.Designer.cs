
namespace LibraryProjectWithDB
{
    partial class removeBooksForm
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
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.lIBDATABASEDataSet6 = new LibraryProjectWithDB.LIBDATABASEDataSet6();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.bookTableAdapter = new LibraryProjectWithDB.LIBDATABASEDataSet6TableAdapters.BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(229, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 2);
            this.panel5.TabIndex = 34;
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxBookID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBookID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBookID.Location = new System.Drawing.Point(229, 22);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(220, 19);
            this.textBoxBookID.TabIndex = 33;
            this.textBoxBookID.Text = "ID";
            this.textBoxBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 348);
            this.dataGridView1.TabIndex = 31;
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
            this.bookBindingSource.DataSource = this.lIBDATABASEDataSet6;
            // 
            // lIBDATABASEDataSet6
            // 
            this.lIBDATABASEDataSet6.DataSetName = "LIBDATABASEDataSet6";
            this.lIBDATABASEDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveBook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRemoveBook.Location = new System.Drawing.Point(183, 65);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(310, 36);
            this.buttonRemoveBook.TabIndex = 30;
            this.buttonRemoveBook.Text = "Remove Book";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // removeBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(665, 476);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRemoveBook);
            this.Name = "removeBooksForm";
            this.Text = "removeBooksForm";
            this.Load += new System.EventHandler(this.removeBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRemoveBook;
        private LIBDATABASEDataSet6 lIBDATABASEDataSet6;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LIBDATABASEDataSet6TableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearPublishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}