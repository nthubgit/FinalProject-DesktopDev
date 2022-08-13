using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_DesktopDev.Business;
using FinalProject_DesktopDev.Data_Access;

namespace FinalProject_DesktopDev.GUI
{
    public partial class FormUserManagement : Form
    {
        List <User> users = new List<User> ();
        User user = new User();
        public FormUserManagement()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || comboBoxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Fields have been left blank, please fill before continuing.");
            }
            else
            {
                user.Username = textBoxUsername.Text;
                user.Password = textBoxPassword.Text;
                user.Role = comboBoxRole.SelectedIndex;
                UserDA.Register(user);
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int choice = comboBoxSearch.SelectedIndex;
            if (textBoxSearch.Text == "")
            {
                MessageBox.Show("Missing query.", "Failed");
    
            }
            else { 
                switch (choice)
                {
                    case -1: // IF the user NOT select any search option

                        MessageBox.Show("Please select at least one Search Option");
                        break;

                    case 0: //Username
                        {
                            users = UserDA.Search(textBoxSearch.Text, choice);

                            if (users != null)
                            {
                                var results = (from element in users
                                               select element);

                                dataGridViewResult.DataSource = results.ToList();
                            }
                            else
                            {
                                MessageBox.Show("User not found!");
                            }
                            break;
                        }
                    case 1: //Role (0,1,2,3)
                        {
                            users = UserDA.Search(Convert.ToInt32(textBoxSearch.Text), choice);

                            if (users != null)
                            {
                                var results = (from element in users
                                               select element);

                                dataGridViewResult.DataSource = results.ToList();
                            }
                            else
                            {
                                MessageBox.Show("User not found!");
                            }
                            break;
                        }

                    default:   // IF the user NOT select an option on the  search combo box
                        break;
                }
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            users = UserDA.ListUsers();
            var allPrograms = (from element in users
                               select element);

            dataGridViewResult.DataSource = allPrograms.ToList();

        }
    }
}
