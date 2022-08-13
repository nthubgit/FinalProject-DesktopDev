using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_DesktopDev.Business;
using FinalProject_DesktopDev.GUI;
using FinalProject_DesktopDev.Data_Access;

namespace FinalProject_DesktopDev.GUI
{
    public partial class FormMainMenu : Form
    {
        public User loggedUser = new User();
        
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

                DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
               Application.Exit();
            }
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + loggedUser.Username + "!", "Login succeeded");
            var roleAccess = loggedUser.Role;

            switch (roleAccess)
            {
                case 0:
                    {
                        buttonUserManagement.Enabled = true;
                        buttonEmployeeManagement.Enabled = true;
                        buttonUserManagement.BackColor = Color.LightGreen;
                        buttonEmployeeManagement.BackColor = Color.LightGreen;
                        break;
                    }
                case 1:
                    {
                        buttonClientManagement.Enabled = true;
                        buttonClientManagement.BackColor = Color.LightGreen;
                        break;
                    }
                case 2:
                    {
                        buttonInventoryManagement.Enabled = true;
                        buttonInventoryManagement.BackColor = Color.LightGreen;
                        break;
                    }
                case 3:
                    {
                        buttonOrderManagement.Enabled = true;
                        buttonOrderManagement.BackColor = Color.LightGreen;
                        break;
                    }
                default:
                    buttonUserManagement.Enabled = true;
                    buttonEmployeeManagement.Enabled = true;
                    buttonClientManagement.Enabled = true;
                    buttonInventoryManagement.Enabled = true;
                    buttonOrderManagement.Enabled = true;
                    break;
            }
        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            FormUserManagement oForm = new FormUserManagement();
            oForm.ShowDialog();
        }

        private void buttonEmployeeManagement_Click(object sender, EventArgs e)
        {
            FormEmployeeManagement oForm = new FormEmployeeManagement();
            oForm.ShowDialog();
        }

        private void buttonClientManagement_Click(object sender, EventArgs e)
        {
            FormClientManagement oForm = new FormClientManagement();
            oForm.ShowDialog();
        }

        private void buttonInventoryManagement_Click(object sender, EventArgs e)
        {
            FormInventoryManagement oForm = new FormInventoryManagement();
            oForm.ShowDialog();
        }

        private void buttonOrderManagement_Click(object sender, EventArgs e)
        {
            FormOrderManagement oForm = new FormOrderManagement();
            oForm.ShowDialog();
        }
    }
}
