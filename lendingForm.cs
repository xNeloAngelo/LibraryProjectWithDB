using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryProjectWithDB
{
    public partial class lendingForm : Form
    {
        public lendingForm()
        {
            InitializeComponent();
        }
        SqlConnection connectionOne = new SqlConnection(@"Data Source=DESKTOP-65NBRKQ;Initial Catalog=LIBDATABASE;Integrated Security=True");
        private void buttonAddBook_Click(object sender, EventArgs e)
        {

        }

        private void lendingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBDATABASEDataSet10.Lending' table. You can move, or remove it, as needed.
            this.lendingTableAdapter.Fill(this.lIBDATABASEDataSet10.Lending);

        }

        private void buttonLendBook_Click(object sender, EventArgs e)
        {
            connectionOne.Open();
            SqlCommand addMemberCommand = connectionOne.CreateCommand();
            addMemberCommand.CommandType = CommandType.Text;
            addMemberCommand.CommandText = "INSERT INTO Lending (Lending_ID,Book_ID,Member_ID,Librarian_ID,Date_Borrowed,Date_Returned,Remarks) VALUES ('" + textBoxLendID.Text + "','" + textBoxBookID.Text + "','" + textBoxMemberID.Text + "','" + textBoxLibrarianID.Text + "','" + textBoxDateBorrowed.Text + "','" + textBoxDueDate.Text + "','" + textBoxRemarks.Text + "')";
            addMemberCommand.ExecuteNonQuery();
            connectionOne.Close();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxBookID.Text = "Book ID";
            textBoxLendID.Text = "Lending ID";
            textBoxMemberID.Text = "Member ID";
            textBoxLibrarianID.Text = "Librarian ID";
            textBoxDateBorrowed.Text = "Date Borrowed";
            textBoxDueDate.Text = "Due Date";
            textBoxRemarks.Text = "Remarks";
        }
    }
}
