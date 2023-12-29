﻿using System;
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
            return (_base * _height) / 2;
        }

        public string AsString()
        {
            return $"Base is {_base}, height is {_height}";
        }
    }



    //####################
    //## CODING EXERCISE
    //####################
    public class Dog
    {
        private string _name;
        private string _breed;
        private int _weight;


        public Dog(string name, string breed, int weight)
        {
            _name = name;
            _breed = breed;
            _weight = weight;
        }

        public Dog(string name, int weight) : this(name, "mixed-breed", weight)
        {
        }

        public string Describe()
        {
            return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {DescribeSize()} dog.";
        }

        private string DescribeSize()
        {
            if (_weight < 5)
            {
                return "tiny";
            }
            if (_weight < 30)
            {
                return "medium";
            }
            return "large";
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


    //####################
    //## CODING EXERCISE
    //####################
}
