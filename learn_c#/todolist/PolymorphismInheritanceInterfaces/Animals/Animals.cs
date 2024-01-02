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
            var animals = new List<Animal>
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

    public class VirtualMethodsStringsProcessorClasses
    {

        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
            {
                new StringsTrimmingProcessor(),
                new StringsUppercaseProcessor()
            };

            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }

    public class StringsProcessor
    {
        public List<string> Process(
            List<string> strings)
        {
            var result = new List<string>();
            foreach (var text in strings)
            {
                result.Add(ProcessSingle(text));
            }
            return result;
        }

        protected virtual string ProcessSingle(string input) => input;
    }

    public class StringsTrimmingProcessor : StringsProcessor
    {
        protected override string ProcessSingle(string input) => input.Substring(0, input.Length / 2);
    }

    public class StringsUppercaseProcessor : StringsProcessor
    {
        protected override string ProcessSingle(string input) =>
        input.ToUpper();
    }















}
