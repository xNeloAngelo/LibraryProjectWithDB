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
    public partial class removeBooksForm : Form
    {
        public removeBooksForm()
        {
            InitializeComponent();
        }
        SqlConnection connectionOne = new SqlConnection(@"Data Source=DESKTOP-65NBRKQ;Initial Catalog=LIBDATABASE;Integrated Security=True");
        private void removeBooksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBDATABASEDataSet6.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.lIBDATABASEDataSet6.Book);

        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            connectionOne.Open();

            try
            {
                String deleteBookQuerry = "DELETE FROM Book WHERE Book_ID = '" + textBoxBookID.Text + "'";

                SqlCommand deleteBookCommand = new SqlCommand(deleteBookQuerry, connectionOne);

                if (deleteBookCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Book Removed");
                }
                else
                {
                    MessageBox.Show("Unable to remove user, check if ID exist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connectionOne.Close();
        }
    }
}
