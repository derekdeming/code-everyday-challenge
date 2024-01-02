using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInheritanceInterfaces.Animals
{
    public class Exercise
    {
        public List<int> GetCountsOfAnimalLegs()
        {
            var animals = new List<Animals>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

            var result = new List<int>();
            foreach (var animal in animals)
            {
                result.Add(animal.NumberOfLegs);
            }
            return result;
        }
    }

    public class Animal
    {
        public virtual int NumberOfLegs { get; } = 4;
    }

    public class Tiger : Animal
    {

    }

    public class Lion : Animal
    {

    }
    public class Duck : Animal
    {
        public override int NumberOfLegs { get; } = 2; 
    }

    public class Spider : Animal
    {
        public override int NumberOfLegs { get; } = 8;

    }
}
