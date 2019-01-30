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
        
        public int ageOfPassenger;

        public PassengerType()
        {
        }

        public PassengerType(int a)
        {
            
            this.ageOfPassenger = a;
        }

        public string CalculatePassengerType(int age)
        {
            string passengerType;
            if(age <= 13)
            {
                passengerType = "Child";
            }
            else if(age > 13 || age <= 65)
            {
                passengerType = "Adult";
            }
            else
            {
                passengerType = "Senior Citizen";
            }
            return passengerType;
        }

    }
}
