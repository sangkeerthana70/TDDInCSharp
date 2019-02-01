using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketPricerServices
{
    // helper class Dependency-1
    public class PassengerType
    {       
        
        public string CalculatePassengerType(int age)
        {
            string passengerType;
            if(age <= 13)
            {
                passengerType = "Child";
            }
            else if(age > 13 && age <= 65)
            {
                passengerType = "Adult";
            }
            else
            {
                passengerType = "Senior";
            }
            return passengerType;
        }

    }
}
