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
    public partial class myTask : Form
    {
        public myTask()
        {
            InitializeComponent();
        }

        public string selectedTab = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                textBox1.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            } else
            {
                MessageBox.Show("Please create a new tab first.");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                // Find the CheckedListBox in the selected tab page
                CheckedListBox checkedListBox = tabControl1.SelectedTab.Controls.OfType<CheckedListBox>().FirstOrDefault();
                if (checkedListBox != null && !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Please enter a task.");
                    }
                    else
                    {
                        // Add the text from textBox1 to the CheckedListBox
                        checkedListBox.Items.Add(textBox1.Text);
                        textBox1.Text = "";
                        textBox1.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please create a new tab first.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button7.Visible = true;
            button6.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter a new tab name.");
            }
            else
            {
                // Create a new tab page with the text from textBox2

                TabPage newTabPage = new TabPage(textBox2.Text);

                CheckedListBox checkedListBox = new CheckedListBox
                {
                    Dock = DockStyle.Fill
                };

                newTabPage.Controls.Add(checkedListBox);

                tabControl1.TabPages.Add(newTabPage);

                textBox2.Text = "";
                textBox2.Visible = false;
                button7.Visible = false;
                button6.Visible = false;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Visible = false;
            button7.Visible = false;
            button6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                textBox3.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
            }
            else
            {
                MessageBox.Show("Please create a new tab first.");
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                // Find the CheckedListBox in the selected tab page
                CheckedListBox checkedListBox = tabControl1.SelectedTab.Controls.OfType<CheckedListBox>().FirstOrDefault();
                if (checkedListBox != null && checkedListBox.CheckedItems.Count > 0)
                {
                    if (checkedListBox.CheckedItems.Count > 1)
                    {
                        MessageBox.Show("Please select only one item to edit.");
                    }
                    else if (textBox3.Text == "")
                    {
                        MessageBox.Show("Please enter a new task.");
                    }
                    else
                    {
                        // Edit the checked item in the CheckedListBox
                        for (int i = 0; i < checkedListBox.Items.Count; i++)
                        {
                            if (checkedListBox.GetItemChecked(i))
                            {
                                checkedListBox.Items[i] = textBox3.Text;
                                checkedListBox.SetItemChecked(i, false);
                            }
                        }

                        textBox3.Text = "";
                        textBox3.Visible = false;
                        button9.Visible = false;
                        button10.Visible = false;

                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to edit.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                // Find the CheckedListBox in the selected tab page
                CheckedListBox checkedListBox = tabControl1.SelectedTab.Controls.OfType<CheckedListBox>().FirstOrDefault();
                if (checkedListBox != null && checkedListBox.CheckedItems.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to delete the selected items?", "Delete Items", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Remove the checked items from the CheckedListBox
                        for (int i = checkedListBox.Items.Count - 1; i >= 0; i--)
                        {
                            if (checkedListBox.GetItemChecked(i))
                            {
                                checkedListBox.Items.RemoveAt(i);
                            }
                        }
                    }
                    else
                    {
                        // Uncheck all items
                        for (int i = 0; i < checkedListBox.Items.Count; i++)
                        {
                            checkedListBox.SetItemChecked(i, false);
                        }

                    }
                }
                else if (checkedListBox.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select an item to delete.");
                } 
            }
            else
            {
                MessageBox.Show("Please create a tab first.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            else
            {
                MessageBox.Show("Please create a new tab first.");
            }
        }
    }
}
