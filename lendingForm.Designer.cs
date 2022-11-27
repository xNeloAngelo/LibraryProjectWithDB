
namespace LibraryProjectWithDB
{
    partial class lendingForm
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
            this.textBoxDateBorrowed = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxLibrarianID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxDueDate = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMemberID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.textBoxLendID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLendBook = new System.Windows.Forms.Button();
            this.lIBDATABASEDataSet10 = new LibraryProjectWithDB.LIBDATABASEDataSet10();
            this.lendingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendingTableAdapter = new LibraryProjectWithDB.LIBDATABASEDataSet10TableAdapters.LendingTableAdapter();
            this.lendingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBorrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Location = new System.Drawing.Point(222, 184);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 2);
            this.panel7.TabIndex = 49;
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
            this.textBoxRemarks.TabIndex = 42;
            this.textBoxRemarks.Text = "Remarks";
            this.textBoxRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(433, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 2);
            this.panel6.TabIndex = 48;
            // 
            // textBoxDateBorrowed
            // 
            this.textBoxDateBorrowed.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxDateBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDateBorrowed.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateBorrowed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxDateBorrowed.Location = new System.Drawing.Point(433, 70);
            this.textBoxDateBorrowed.Name = "textBoxDateBorrowed";
            this.textBoxDateBorrowed.Size = new System.Drawing.Size(220, 19);
            this.textBoxDateBorrowed.TabIndex = 41;
            this.textBoxDateBorrowed.Text = "Date Borrowed";
            this.textBoxDateBorrowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(433, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 2);
            this.panel5.TabIndex = 45;
            // 
            // textBoxLibrarianID
            // 
            this.textBoxLibrarianID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxLibrarianID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLibrarianID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLibrarianID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLibrarianID.Location = new System.Drawing.Point(433, 20);
            this.textBoxLibrarianID.Name = "textBoxLibrarianID";
            this.textBoxLibrarianID.Size = new System.Drawing.Size(220, 19);
            this.textBoxLibrarianID.TabIndex = 43;
            this.textBoxLibrarianID.Text = "Librarian ID";
            this.textBoxLibrarianID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(433, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 2);
            this.panel4.TabIndex = 44;
            // 
            // textBoxDueDate
            // 
            this.textBoxDueDate.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxDueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDueDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDueDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxDueDate.Location = new System.Drawing.Point(433, 116);
            this.textBoxDueDate.Name = "textBoxDueDate";
            this.textBoxDueDate.Size = new System.Drawing.Size(220, 19);
            this.textBoxDueDate.TabIndex = 40;
            this.textBoxDueDate.Text = "Due Date";
            this.textBoxDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(12, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 2);
            this.panel3.TabIndex = 46;
            // 
            // textBoxMemberID
            // 
            this.textBoxMemberID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxMemberID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMemberID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemberID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMemberID.Location = new System.Drawing.Point(12, 116);
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.Size = new System.Drawing.Size(220, 19);
            this.textBoxMemberID.TabIndex = 39;
            this.textBoxMemberID.Text = "Member ID";
            this.textBoxMemberID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(12, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 2);
            this.panel2.TabIndex = 47;
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxBookID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBookID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBookID.Location = new System.Drawing.Point(12, 70);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(220, 19);
            this.textBoxBookID.TabIndex = 38;
            this.textBoxBookID.Text = "Book ID";
            this.textBoxBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 2);
            this.panel1.TabIndex = 37;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFields.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClearFields.Location = new System.Drawing.Point(272, 80);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(121, 63);
            this.buttonClearFields.TabIndex = 36;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // textBoxLendID
            // 
            this.textBoxLendID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxLendID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLendID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLendID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLendID.Location = new System.Drawing.Point(12, 20);
            this.textBoxLendID.Name = "textBoxLendID";
            this.textBoxLendID.Size = new System.Drawing.Size(220, 19);
            this.textBoxLendID.TabIndex = 35;
            this.textBoxLendID.Text = "Lending ID";
            this.textBoxLendID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lendingIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.librarianIDDataGridViewTextBoxColumn,
            this.dateBorrowedDataGridViewTextBoxColumn,
            this.dateReturnedDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lendingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 198);
            this.dataGridView1.TabIndex = 34;
            // 
            // buttonLendBook
            // 
            this.buttonLendBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLendBook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLendBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLendBook.Location = new System.Drawing.Point(182, 420);
            this.buttonLendBook.Name = "buttonLendBook";
            this.buttonLendBook.Size = new System.Drawing.Size(310, 36);
            this.buttonLendBook.TabIndex = 33;
            this.buttonLendBook.Text = "Lend";
            this.buttonLendBook.UseVisualStyleBackColor = true;
            this.buttonLendBook.Click += new System.EventHandler(this.buttonLendBook_Click);
            // 
            // lIBDATABASEDataSet10
            // 
            this.lIBDATABASEDataSet10.DataSetName = "LIBDATABASEDataSet10";
            this.lIBDATABASEDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lendingBindingSource
            // 
            this.lendingBindingSource.DataMember = "Lending";
            this.lendingBindingSource.DataSource = this.lIBDATABASEDataSet10;
            // 
            // lendingTableAdapter
            // 
            this.lendingTableAdapter.ClearBeforeFill = true;
            // 
            // lendingIDDataGridViewTextBoxColumn
            // 
            this.lendingIDDataGridViewTextBoxColumn.DataPropertyName = "Lending_ID";
            this.lendingIDDataGridViewTextBoxColumn.HeaderText = "Lending_ID";
            this.lendingIDDataGridViewTextBoxColumn.Name = "lendingIDDataGridViewTextBoxColumn";
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            // 
            // librarianIDDataGridViewTextBoxColumn
            // 
            this.librarianIDDataGridViewTextBoxColumn.DataPropertyName = "Librarian_ID";
            this.librarianIDDataGridViewTextBoxColumn.HeaderText = "Librarian_ID";
            this.librarianIDDataGridViewTextBoxColumn.Name = "librarianIDDataGridViewTextBoxColumn";
            // 
            // dateBorrowedDataGridViewTextBoxColumn
            // 
            this.dateBorrowedDataGridViewTextBoxColumn.DataPropertyName = "Date_Borrowed";
            this.dateBorrowedDataGridViewTextBoxColumn.HeaderText = "Date_Borrowed";
            this.dateBorrowedDataGridViewTextBoxColumn.Name = "dateBorrowedDataGridViewTextBoxColumn";
            // 
            // dateReturnedDataGridViewTextBoxColumn
            // 
            this.dateReturnedDataGridViewTextBoxColumn.DataPropertyName = "Date_Returned";
            this.dateReturnedDataGridViewTextBoxColumn.HeaderText = "Date_Returned";
            this.dateReturnedDataGridViewTextBoxColumn.Name = "dateReturnedDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // lendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(665, 476);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBoxDateBorrowed);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxLibrarianID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxDueDate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxMemberID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.textBoxLendID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLendBook);
            this.Name = "lendingForm";
            this.Text = "lendingForm";
            this.Load += new System.EventHandler(this.lendingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxDateBorrowed;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxLibrarianID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxDueDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxMemberID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.TextBox textBoxLendID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLendBook;
        private LIBDATABASEDataSet10 lIBDATABASEDataSet10;
        private System.Windows.Forms.BindingSource lendingBindingSource;
        private LIBDATABASEDataSet10TableAdapters.LendingTableAdapter lendingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBorrowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}