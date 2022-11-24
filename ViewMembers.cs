using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectWithDB
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBDATABASEDataSet2.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.lIBDATABASEDataSet2.Member);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainFormLibrary goBack = new MainFormLibrary();
            this.Close();
            goBack.Show();
        }
    }
}
