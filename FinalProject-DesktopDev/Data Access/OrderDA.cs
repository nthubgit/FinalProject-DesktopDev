using FinalProject_DesktopDev.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_DesktopDev.Data_Access
{
    public static class OrderDA
    {
        private static string filePath = Application.StartupPath + @"\Orders.dat"; //custom path
        private static string fileTemp = Application.StartupPath + @"\Temp.dat"; //custom path for temp dat, used for better updating (replacing)/deleting

        public static void Register(Order order)
        {

            List<Order> listS = new List<Order>();
            listS = ListOrders();
            bool dupe = false;

            foreach (Order o in listS)
            {
                if (o.OrderID == order.OrderID)
                {
                    MessageBox.Show("Duplicate ID, please enter a unique one.");
                    dupe = true;
                }
            }

            if (dupe == false)
            {
                ///check to see if exists - TBA
                StreamWriter sWriter = new StreamWriter(filePath, true); //true used to append
                sWriter.WriteLine(order.OrderID + "," + order.ClientName + "," + order.BookTitle + "," + order.Quantity + "," + order.TotalPrice); ;
                sWriter.Close();
                //Find client based on Client Name, and subtract the cost of the order from their credit limit
                ClientDA.Transaction(order.ClientName, order.TotalPrice);
                BookDA.Transaction(order.BookTitle, order.Quantity);
            }
        }
        public static List<Order> Search(int num, int choice) //Search for Order ID, Quantity, TotalPrice
        {
            List<Order> listS = new List<Order>();
            bool found = false;
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            Console.WriteLine(num);

            while (line != null)
            {
                Order order = new Order();
                string[] fields = line.Split(',');
                switch (choice)
                {
                    case 0: //BookTitle
                        {
                            if (num == Convert.ToInt32(fields[0]))
                            {
                                order.OrderID = Convert.ToInt32(fields[0]);
                                order.ClientName = fields[1];
                                order.BookTitle = fields[2];
                                order.Quantity = Convert.ToInt32(fields[3]);
                                order.TotalPrice = Convert.ToInt32(fields[4]);
                                listS.Add(order);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    case 3: //Quantity
                        {
                            if (num == Convert.ToInt32(fields[3]))
                            {
                                order.OrderID = Convert.ToInt32(fields[0]);
                                order.ClientName = fields[1];
                                order.BookTitle = fields[2];
                                order.Quantity = Convert.ToInt32(fields[3]);
                                order.TotalPrice = Convert.ToInt32(fields[4]);
                                listS.Add(order);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    case 4: //TotalPrice
                        {
                            if (num == Convert.ToInt32(fields[4]))
                            {
                                order.OrderID = Convert.ToInt32(fields[0]);
                                order.ClientName = fields[1];
                                order.BookTitle = fields[2];
                                order.Quantity = Convert.ToInt32(fields[3]);
                                order.TotalPrice = Convert.ToInt32(fields[4]);
                                listS.Add(order);
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


        public static List<Order> Search(string text, int choice) //Search for ClientName, BookTitle
        {
            List<Order> listS = new List<Order>();
            bool found = false;
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();

            while (line != null)
            {
                Order order = new Order();
                string[] fields = line.Split(',');

                switch (choice)
                {
                    case 1:
                        {
                            if (text == fields[1])
                            {
                                order.OrderID = Convert.ToInt32(fields[0]);
                                order.ClientName = fields[1];
                                order.BookTitle = fields[2];
                                order.Quantity = Convert.ToInt32(fields[3]);
                                order.TotalPrice = Convert.ToInt32(fields[4]);
                                listS.Add(order);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            if (text == fields[2])
                            {
                                order.OrderID = Convert.ToInt32(fields[0]);
                                order.ClientName = fields[1];
                                order.BookTitle = fields[2];
                                order.Quantity = Convert.ToInt32(fields[3]);
                                order.TotalPrice = Convert.ToInt32(fields[4]);
                                listS.Add(order);
                                found = true;
                            }
                            line = sReader.ReadLine();
                            break;
                        }
                    default:
                        {
                            break;
                        }
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

        public static List<Order> ListOrders()
        {
            List<Order> listS = new List<Order>();
            ///check to see if exists - TBA
            StreamReader sReader = new StreamReader(filePath);

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Order allOrder = new Order();
                allOrder.OrderID = Convert.ToInt32(fields[0]);
                allOrder.ClientName = fields[1];
                allOrder.BookTitle = fields[2];
                allOrder.Quantity = Convert.ToInt32(fields[3]);
                allOrder.TotalPrice = Convert.ToInt32(fields[4]);
                listS.Add(allOrder);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listS;
        }

        public static void Delete(int clientID)
        {
            Order order = new Order();
            StreamReader sReader = new StreamReader(filePath);
            string line = sReader.ReadLine();
            StreamWriter sWriter = new StreamWriter(fileTemp, true);
            bool found = false;
            while (line != null)
            {
                string[] fields = line.Split(',');
                if ((clientID) != (Convert.ToInt32(fields[0])))
                {

                    sWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3] + "," + fields[4]);


                }
                else
                {
                    found = true;
                    order.ClientName = fields[1];
                    order.BookTitle = fields[2];
                    order.Quantity = Convert.ToInt32(fields[3]);
                    order.TotalPrice = Convert.ToInt32(fields[4]);
                }
                line = sReader.ReadLine(); // Attention : read the next line 
            }
            sReader.Close();
            sWriter.Close();

            if (found)
            {
                File.Delete(filePath);
                File.Move(fileTemp, filePath);
                ClientDA.ReverseTransaction(order.ClientName, order.TotalPrice);
                BookDA.ReverseTransaction(order.BookTitle, order.Quantity);

                MessageBox.Show("Deletion complete. QOH and Credit reverted.", "Success");
            }
            else
            {
                MessageBox.Show("No such ID found.", "Failed");
            }

        }

    }
}
