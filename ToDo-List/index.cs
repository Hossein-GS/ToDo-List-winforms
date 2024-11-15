using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
            InitializePasswordTextBox();
        }

        private void InitializePasswordTextBox()
        {
            textBox2.PasswordChar = '*'; // Set the password character to '*'
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter username & password.");
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                // Close the current form
                this.Hide();

                // Open the new form
                myTask taskForm = new myTask();
                taskForm.ShowDialog();

                // Close the login form after the new form is closed
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
