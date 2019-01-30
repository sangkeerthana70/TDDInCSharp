using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketPricerServices
{
    // main class 
    public class TicketPricer
    {
        public int totalFee;
        public int numOfStops;
        public int boardStation;
        public int destinationStation;
        public int ageOfPassenger;
        DateTime dayOfTravel;
        PassengerType pt;
        HolidayChecker hc;

        public TicketPricer()
        {

        }

        public TicketPricer(PassengerType passengerType, HolidayChecker holidayChecker)
        {
            this.pt = passengerType;
            this.hc = holidayChecker;
        }

        public int CheckNumberOfStops(int boardStation, int destinationStation)
        {
            int numOfStops = destinationStation - boardStation;
            Console.WriteLine(numOfStops);
            if(numOfStops < 0)
            {
                throw new System.ArgumentException("Number of stops cannot be negative");

            }
            return numOfStops;
        }

        public int CalculatePrice(int age, DateTime d)
        {
            return 0;
        }

    }
}

