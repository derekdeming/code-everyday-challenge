using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class codingExercises
    {
    }

    //####################
    //## CODING EXERCISE
    //####################

    // HOTEL BOOKING CLASS 
    internal class HotelBooking
    {
        public string GuestName;
        public DateTime StartDate;
        public DateTime EndDate;

        public HotelBooking(
            string guestName,
            DateTime startDate,
            int lengthOfStayInDays
            )
        {
            GuestName = guestName;
            StartDate = startDate;
            EndDate = startDate.AddDays(lengthOfStayInDays);
        }
    }

    //####################
    //## CODING EXERCISE -- TRIANGLE CLASS 
    //####################
    public class Triangle
    {
        private int _base;
        private int _height;

        public Triangle(int @base, int height)
        {
            _base = @base;
            _height = height;
        }

        public int CalculateArea()
        {
            return (_base * _height)/2;
        }

        public string AsString()
        {
            return $"Base is {_base}, height is {_height}";
        }
    }



    //####################
    //## CODING EXERCISE
    //####################




    //####################
    //## CODING EXERCISE
    //####################
}
