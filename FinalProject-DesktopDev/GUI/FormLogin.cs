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
using FinalProject_DesktopDev.Data_Access;

namespace FinalProject_DesktopDev.GUI
{
    public partial class FormLogin : Form
    {
        User user = new User();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            user.Username = textBoxUsername.Text;
            user.Password = textBoxPassword.Text;
            User authenthication = UserDA.Login(user);

            if (authenthication != null)
            {
                this.Hide();
                FormMainMenu oForm = new FormMainMenu();
                oForm.loggedUser = authenthication;
                oForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Failed");
            }
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

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For superuser (has access to all menus), press Login without entering any credentials." + "\n"
                + "To access MIS Manager, enter admin|password." + "\n"
                + "For other credentials, see the User Management menu.", "Hint");
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
