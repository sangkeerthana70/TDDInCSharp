﻿using System;
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

       

        public float CalculatePrice(int board, int destination, int age, DateTime d)
        {
            int numOfStops = destination - board;
            float ticketPrice = 0;
            
            float price = 0;
            
            
            Console.WriteLine("numOfStops: " + numOfStops);
            if (numOfStops < 0)
            {
                throw new System.ArgumentException("Number of stops cannot be negative");

            }

            if((numOfStops == 5) && (!(_holidayChecker.IsHoliday(d))) &&  (_passengerType.CalculatePassengerType(age) == "Adult"))
            {

                ticketPrice = numOfStops * 5;
            }

            if((numOfStops == 5) && (_holidayChecker.IsHoliday(d)) && (_passengerType.CalculatePassengerType(age) == "Adult"))
            {
                price = (numOfStops * 5);
                ticketPrice = (price * float.Parse("0.8"));
                Console.WriteLine("ticketPrice : " + ticketPrice);

                
            }
            return ticketPrice;    
        }

    }
}

