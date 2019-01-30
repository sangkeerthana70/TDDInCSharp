using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketPricerServices
{
    // main class 
    public class TrainTicketPricer
    {
        public int totalFee;
        public int numOfStops;
        public int boardStation;
        public int destinationStation;
        public int ageOfPassenger;
        DateTime dayOfTravel;
        PassengerType pt;
        HolidayChecker hc;

        public TrainTicketPricer()
        {

        }

        public int CalculatePrice(int boardStation, int desStation, int age, DateTime d)
        {
            return 0;
        }

    }
}

