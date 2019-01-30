using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketPricerServices
{
    // helper class Dependency-2
    public class HolidayChecker
    {
        DateTime d;

        public HolidayChecker()
        {
        }

        public HolidayChecker(DateTime date)
        {
            this.d = date;
        }

        public bool IsHoliday(DateTime d)
        {
            Console.WriteLine("     " + d.DayOfWeek);
            Console.WriteLine("     " + d.DayOfWeek.ToString().Equals("Saturday"));
            Console.WriteLine("     " + d.DayOfWeek.ToString().Equals("Sunday"));


            if ((d.DayOfWeek.ToString().Equals("Saturday") || (d.DayOfWeek.ToString().Equals("Sunday"))))
            {
                return true;
            }

            return false;

        }
    }
}
