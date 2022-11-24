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
    public partial class removeMemberForm : Form
    {
        public removeMemberForm()
        {
            InitializeComponent();
        }
        SqlConnection connectionOne = new SqlConnection(@"Data Source=DESKTOP-65NBRKQ;Initial Catalog=LIBDATABASE;Integrated Security=True");
        private void removeMemberForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBDATABASEDataSet3.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.lIBDATABASEDataSet3.Member);

        }

        private void buttonRemoveMember_Click(object sender, EventArgs e)
        {

            connectionOne.Open();

            try
            {
                String deleteMember = "DELETE FROM Member WHERE Member_ID = '"+textBoxMemberID.Text+"'";
                
                SqlCommand deleteMemberCommand = new SqlCommand(deleteMember, connectionOne);

                if(deleteMemberCommand.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Member Removed");
                }
                else
                {
                    MessageBox.Show("Unable to remove user, check if ID exist!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connectionOne.Close();

            
        }
    }
}
