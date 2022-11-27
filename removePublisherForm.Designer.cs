
namespace LibraryProjectWithDB
{
    partial class removePublisherForm
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
            this.textBoxPublisherID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.publisherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIBDATABASEDataSet9 = new LibraryProjectWithDB.LIBDATABASEDataSet9();
            this.buttonRemovePublisher = new System.Windows.Forms.Button();
            this.publisherTableAdapter = new LibraryProjectWithDB.LIBDATABASEDataSet9TableAdapters.PublisherTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(229, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 2);
            this.panel5.TabIndex = 39;
            // 
            // textBoxPublisherID
            // 
            this.textBoxPublisherID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxPublisherID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPublisherID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisherID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPublisherID.Location = new System.Drawing.Point(229, 22);
            this.textBoxPublisherID.Name = "textBoxPublisherID";
            this.textBoxPublisherID.Size = new System.Drawing.Size(220, 19);
            this.textBoxPublisherID.TabIndex = 38;
            this.textBoxPublisherID.Text = "ID";
            this.textBoxPublisherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 348);
            this.dataGridView1.TabIndex = 36;
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
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.lIBDATABASEDataSet9;
            // 
            // lIBDATABASEDataSet9
            // 
            this.lIBDATABASEDataSet9.DataSetName = "LIBDATABASEDataSet9";
            this.lIBDATABASEDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonRemovePublisher
            // 
            this.buttonRemovePublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemovePublisher.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemovePublisher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRemovePublisher.Location = new System.Drawing.Point(187, 65);
            this.buttonRemovePublisher.Name = "buttonRemovePublisher";
            this.buttonRemovePublisher.Size = new System.Drawing.Size(310, 36);
            this.buttonRemovePublisher.TabIndex = 35;
            this.buttonRemovePublisher.Text = "Remove Publisher";
            this.buttonRemovePublisher.UseVisualStyleBackColor = true;
            this.buttonRemovePublisher.Click += new System.EventHandler(this.buttonRemovePublisher_Click);
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // removePublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(665, 476);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxPublisherID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRemovePublisher);
            this.Name = "removePublisherForm";
            this.Text = "removePublisherForm";
            this.Load += new System.EventHandler(this.removePublisherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxPublisherID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRemovePublisher;
        private LIBDATABASEDataSet9 lIBDATABASEDataSet9;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private LIBDATABASEDataSet9TableAdapters.PublisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherPhoneNumberDataGridViewTextBoxColumn;
    }
}