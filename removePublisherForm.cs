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
    public partial class removePublisherForm : Form
    {
        SqlConnection connectionOne = new SqlConnection(@"Data Source=DESKTOP-65NBRKQ;Initial Catalog=LIBDATABASE;Integrated Security=True");
        public removePublisherForm()
        {
            InitializeComponent();
        }

        private void removePublisherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBDATABASEDataSet9.Publisher' table. You can move, or remove it, as needed.
            this.publisherTableAdapter.Fill(this.lIBDATABASEDataSet9.Publisher);

        }

        private void buttonRemovePublisher_Click(object sender, EventArgs e)
        {
            connectionOne.Open();

            try
            {
                String deletePublisherQuerry = "DELETE FROM Publisher WHERE Publisher_ID = '" + textBoxPublisherID.Text + "'";

                SqlCommand deletePublisherCommand = new SqlCommand(deletePublisherQuerry, connectionOne);

                if (deletePublisherCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Publisher Removed");
                }
                else
                {
                    MessageBox.Show("Unable to remove publisher, check if ID exists!");
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
