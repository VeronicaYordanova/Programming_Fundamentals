using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = Console.ReadLine();
            
            while (name != "stop")
            {
                string email = Console.ReadLine();
                string emailDomain = email.Substring(email.Length - 2).ToLower();

                if (!emailDomain.Contains("us") && !emailDomain.Contains("uk"))
                {
                    emails[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
