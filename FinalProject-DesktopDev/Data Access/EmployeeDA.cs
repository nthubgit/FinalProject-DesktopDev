using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FinalProject_DesktopDev.Business;
using System.Windows.Forms;

namespace FinalProject_DesktopDev.Data_Access
{
    public static class EmployeeDA
    {
        private static string filePath = Application.StartupPath + @"\Employees.dat"; //custom path
        private static string fileTemp = Application.StartupPath + @"\Temp.dat"; //custom path for temp dat, used for better updating (replacing)/deleting

        public static void Register(Employee employee)
        {
            //fix later to check for unique FirstNames

            List<Employee> listS = new List<Employee>();
            ///check to see if exists - TBA
            StreamWriter sWriter = new StreamWriter(filePath, true); //true used to append
            sWriter.WriteLine(employee.FirstName + "," + employee.LastName + "," + employee.Email);
            sWriter.Close();
            MessageBox.Show("Registration complete.");
        }
        public static List<Employee> Search(string text, int choice) //Search for FirstName
        {
            List<Employee> listS = new List<Employee>();
            bool found = false;
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                Employee employee = new Employee();
                string[] fields = line.Split(',');

                switch (choice)
                {
                    case 0: //firstname
                        {
                            if (text == (fields[0]))
                            {
                                employee.FirstName = fields[0];
                                employee.LastName = fields[1];
                                employee.Email = fields[2];
                                listS.Add(employee);
                                found = true;
                            }
                            line = sReader.ReadLine();

                            break;
                        }
                    case 1: //lastname
                        {
                            if (text == (fields[1]))
                            {
                                employee.FirstName = fields[0];
                                employee.LastName = fields[1];
                                employee.Email = fields[2];
                                listS.Add(employee);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    case 2: //email
                        {
                            if (text == (fields[2]))
                            {
                                employee.FirstName = fields[0];
                                employee.LastName = fields[1];
                                employee.Email = fields[2];
                                listS.Add(employee);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    default:
                        break;
                }

            }
            if (found == false)
            {
                sReader.Close();
                return null;
            }
            else
            {
                sReader.Close();
                return listS;
            }
        }

        public static List<Employee> ListEmployees()
        {
            List<Employee> listS = new List<Employee>();
            ///check to see if exists - TBA
            StreamReader sReader = new StreamReader(filePath);

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Employee allEmployee = new Employee();
                allEmployee.FirstName = fields[0];
                allEmployee.LastName = (fields[1]);
                allEmployee.Email = (fields[2]);
                listS.Add(allEmployee);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listS;
        }
    }
}
