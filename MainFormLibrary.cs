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
    public partial class MainFormLibrary : Form
    {
        private Form currentChildForm;

        public MainFormLibrary()
        {
            InitializeComponent();
        }
        SqlConnection connectionOne = new SqlConnection(@"Data Source=DESKTOP-65NBRKQ;Initial Catalog=LIBDATABASE;Integrated Security=True");

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            //Connection Close
            System.Environment.Exit(1);
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form1 logOut = new Form1();
            logOut.Show();
            this.Close();
            //Connection close
        }

        private void buttonLending_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new addMemberForm());
        }
        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainFormLibrary.Controls.Add(childForm);
            panelMainFormLibrary.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void buttonListMembers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewMembers());
        }

        private void buttonRemoveMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new removeMemberForm());
        }
    }
}
