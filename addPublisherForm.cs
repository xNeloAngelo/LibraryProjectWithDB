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
    public partial class addPublisherForm : Form
    {
        public addPublisherForm()
        {
            InitializeComponent();
        }
        SqlConnection connectionOne = new SqlConnection(@"Data Source=DESKTOP-65NBRKQ;Initial Catalog=LIBDATABASE;Integrated Security=True");
        private void addPublisherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBDATABASEDataSet7.Publisher' table. You can move, or remove it, as needed.
            this.publisherTableAdapter.Fill(this.lIBDATABASEDataSet7.Publisher);

        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            connectionOne.Open();
            SqlCommand addPublisherCommand = connectionOne.CreateCommand();
            addPublisherCommand.CommandType = CommandType.Text;
            addPublisherCommand.CommandText = "INSERT INTO Publisher (Publisher_ID,Publisher_Name,Publisher_Adress,Publisher_Email,Publisher_Phone_Number) VALUES ('"+textBoxPublisherID.Text+"','"+textBoxPublisherName.Text+"','"+textBoxPublisherAdress.Text+"','"+textBoxPublisherEmail.Text+"','"+textBoxPhoneNumber.Text+"')";
            addPublisherCommand.ExecuteNonQuery();
            connectionOne.Close();
        }
    }
}
