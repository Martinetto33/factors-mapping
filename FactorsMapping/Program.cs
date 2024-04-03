using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsMapping
{
    internal class Program
    {
        static List<KeyValuePair<int, string>> _mappingsList = new List<KeyValuePair<int, string>>();

        private static void Initialize()
        {
            SortedDictionary<int, string> mappings = new SortedDictionary<int, string>();
            mappings.Add(3, "hippo");
            mappings.Add(4, "potamo");
            mappings.Add(12, "hippopotamo");
            mappings.Add(7, "super");
            mappings.Add(84, "superhippopotamo");
            mappings.Add(21, "superhippo");
            mappings.Add(28, "superpotamo");
            foreach (var elem in mappings.OrderByDescending(entry => entry.Key))
            {
                Console.WriteLine(elem);
                _mappingsList.Add(elem);
            }
        }
        static void Main() 
        {
            Initialize();
            IFactorPrinter singlePrinter = new SingleFactorPrinter();
            IFactorPrinter multiplePrinter = new MultipleFactorPrinter();
            singlePrinter.PrintFactors(10);
            multiplePrinter.PrintFactors(10);
            singlePrinter.PrintFactorsWithMappings(100, _mappingsList);
            Console.WriteLine("\n\n");
            multiplePrinter.PrintFactorsWithMappings(100, _mappingsList);
        }
    }
}
