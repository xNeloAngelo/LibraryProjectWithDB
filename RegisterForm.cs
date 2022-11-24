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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        SqlConnection connectionOne = new SqlConnection(@"Data Source=DESKTOP-65NBRKQ;Initial Catalog=LIBDATABASE;Integrated Security=True");

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 goBack = new Form1();
            goBack.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            connectionOne.Open();
            SqlCommand insertCommand = connectionOne.CreateCommand();
            insertCommand.CommandType = CommandType.Text;
            insertCommand.CommandText = "INSERT INTO LibTable (ID,First_Name,Last_Name,Username,Email,Password) VALUES ('"+textBoxID.Text+"','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxUsername.Text + "','" + textBoxEmail.Text + "','" + textBoxPassword.Text +"')";
            insertCommand.ExecuteNonQuery();
            connectionOne.Close();
        }
    }
}
