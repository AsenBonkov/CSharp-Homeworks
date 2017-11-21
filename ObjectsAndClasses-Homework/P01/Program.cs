namespace P01CountWorkingDays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            var startDate = DateTime.ParseExact(start, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(end, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[11];
            {
                holidays[0] = new DateTime(endDate.Year, 01, 01);
                holidays[1] = new DateTime(endDate.Year, 03, 03);
                holidays[2] = new DateTime(endDate.Year, 05, 01);
                holidays[3] = new DateTime(endDate.Year, 05, 06);
                holidays[4] = new DateTime(endDate.Year, 05, 24);
                holidays[5] = new DateTime(endDate.Year, 09, 06);
                holidays[6] = new DateTime(endDate.Year, 09, 22);
                holidays[7] = new DateTime(endDate.Year, 11, 01);
                holidays[8] = new DateTime(endDate.Year, 12, 24);
                holidays[9] = new DateTime(endDate.Year, 12, 25);
                holidays[10] = new DateTime(endDate.Year, 12, 26);
            }

            int days = 0;

            for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                var day = currentDate.DayOfWeek;
                if (!holidays.Contains(currentDate) && !day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday))
                {
                    days++;
                }
            }

            Console.WriteLine(days);
        }
        
    }
}
