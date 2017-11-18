using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01_Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstDate = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            string secondDate = Console.ReadLine();
            DateTime endDate = DateTime.ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] officialHolidays = new DateTime[11];

            officialHolidays[0] = new DateTime(4, 01, 01);
            officialHolidays[1] = new DateTime(4, 03, 03);
            officialHolidays[2] = new DateTime(4, 05, 01);
            officialHolidays[3] = new DateTime(4, 05, 06);
            officialHolidays[4] = new DateTime(4, 05, 24);
            officialHolidays[5] = new DateTime(4, 09, 06);
            officialHolidays[6] = new DateTime(4, 09, 22);
            officialHolidays[7] = new DateTime(4, 11, 01);
            officialHolidays[8] = new DateTime(4, 12, 24);
            officialHolidays[9] = new DateTime(4, 12, 25);
            officialHolidays[10] = new DateTime(4, 12, 26);


            int workingDaysCounter = 0;
           
            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                var currentDay = day.DayOfWeek;
                DateTime temp = new DateTime(4, day.Month, day.Day);

                if (currentDay != DayOfWeek.Saturday && currentDay != DayOfWeek.Sunday && !officialHolidays.Contains(temp))
                    
                {
                    workingDaysCounter++;
                }
                
            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}
