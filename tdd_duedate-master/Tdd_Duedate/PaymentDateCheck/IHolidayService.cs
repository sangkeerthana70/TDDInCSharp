using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDateCheck
{
    public interface IHolidayService
    {
        bool isHoliday(DateTime duedate);
    }
}
