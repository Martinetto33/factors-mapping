namespace FactorsMapping
{
    internal static class Program
    {
        static List<KeyValuePair<int, string>> _mappingsList = new();

        private static void Initialize()
        {
            SortedDictionary<int, string> mappings = new SortedDictionary<int, string>
            {
                { 3, "hippo" },
                { 4, "potamo" },
                { 12, "hippopotamo" },
                { 7, "super" },
                { 84, "superhippopotamo" },
                { 21, "superhippo" },
                { 28, "superpotamo" }
            };
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
