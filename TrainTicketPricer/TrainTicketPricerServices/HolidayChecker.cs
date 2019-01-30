using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketPricerServices
{
    public class HolidayChecker
    {
        DateTime date;
        public HolidayChecker(DateTime d)
        {
            this.date = d;
        }

        public bool IsHoliday(DateTime date)
        {
            return false;
        }
    }
}
