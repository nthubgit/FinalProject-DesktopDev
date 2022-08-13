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
    public static class UserDA
    {
        private static string filePath = Application.StartupPath + @"\Users.dat"; //custom path
        private static string fileTemp = Application.StartupPath + @"\Temp.dat"; //custom path for temp dat, used for better updating (replacing)/deleting


        public static void Register(User user)
        {

            List<User> listS = new List<User>();
            ///check to see if exists - TBA
            StreamReader sReader = new StreamReader(filePath);
            bool dupe = false;
            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                User allUser = new User();
                if (user.Username == fields[0])
                {
                    dupe = true;
                    break;
                }
                else { 
                line = sReader.ReadLine();
                }
            }
            sReader.Close();
            if (!dupe) { 
            StreamWriter sWriter = new StreamWriter(filePath, true); //true used to append
            sWriter.WriteLine(user.Username + "," + user.Password + "," + user.Role);
            sWriter.Close();
            MessageBox.Show("Registration complete.");
            }
            else
            {
                MessageBox.Show("Duplicate username found. Please pick another username.", "Failed");
            }
        }
        public static List<User> Search(string text, int choice) //Search for username
        {
            List<User> listS = new List<User>();
            bool found = false;
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                User user = new User();
                string[] fields = line.Split(',');
                if (text == (fields[0]))
                {
                    user.Username = fields[0];
                    user.Password = fields[1];
                    user.Role = Convert.ToInt32(fields[2]);
                    listS.Add(user);
                    found = true;
                }
                line = sReader.ReadLine();
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
        public static List<User> Search(int num, int choice) //Search for role
        {
            List<User> listS = new List<User>();
            bool found = false;
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                User user = new User();
                string[] fields = line.Split(',');
                if (num == Convert.ToInt32(fields[2]))
                {
                    user.Username = fields[0];
                    user.Password = fields[1];
                    user.Role = Convert.ToInt32(fields[2]);
                    listS.Add((user));
                    found = true;
                }
                line = sReader.ReadLine();
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
        public static User Login(User cred)
        {
            User authUser = new User();
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(',');
                if (cred.Username == fields[0] && cred.Password == fields[1])
                {
                    authUser.Username = fields[0];
                    authUser.Password = fields[1];
                    authUser.Role = Convert.ToInt32(fields[2]);
                    sReader.Close();
                    return authUser;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            return null;
        }
        public static List<User> ListUsers()
        {
            List<User> listS = new List<User>();
            ///check to see if exists - TBA
            StreamReader sReader = new StreamReader(filePath);

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                User allUser = new User();
                allUser.Username = fields[0];
                allUser.Password = (fields[1]);
                allUser.Role = Convert.ToInt32(fields[2]);
                listS.Add(allUser);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listS;
        }


    }


}
