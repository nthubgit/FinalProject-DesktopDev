using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject_DesktopDev.Business;
using System.Windows.Forms;
using System.IO;

namespace FinalProject_DesktopDev.Data_Access
{
    public static class ClientDA
    {

            private static string filePath = Application.StartupPath + @"\Clients.dat"; //custom path
            private static string fileTemp = Application.StartupPath + @"\Temp.dat"; //custom path for temp dat, used for better updating (replacing)/deleting

            public static void Register(Client client)
            {
               
                List<Client> listS = new List<Client>();
                listS = ListClients();
                bool dupe = false;

                foreach (Client c in listS)
                {
                    if (c.Name == client.Name)
                    {
                        MessageBox.Show("Duplicate ID, please enter a unique one.");
                        dupe = true;
                    }
                }
                if (dupe == false)
                {
                    StreamWriter sWriter = new StreamWriter(filePath, true); //true used to append
                    sWriter.WriteLine(client.Name + "," + client.Street + "," + client.City + "," + client.PostalCode + "," + client.PhoneNumber + "," + client.FaxNumber + "," + client.CreditLimit);
                    sWriter.Close();
                    MessageBox.Show("Registration complete.");
                }
            }
            public static List<Client> Search(string text, int choice) //Search for Name, Street, City, Postal Code, Phone Number, Fax Number
            {
                List<Client> listS = new List<Client>();
                bool found = false;
                StreamReader sReader = new StreamReader(filePath);
                string line = sReader.ReadLine();

                while (line != null)
                {
                    Client client = new Client();
                    string[] fields = line.Split(',');

                    switch (choice)
                    {
                        case 0: //Name
                            {
                                if (text == (fields[0]))
                                {
                                    client.Name = fields[0];
                                    client.Street = fields[1];
                                    client.City = fields[2];
                                    client.PostalCode = fields[3];
                                    client.PhoneNumber = fields[4];
                                    client.FaxNumber = fields[5];
                                    client.CreditLimit = Convert.ToInt32(fields[6]);
                                    listS.Add(client);
                                    found = true;
                                }
                                line = sReader.ReadLine();

                                break;
                            }
                        case 1: //Street
                            {
                                if (text == (fields[1]))
                                {
                                    client.Name = fields[0];
                                    client.Street = fields[1];
                                    client.City = fields[2];
                                    client.PostalCode = fields[3];
                                    client.PhoneNumber = fields[4];
                                    client.FaxNumber = fields[5];
                                    client.CreditLimit = Convert.ToInt32(fields[6]);
                                    listS.Add(client);
                                    found = true;
                                }
                                line = sReader.ReadLine();
                                break;
                            }
                        case 2: //City
                            {
                                if (text == (fields[2]))
                                {
                                    client.Name = fields[0];
                                    client.Street = fields[1];
                                    client.City = fields[2];
                                    client.PostalCode = fields[3];
                                    client.PhoneNumber = fields[4];
                                    client.FaxNumber = fields[5];
                                    client.CreditLimit = Convert.ToInt32(fields[6]);
                                    listS.Add(client);
                                    found = true;
                                }
                                line = sReader.ReadLine();
                                break;
                            }
                        case 3: //PostalCode
                        {
                            if (text == (fields[3]))
                            {
                                client.Name = fields[0];
                                client.Street = fields[1];
                                client.City = fields[2];
                                client.PostalCode = fields[3];
                                client.PhoneNumber = fields[4];
                                client.FaxNumber = fields[5];
                                client.CreditLimit = Convert.ToInt32(fields[6]);
                                listS.Add(client);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                        case 4: //PhoneNumber
                        {
                            if (text == (fields[4]))
                            {
                                client.Name = fields[0];
                                client.Street = fields[1];
                                client.City = fields[2];
                                client.PostalCode = fields[3];
                                client.PhoneNumber = fields[4];
                                client.FaxNumber = fields[5];
                                client.CreditLimit = Convert.ToInt32(fields[6]);
                                listS.Add(client);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    case 5: //FaxNumber
                        {
                            if (text == (fields[5]))
                            {
                                client.Name = fields[0];
                                client.Street = fields[1];
                                client.City = fields[2];
                                client.PostalCode = fields[3];
                                client.PhoneNumber = fields[4];
                                client.FaxNumber = fields[5];
                                client.CreditLimit = Convert.ToInt32(fields[6]);
                                listS.Add(client);
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

        public static List<Client> Search(int num, int choice) //Credit Limit
        {
            List<Client> listS = new List<Client>();
            bool found = false;
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                Client client = new Client();
                string[] fields = line.Split(',');

                if (num == Convert.ToInt32(fields[6]))
                {
                    client.Name = fields[0];
                    client.Street = fields[1];
                    client.City = fields[2];
                    client.PostalCode = fields[3];
                    client.PhoneNumber = fields[4];
                    client.FaxNumber = fields[5];
                    client.CreditLimit = Convert.ToInt32(fields[6]);
                    listS.Add(client);
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
       
        public static List<Client> ListClients() 
        {
            List<Client> listS = new List<Client>();
            ///check to see if exists - TBA
            StreamReader sReader = new StreamReader(filePath);

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Client allClient = new Client();
                allClient.Name = fields[0];
                allClient.Street = fields[1];
                allClient.City = fields[2];
                allClient.PostalCode = fields[3];
                allClient.PhoneNumber = fields[4];
                allClient.FaxNumber = fields[5];
                allClient.CreditLimit = Convert.ToInt32(fields[6]);
                listS.Add(allClient);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listS;
        }

        public static String Transaction(string ClientName, int totalPrice, string BookTitle, int QOH) //Finds the client based on ClientName, then updates DB
        {
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            Client client = new Client();
            int oldCredit = 0;
            //Search
            while (line != null)
            {
                string[] fields = line.Split(',');

                if (ClientName == fields[0])
                {
                    oldCredit = Convert.ToInt32(fields[6]);
                    client.Name = fields[0];
                    client.Street = fields[1];
                    client.City = fields[2];
                    client.PostalCode = fields[3];
                    client.PhoneNumber = fields[4];
                    client.FaxNumber = fields[5];
                    client.CreditLimit = (Convert.ToInt32(fields[6]));
                    break;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();

            //Check to see client has enough funds before doing transaction

            int budgetCheck = oldCredit - totalPrice; 
            if (budgetCheck < 0)
            {
                MessageBox.Show("Insufficient credit! Cancelling transaction.");
                return null;
            }

            //Update

            StreamWriter sWriter = new StreamWriter(fileTemp, true);
            StreamReader sReader2 = new StreamReader(filePath);
            String line2 = sReader2.ReadLine();

            while (line2 != null)
            {
                string[] fields = line2.Split(',');
                if (fields[0] != client.Name)
                {
                    sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
                }

                line2 = sReader2.ReadLine();
            }
            sWriter.WriteLine(client.Name + "," + client.Street + "," + client.City + "," + client.PostalCode + "," + client.PhoneNumber + "," + client.FaxNumber + "," + client.CreditLimit);
            sReader2.Close();
            sWriter.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);
            string result = BookDA.Transaction(BookTitle, QOH);

            if (result != null)
            {
                result += client.Name + "'s credit: " + oldCredit + "=>" + client.CreditLimit;
                return result;
            }
            return result;
        }

        public static String ReverseTransaction(string ClientName, int totalPrice) //Finds the client based on ClientName after deletion, then updates DB to revert values. Would be better to include this in Transaction somehow
        {
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            Client client = new Client();
            int oldCredit = 0;
            //Search
            while (line != null)
            {
                string[] fields = line.Split(',');

                if (ClientName == fields[0])
                {
                    oldCredit = Convert.ToInt32(fields[6]);
                    client.Name = fields[0];
                    client.Street = fields[1];
                    client.City = fields[2];
                    client.PostalCode = fields[3];
                    client.PhoneNumber = fields[4];
                    client.FaxNumber = fields[5];
                    client.CreditLimit = (Convert.ToInt32(fields[6]) + totalPrice);
                    break;
                }
                line = sReader.ReadLine();
            }
            sReader.Close();
            //Update

            StreamWriter sWriter = new StreamWriter(fileTemp, true);
            StreamReader sReader2 = new StreamReader(filePath);
            String line2 = sReader2.ReadLine();

            while (line2 != null)
            {
                string[] fields = line2.Split(',');
                if (fields[0] != client.Name)
                {
                    sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
                }

                line2 = sReader2.ReadLine();
            }
            sWriter.WriteLine(client.Name + "," + client.Street + "," + client.City + "," + client.PostalCode + "," + client.PhoneNumber + "," + client.FaxNumber + "," + client.CreditLimit);
            sReader2.Close();
            sWriter.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);
            string result = client.Name + "'s credit: " + oldCredit + "=>" + client.CreditLimit;
            return result;
        }

    }
}

