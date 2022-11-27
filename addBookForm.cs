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

        private void textBoxRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxYearPublished_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxAuthorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxCategoryID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPublisherID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxBookID.Text = "ID";
            textBoxBookName.Text = "Book Name";
            textBoxCategoryID.Text = "Category ID";
            textBoxPublisherID.Text = "Publisher ID";
            textBoxAuthorName.Text = "Author Name";
            textBoxYearPublished.Text = "Year Published";
            textBoxRemarks.Text = "Remarks";

        }

        private void textBoxBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
