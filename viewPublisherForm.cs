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
    public partial class viewPublisherForm : Form
    {
        public viewPublisherForm()
        {
            InitializeComponent();
        }

        private void viewPublisherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBDATABASEDataSet8.Publisher' table. You can move, or remove it, as needed.
            this.publisherTableAdapter.Fill(this.lIBDATABASEDataSet8.Publisher);

        }
    }
}
