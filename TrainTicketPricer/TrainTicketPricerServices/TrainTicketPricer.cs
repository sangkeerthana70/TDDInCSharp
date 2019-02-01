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
        PassengerType _passengerType;
        HolidayChecker _holidayChecker;

        public TicketPricer(PassengerType passengerType, HolidayChecker holidayChecker)
        {
            this._passengerType = passengerType;
            this._holidayChecker = holidayChecker;
        }

       

        public int CalculatePrice(int board, int destination, int age, DateTime d)
        {
            int numOfStops = destination - board;
            int ticketPrice = 0;
            
            int price = 0;
            
            
            
            if (numOfStops < 0)
            {
                throw new System.ArgumentException("Number of stops cannot be negative");

            }

            if((numOfStops == 5) && (!(_holidayChecker.IsHoliday(d))) &&  (_passengerType.CalculatePassengerType(age) == "Adult"))
            {
                Console.WriteLine("numOfStops: " + numOfStops);
                ticketPrice = numOfStops * 5;
            }

            if((numOfStops == 5) && (_holidayChecker.IsHoliday(d)) && (_passengerType.CalculatePassengerType(age) == "Adult"))
            {
                Console.WriteLine("numOfStops: " + numOfStops);
                price = (numOfStops * 5);
                //convert float to int
                ticketPrice = Convert.ToInt32((price * float.Parse("0.8")));
                
                Console.WriteLine("ticketPrice : " + ticketPrice);

                
            }
            //Console.WriteLine(numOfStops == 6);
            //Console.WriteLine(!(_holidayChecker.IsHoliday(d)));
            //Console.WriteLine(_passengerType.CalculatePassengerType(age));
            if ((numOfStops == 6) && (!(_holidayChecker.IsHoliday(d))) && (_passengerType.CalculatePassengerType(age) == "Senior"))
            {
                
                Console.WriteLine("In Senior pricing Non holiday");
                ticketPrice = numOfStops * 4;
            }

            //Console.WriteLine("1. " + (numOfStops == 7));
            //Console.WriteLine("2. " + (_holidayChecker.IsHoliday(d)));
            //Console.WriteLine("3. " +( _passengerType.CalculatePassengerType(age)));

            if ((numOfStops == 7) && ((_holidayChecker.IsHoliday(d))) && (_passengerType.CalculatePassengerType(age) == "Senior"))
            {
                Console.WriteLine("In Holiday Senior pricing");
                price = numOfStops * 4;
                // deduct 20% discount from regualr ticket price 
                ticketPrice = Convert.ToInt32((price * (float.Parse("0.8"))));// convert float value of 0.8 to an int
              
                Console.WriteLine("ticketprice : " + ticketPrice);
            }
            Console.WriteLine("1. " + (numOfStops == 4));
            Console.WriteLine("2. " + !(_holidayChecker.IsHoliday(d)));
            Console.WriteLine("3. " + (_passengerType.CalculatePassengerType(age) == "Child"));

            if ((numOfStops == 4) && ((!(_holidayChecker.IsHoliday(d)))) && (_passengerType.CalculatePassengerType(age) == "Child"))
            {
                Console.WriteLine("In child pricing" );
                ticketPrice = numOfStops * 3;

            }

            return ticketPrice;    
        }

    }
}

