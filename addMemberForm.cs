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
    public partial class addMemberForm : Form
    {
        SqlConnection connectionOne = new SqlConnection(@"Data Source=DESKTOP-65NBRKQ;Initial Catalog=LIBDATABASE;Integrated Security=True");
        public addMemberForm()
        {
            InitializeComponent();
        }

        private void addMemberForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBDATABASEDataSet1.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.lIBDATABASEDataSet1.Member);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            connectionOne.Open();
            SqlCommand addMemberCommand = connectionOne.CreateCommand();
            addMemberCommand.CommandType = CommandType.Text;
            addMemberCommand.CommandText = "INSERT INTO Member (Member_ID,First_Name,Last_Name,Date_Joined,Adress,Phone,Email,Member_Status) VALUES ('" + textBoxMemberID.Text + "','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxDateJoined.Text + "','" + textBoxAdress.Text + "','" + textBoxPhone.Text + "','"+textBoxEmail+"','"+textBoxMemberStatus+"')";
            addMemberCommand.ExecuteNonQuery();
            connectionOne.Close();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "First Name";

        }
    }
}
