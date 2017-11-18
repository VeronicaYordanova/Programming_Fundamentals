using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Andrey_and_Billiard
{
  public class Customer
{
        public string NameOfCustomer { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
        public int Quantity { get; set; }
        public string Order { get; set; }

    }
    class Program
    {
        static void Main()
        {
            var shopDictionary = new Dictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var product = Console.ReadLine()
                   .Split('-')
                   .ToArray();

                shopDictionary[product[0]] = decimal.Parse(product[1]);
            }
            string ordersInput = Console.ReadLine();
            Dictionary<Customer, decimal> customers = new Dictionary<Customer, decimal>();
            Dictionary<string, int> shopList = new Dictionary<string, int>();
            while (!ordersInput.Contains("end of clients"))
            {
                string[] orders = ordersInput.Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> ShopList = new Dictionary<string, int>();
                Customer customer = new Customer();
                if (shopDictionary.ContainsKey(orders[1]))
                {
                    customer.NameOfCustomer = orders[0];
                    customer.Order = orders[1];
                    customer.Quantity = int.Parse(orders[2]);
                    shopList[customer.Order] = customer.Quantity;
                    customer.ShopList = (shopList);
                    customer.Bill = shopDictionary[customer.Order] * customer.Quantity;
                    customers[customer] = customer.Bill;
                }
                ordersInput = Console.ReadLine();
            }
            var Customers = customers.OrderBy(x => x.Key.NameOfCustomer);
            foreach (var customerStudent in Customers)
            {
                Console.WriteLine("{0}", customerStudent.Key.NameOfCustomer);
                Console.WriteLine("-- {0} - {1}", customerStudent.Key.Order, customerStudent.Key.Quantity);
                Console.WriteLine("Bill: {0:F2}", customerStudent.Key.Bill);
            }
            Console.WriteLine("Total bill: {0:F2}", customers.Sum(x => x.Key.Bill));
        }
    }
}

