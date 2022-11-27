
namespace LibraryProjectWithDB
{
    partial class removeMemberForm
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
            this.textBoxMemberID = new System.Windows.Forms.TextBox();
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
            this.lIBDATABASEDataSet3 = new LibraryProjectWithDB.LIBDATABASEDataSet3();
            this.buttonRemoveMember = new System.Windows.Forms.Button();
            this.memberTableAdapter = new LibraryProjectWithDB.LIBDATABASEDataSet3TableAdapters.MemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(229, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 2);
            this.panel5.TabIndex = 29;
            // 
            // textBoxMemberID
            // 
            this.textBoxMemberID.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxMemberID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMemberID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemberID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMemberID.Location = new System.Drawing.Point(229, 31);
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.Size = new System.Drawing.Size(220, 19);
            this.textBoxMemberID.TabIndex = 24;
            this.textBoxMemberID.Text = "ID";
            this.textBoxMemberID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 348);
            this.dataGridView1.TabIndex = 16;
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
            this.memberBindingSource.DataSource = this.lIBDATABASEDataSet3;
            // 
            // lIBDATABASEDataSet3
            // 
            this.lIBDATABASEDataSet3.DataSetName = "LIBDATABASEDataSet3";
            this.lIBDATABASEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonRemoveMember
            // 
            this.buttonRemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveMember.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRemoveMember.Location = new System.Drawing.Point(180, 74);
            this.buttonRemoveMember.Name = "buttonRemoveMember";
            this.buttonRemoveMember.Size = new System.Drawing.Size(310, 36);
            this.buttonRemoveMember.TabIndex = 15;
            this.buttonRemoveMember.Text = "Remove Member";
            this.buttonRemoveMember.UseVisualStyleBackColor = true;
            this.buttonRemoveMember.Click += new System.EventHandler(this.buttonRemoveMember_Click);
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // removeMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(665, 476);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxMemberID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRemoveMember);
            this.Name = "removeMemberForm";
            this.Text = "removeMemberForm";
            this.Load += new System.EventHandler(this.removeMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBDATABASEDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxMemberID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRemoveMember;
        private LIBDATABASEDataSet3 lIBDATABASEDataSet3;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private LIBDATABASEDataSet3TableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateJoinedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberStatusDataGridViewTextBoxColumn;
    }
}