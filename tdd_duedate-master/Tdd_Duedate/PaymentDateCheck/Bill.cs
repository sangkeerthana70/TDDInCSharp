using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDateCheck
{
    public class Bill
    {
        //bring in holiday service to check for holidays
        //use dependency injection
        HolidayService holidayService;
        public Bill(HolidayService hs)
        {
            this.holidayService = hs;
        }
        public DateTime CheckDate(DateTime dueDate)
        {
            //throw new NotImplementedException();
            while (true)
            {
                if ((dueDate.DayOfWeek == DayOfWeek.Saturday) ||
                    (dueDate.DayOfWeek == DayOfWeek.Sunday) ||
                    holidayService.isHoliday(dueDate))
                {
                    dueDate = dueDate.AddDays(1);
                }
                else
                {
                    return dueDate;
                }
            }
            //if (dueDate.DayOfWeek == DayOfWeek.Saturday )
            //{
            //    return dueDate.AddDays(2);
            //}
            //if (dueDate.DayOfWeek == DayOfWeek.Sunday)
            //{
            //    return dueDate.AddDays(1);
            //}
            //if (holidayService.isHoliday(dueDate))// test case 4
            //{
            //    return dueDate.AddDays(1);
            //}
            //if (holidayService.isHoliday(dueDate))// test case 5
            //{
            //    return dueDate.AddDays(3);
            //}

            //return dueDate;
        }

       
    }
}
