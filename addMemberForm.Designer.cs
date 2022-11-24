
namespace LibraryProjectWithDB
{
    partial class addMemberForm
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
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateJoinedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIBDATABASEDataSet1 = new LibraryProjectWithDB.LIBDATABASEDataSet1();
            this.lIBDATABASEDataSet = new LibraryProjectWithDB.LIBDATABASEDataSet();
            this.lIBDATABASEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new LibraryProjectWithDB.LIBDATABASEDataSet1TableAdapters.MemberTableAdapter();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxDateJoined = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxMemberID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxMemberStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMember.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddMember.Location = new System.Drawing.Point(182, 428);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(310, 36);
            this.buttonAddMember.TabIndex = 0;
            this.buttonAddMember.Text = "Add Member";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateJoinedDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.memberStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 198);
            this.dataGridView1.TabIndex = 1;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dateJoinedDataGridViewTextBoxColumn
            // 
            this.dateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date_Joined";
            this.dateJoinedDataGridViewTextBoxColumn.HeaderText = "Date_Joined";
            this.dateJoinedDataGridViewTextBoxColumn.Name = "dateJoinedDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // memberStatusDataGridViewTextBoxColumn
            // 
            this.memberStatusDataGridViewTextBoxColumn.DataPropertyName = "Member_Status";
            this.memberStatusDataGridViewTextBoxColumn.HeaderText = "Member_Status";
            this.memberStatusDataGridViewTextBoxColumn.Name = "memberStatusDataGridViewTextBoxColumn";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.lIBDATABASEDataSet1;
            // 
            // lIBDATABASEDataSet1
            // 
            this.lIBDATABASEDataSet1.DataSetName = "LIBDATABASEDataSet1";
            this.lIBDATABASEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIBDATABASEDataSet
            // 
            this.lIBDATABASEDataSet.DataSetName = "LIBDATABASEDataSet";
            this.lIBDATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIBDATABASEDataSetBindingSource
            // 
            this.lIBDATABASEDataSetBindingSource.DataSource = this.lIBDATABASEDataSet;
            this.lIBDATABASEDataSetBindingSource.Position = 0;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 28);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(220, 19);
            this.textBoxFirstName.TabIndex = 2;
            this.textBoxFirstName.Text = "First Name";
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFields.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClearFields.Location = new System.Drawing.Point(273, 28);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(121, 63);
            this.buttonClearFields.TabIndex = 10;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBack.Location = new System.Drawing.Point(273, 117);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(121, 67);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Go Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 2);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(12, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 2);
            this.panel2.TabIndex = 14;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLastName.Location = new System.Drawing.Point(12, 64);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(220, 19);
            this.textBoxLastName.TabIndex = 13;
            this.textBoxLastName.Text = "Last Name";
            this.textBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(12, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 2);
            this.panel3.TabIndex = 14;
            // 
            // textBoxDateJoined
            // 
            this.textBoxDateJoined.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxDateJoined.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDateJoined.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateJoined.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxDateJoined.Location = new System.Drawing.Point(12, 124);
            this.textBoxDateJoined.Name = "textBoxDateJoined";
            this.textBoxDateJoined.Size = new System.Drawing.Size(220, 19);
            this.textBoxDateJoined.TabIndex = 13;
            this.textBoxDateJoined.Text = "Date Joined";
            this.textBoxDateJoined.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(12, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 2);
            this.panel4.TabIndex = 14;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAdress.Location = new System.Drawing.Point(12, 157);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(220, 19);
            this.textBoxAdress.TabIndex = 13;
            this.textBoxAdress.Text = "Adress";
            this.textBoxAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(433, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 2);
            this.panel5.TabIndex = 14;
            // 
            // textBoxMemberID
            // 
            this.textBoxMemberID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxMemberID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMemberID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemberID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMemberID.Location = new System.Drawing.Point(433, 28);
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.Size = new System.Drawing.Size(220, 19);
            this.textBoxMemberID.TabIndex = 13;
            this.textBoxMemberID.Text = "ID";
            this.textBoxMemberID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(433, 89);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 2);
            this.panel6.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPhone.Location = new System.Drawing.Point(433, 64);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(220, 19);
            this.textBoxPhone.TabIndex = 13;
            this.textBoxPhone.Text = "Phone";
            this.textBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Location = new System.Drawing.Point(433, 149);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 2);
            this.panel7.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmail.Location = new System.Drawing.Point(433, 124);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(220, 19);
            this.textBoxEmail.TabIndex = 13;
            this.textBoxEmail.Text = "E-Mail";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Location = new System.Drawing.Point(433, 182);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(220, 2);
            this.panel8.TabIndex = 14;
            // 
            // textBoxMemberStatus
            // 
            this.textBoxMemberStatus.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxMemberStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMemberStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemberStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMemberStatus.Location = new System.Drawing.Point(433, 157);
            this.textBoxMemberStatus.Name = "textBoxMemberStatus";
            this.textBoxMemberStatus.Size = new System.Drawing.Size(220, 19);
            this.textBoxMemberStatus.TabIndex = 13;
            this.textBoxMemberStatus.Text = "Membership Status";
            this.textBoxMemberStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(665, 476);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.textBoxMemberStatus);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxMemberID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBoxDateJoined);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddMember);
            this.Name = "addMemberForm";
            this.Text = "addMemberForm";
            this.Load += new System.EventHandler(this.addMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lIBDATABASEDataSetBindingSource;
        private LIBDATABASEDataSet lIBDATABASEDataSet;
        private LIBDATABASEDataSet1 lIBDATABASEDataSet1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private LIBDATABASEDataSet1TableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateJoinedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxDateJoined;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxMemberID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxMemberStatus;
    }
}