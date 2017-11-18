using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06_Fix_Emails
{
    class Program
    {
        public static void Main()
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

            File.WriteAllText("output.txt", string.Empty);

            foreach (var contact in emails)
            {
                File.AppendAllText("output.txt", $"{contact.Key} -> {contact.Value}{Environment.NewLine}");
            }

        }
    }
}
