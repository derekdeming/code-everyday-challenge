using System;

namespace forLoops
{
    class Program
    {
        static void loopDoWhileLoop()
        {
            int x = 0;
            const int maxCount = 10;

            do
            {                
                Console.WriteLine($"the value of of 'x' is {x} ");
                x++;
            }
            while (x < maxCount);
        }

        static void loop10BreakAtFour()
        {
            int x = 0;
            const int maxCount = 10;

            do
            {
                if (x==4)
                {
                    break;
                }
                Console.WriteLine($"the value of of 'x' is {x} ");
                x++;
            }
            while (x < maxCount);
            Console.WriteLine("After loop");
        }

        static void loop10WhileLoop()
        {
            int x = 0; 
            const int maxCount = 10;
            while(x < maxCount)
            {
                Console.WriteLine($"the value of 'x' is {x}");
                x++;
            }
        }        
        
        static void loop10WhileLoopContinueAt4()
        {
            int x = 0; 
            const int maxCount = 10;
            while(x < 10 )
            {
                if (x == 4)
                {
                    x++;
                    continue;
                }
                Console.WriteLine($"the value of 'x' is {x}");
                x++;
            }
        }        
        
        static void loop10ForLoop()
        {
            const int maxCount = 10;
            for (int x = 0; x < maxCount; x++)
            {
                Console.WriteLine($"the value of 'x' is {x}");
            }
        }

        static void NestedForLoop()
        {
            const int maxParentLoopCount = 10;
            const int maxChildLoopCount = 5;

            for (int x = 0; x < maxParentLoopCount; x++)
            {
                Console.Write($"{x}: ");
                for (int y = 0; y < maxChildLoopCount; y++)
                {
                    Console.Write($"{y} ");
                }
                Console.WriteLine();
            }

        }        
        
        static void NestedForLoopChildDecrement()
        {
            const int maxParentLoopCount = 10;
            const int maxChildLoopCount = 5;

            for (int x = 0; x < maxParentLoopCount; x++)
            {
                Console.Write($"{x}: ");
                for (int y = maxChildLoopCount -1; y > -1; y--)
                {
                    Console.Write($"{y} ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            //loopDoWhileLoop();
            //loop10BreakAtFour();
            //loop10WhileLoop();
            //loop10WhileLoopContinueAt4();
            //loop10ForLoop();
            //NestedForLoop();
            //NestedForLoopChildDecrement();
            ForEachExample();

            Console.ReadKey();
        }

        static void ForEachExample()
        {
            Car[] cars = new Car[] { new Car(200, "Car 1"), new Car(170, "Car 2"), new Car(130, "Car 3") };

            foreach (iCar car in cars)
            {
                Console.WriteLine($"{car.CarLabel} has a max speed of {car.GetMaxSpeed()}");
            }
        }

        public interface iCar
        {
            float GetMaxSpeed();
            string CarLabel { get; set; }
        }

        public class Car : iCar
        {
            float _maxSpeed = 0;
            string _carLabel = string.Empty;

            public Car( float maxSpeed, string carLabel )
            {
                _maxSpeed = maxSpeed;
                _carLabel = carLabel;
            }

            public string CarLabel
            {
                get
                {
                    return _carLabel;
                }
                set
                {
                    _carLabel = value;
                }
            }

            public float GetMaxSpeed()
            {
                return _maxSpeed;
            }

        }
    }
}