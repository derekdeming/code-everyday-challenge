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
    //## CODING EXERCISE
    //####################




    //####################
    //## CODING EXERCISE
    //####################




    //####################
    //## CODING EXERCISE
    //####################
}
