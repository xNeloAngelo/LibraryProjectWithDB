
namespace LibraryProjectWithDB
{
    partial class addPublisherForm
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
            this.textBoxPublisherEmail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPublisherAdress = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPublisherName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.textBoxPublisherID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddPublisher = new System.Windows.Forms.Button();
            this.lIBDATABASEDataSet7 = new LibraryProjectWithDB.LIBDATABASEDataSet7();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTableAdapter = new LibraryProjectWithDB.LIBDATABASEDataSet7TableAdapters.PublisherTableAdapter();
            this.publisherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(433, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 2);
            this.panel5.TabIndex = 28;
            // 
            // textBoxPublisherEmail
            // 
            this.textBoxPublisherEmail.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxPublisherEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPublisherEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisherEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPublisherEmail.Location = new System.Drawing.Point(433, 20);
            this.textBoxPublisherEmail.Name = "textBoxPublisherEmail";
            this.textBoxPublisherEmail.Size = new System.Drawing.Size(220, 19);
            this.textBoxPublisherEmail.TabIndex = 26;
            this.textBoxPublisherEmail.Text = "Publisher E-mail";
            this.textBoxPublisherEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(433, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 2);
            this.panel4.TabIndex = 27;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(433, 56);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(220, 19);
            this.textBoxPhoneNumber.TabIndex = 22;
            this.textBoxPhoneNumber.Text = "Phone Number";
            this.textBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(228, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 2);
            this.panel3.TabIndex = 29;
            // 
            // textBoxPublisherAdress
            // 
            this.textBoxPublisherAdress.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxPublisherAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPublisherAdress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisherAdress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPublisherAdress.Location = new System.Drawing.Point(228, 97);
            this.textBoxPublisherAdress.Name = "textBoxPublisherAdress";
            this.textBoxPublisherAdress.Size = new System.Drawing.Size(220, 19);
            this.textBoxPublisherAdress.TabIndex = 21;
            this.textBoxPublisherAdress.Text = "Publisher Adress";
            this.textBoxPublisherAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 2);
            this.panel2.TabIndex = 30;
            // 
            // textBoxPublisherName
            // 
            this.textBoxPublisherName.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxPublisherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPublisherName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisherName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPublisherName.Location = new System.Drawing.Point(12, 56);
            this.textBoxPublisherName.Name = "textBoxPublisherName";
            this.textBoxPublisherName.Size = new System.Drawing.Size(220, 19);
            this.textBoxPublisherName.TabIndex = 20;
            this.textBoxPublisherName.Text = "Publisher Name";
            this.textBoxPublisherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 2);
            this.panel1.TabIndex = 19;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFields.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClearFields.Location = new System.Drawing.Point(271, 20);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(121, 63);
            this.buttonClearFields.TabIndex = 18;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            // 
            // textBoxPublisherID
            // 
            this.textBoxPublisherID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxPublisherID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPublisherID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisherID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPublisherID.Location = new System.Drawing.Point(12, 20);
            this.textBoxPublisherID.Name = "textBoxPublisherID";
            this.textBoxPublisherID.Size = new System.Drawing.Size(220, 19);
            this.textBoxPublisherID.TabIndex = 17;
            this.textBoxPublisherID.Text = "Publisher ID";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 258);
            this.dataGridView1.TabIndex = 16;
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPublisher.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPublisher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddPublisher.Location = new System.Drawing.Point(182, 420);
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Size = new System.Drawing.Size(310, 36);
            this.buttonAddPublisher.TabIndex = 15;
            this.buttonAddPublisher.Text = "Add Publisher";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.buttonAddPublisher_Click);
            // 
            // lIBDATABASEDataSet7
            // 
            this.lIBDATABASEDataSet7.DataSetName = "LIBDATABASEDataSet7";
            this.lIBDATABASEDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.lIBDATABASEDataSet7;
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
            // addPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(665, 476);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxPublisherEmail);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxPublisherAdress);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxPublisherName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.textBoxPublisherID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddPublisher);
            this.Name = "addPublisherForm";
            this.Text = "addPublisherForm";
            this.Load += new System.EventHandler(this.addPublisherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxPublisherEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxPublisherAdress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPublisherName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.TextBox textBoxPublisherID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddPublisher;
        private LIBDATABASEDataSet7 lIBDATABASEDataSet7;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private LIBDATABASEDataSet7TableAdapters.PublisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherPhoneNumberDataGridViewTextBoxColumn;
    }
}