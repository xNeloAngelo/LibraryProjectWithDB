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
    public partial class addBookForm : Form
    {
        public addBookForm()
        {
            InitializeComponent();
        }

        SqlConnection connectionOne = new SqlConnection(@"Data Source=DESKTOP-65NBRKQ;Initial Catalog=LIBDATABASE;Integrated Security=True");
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            connectionOne.Open();
            SqlCommand addMemberCommand = connectionOne.CreateCommand();
            addMemberCommand.CommandType = CommandType.Text;
            addMemberCommand.CommandText = "INSERT INTO Book (Book_ID,Book_Name,Publisher_ID,Category_ID,Author,Year_Published,Remarks) VALUES ('"+textBoxBookID.Text+"','"+textBoxBookName.Text+"','"+textBoxPublisherID.Text+"','"+textBoxCategoryID.Text+"','"+textBoxAuthorName.Text+"','"+textBoxYearPublished.Text+"','"+textBoxRemarks.Text+"')";
            addMemberCommand.ExecuteNonQuery();
            connectionOne.Close();
        }

        private void addBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBDATABASEDataSet5.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.lIBDATABASEDataSet5.Book);

        }
    }
}
