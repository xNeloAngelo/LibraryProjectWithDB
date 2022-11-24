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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Open conection with DB
        SqlConnection connectionOne = new SqlConnection(@"Data Source=DESKTOP-65NBRKQ;Initial Catalog=LIBDATABASE;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Do not delete this, program will not work....No text box is in the Form1
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String username, password;


            try
            {
                String querry = "SELECT * FROM LibTable WHERE Username ='"+textBoxUsername.Text+"' AND Password ='"+textBoxPassword.Text+"'";
                //Sets up querry string to be used in with the opened connection
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, connectionOne);
                //Makes variable that represents one specific table
                DataTable table = new DataTable();
                //Adds or refreshes rows in a table...we use it for refreshing...
                sqlDataAdapter.Fill(table);
                //checking if the table we are using for login is empty....
                if(table.Rows.Count>0)
                {
                    //finds a match in the Databes
                    username = textBoxUsername.Text;
                    password = textBoxPassword.Text;

                    //Open new form, hide this one
                    MainFormLibrary mainForm = new MainFormLibrary();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    //no match found 
                    MessageBox.Show("No match found, please enter your username and password again!");
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                }
            }
            catch
            {
                
            }
            finally
            {
                //close connection just in case
                connectionOne.Close();
               
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm nextForm = new RegisterForm();
            nextForm.Show();
            this.Hide();
        }
    }
}
