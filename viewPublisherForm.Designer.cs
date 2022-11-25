
namespace LibraryProjectWithDB
{
    partial class viewPublisherForm
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
            this.lIBDATABASEDataSet8 = new LibraryProjectWithDB.LIBDATABASEDataSet8();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTableAdapter = new LibraryProjectWithDB.LIBDATABASEDataSet8TableAdapters.PublisherTableAdapter();
            this.publisherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisherIDDataGridViewTextBoxColumn,
            this.publisherNameDataGridViewTextBoxColumn,
            this.publisherAdressDataGridViewTextBoxColumn,
            this.publisherEmailDataGridViewTextBoxColumn,
            this.publisherPhoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.publisherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 452);
            this.dataGridView1.TabIndex = 18;
            // 
            // lIBDATABASEDataSet8
            // 
            this.lIBDATABASEDataSet8.DataSetName = "LIBDATABASEDataSet8";
            this.lIBDATABASEDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.lIBDATABASEDataSet8;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // publisherIDDataGridViewTextBoxColumn
            // 
            this.publisherIDDataGridViewTextBoxColumn.DataPropertyName = "Publisher_ID";
            this.publisherIDDataGridViewTextBoxColumn.HeaderText = "Publisher_ID";
            this.publisherIDDataGridViewTextBoxColumn.Name = "publisherIDDataGridViewTextBoxColumn";
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            this.publisherNameDataGridViewTextBoxColumn.DataPropertyName = "Publisher_Name";
            this.publisherNameDataGridViewTextBoxColumn.HeaderText = "Publisher_Name";
            this.publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            // 
            // publisherAdressDataGridViewTextBoxColumn
            // 
            this.publisherAdressDataGridViewTextBoxColumn.DataPropertyName = "Publisher_Adress";
            this.publisherAdressDataGridViewTextBoxColumn.HeaderText = "Publisher_Adress";
            this.publisherAdressDataGridViewTextBoxColumn.Name = "publisherAdressDataGridViewTextBoxColumn";
            // 
            // publisherEmailDataGridViewTextBoxColumn
            // 
            this.publisherEmailDataGridViewTextBoxColumn.DataPropertyName = "Publisher_Email";
            this.publisherEmailDataGridViewTextBoxColumn.HeaderText = "Publisher_Email";
            this.publisherEmailDataGridViewTextBoxColumn.Name = "publisherEmailDataGridViewTextBoxColumn";
            // 
            // publisherPhoneNumberDataGridViewTextBoxColumn
            // 
            this.publisherPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Publisher_Phone_Number";
            this.publisherPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Publisher_Phone_Number";
            this.publisherPhoneNumberDataGridViewTextBoxColumn.Name = "publisherPhoneNumberDataGridViewTextBoxColumn";
            // 
            // viewPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(665, 476);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewPublisherForm";
            this.Text = "viewPublisherForm";
            this.Load += new System.EventHandler(this.viewPublisherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LIBDATABASEDataSet8 lIBDATABASEDataSet8;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private LIBDATABASEDataSet8TableAdapters.PublisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherPhoneNumberDataGridViewTextBoxColumn;
    }
}