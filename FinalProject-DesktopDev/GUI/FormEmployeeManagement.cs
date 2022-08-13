using FinalProject_DesktopDev.Business;
using FinalProject_DesktopDev.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_DesktopDev.GUI
{
    public partial class FormEmployeeManagement : Form
    {
        List<Employee> employees = new List<Employee>();
        Employee employee = new Employee();
        public FormEmployeeManagement()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Fields have been left blank, please fill before continuing.", "Failed");
            }
            else
            {
                employee.FirstName = textBoxFirstName.Text;
                employee.LastName = textBoxLastName.Text;
                employee.Email = textBoxEmail.Text;
                EmployeeDA.Register(employee);
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            employees = EmployeeDA.ListEmployees();
            var allPrograms = (from element in employees
                               select element);

            dataGridViewResult.DataSource = allPrograms.ToList();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int choice = comboBoxSearch.SelectedIndex;
            if (textBoxSearch.Text == "")
            {
                MessageBox.Show("Missing query.", "Failed");

            }
            else
            {
                switch (choice)
                {
                    case -1: // IF the Employee NOT select any search option

                        MessageBox.Show("Please select at least one Search Option");
                        break;

                    case 0: //FirstName
                    case 1: //LastName
                    case 2: //Email
                        {
                            employees = EmployeeDA.Search(textBoxSearch.Text, choice);

                            if (employees != null)
                            {
                                var results = (from element in employees
                                               select element);

                                dataGridViewResult.DataSource = results.ToList();
                            }
                            else
                            {
                                MessageBox.Show("Employee not found!");
                            }
                            break;
                        }

                    default:   // IF the Employee NOT select an option on the  search combo box
                        break;
                }
            }
        }
    }
}
