namespace TestFactorPrinters
{
    [TestClass]
    public class TestPrinters
    {
        static List<KeyValuePair<int, string>> _mappingsList = new List<KeyValuePair<int, string>>();

        [TestInitialize]
        public void Initialize()
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
                _mappingsList.Add(elem);
            }
        }

        [TestMethod]
        public void TestSingleFactorPrinter()
        {
            UtilityTestPrinter testPrinter = new();
            /* Per il numero 3 viene restituito "hippo". */
            Assert.AreEqual("hippo", testPrinter.GetFactorsAsSinglePrinterString(3, _mappingsList));
            Assert.AreEqual("potamo", testPrinter.GetFactorsAsSinglePrinterString(4, _mappingsList));
            /* Per il numero 24, il fattore maggiore è 12, quindi in un SingleFactorPrinter si restituisce
             la stringa associata a 12, perciò "hippopotamo". */
            Assert.AreEqual("hippopotamo", testPrinter.GetFactorsAsSinglePrinterString(24, _mappingsList));
        }

        [TestMethod]
        public void TestMultipleFactorPrinter()
        {
            UtilityTestPrinter testPrinter = new();
            /* Per il numero 3 viene restituito "hippo". */
            Assert.AreEqual("hippo", testPrinter.GetFactorsAsMultiplePrinterString(3, _mappingsList));
            Assert.AreEqual("potamo", testPrinter.GetFactorsAsMultiplePrinterString(4, _mappingsList));
            /* Per il numero 24, il fattore maggiore è 12; in ordine decrescente seguono 4 e 3, quindi in un MultipleFactorPrinter 
             * si restituisce la stringa associata a ciascuno di questi tre numeri, perciò "hippopotamopotamohippo". */
            Assert.AreEqual("hippopotamopotamohippo", testPrinter.GetFactorsAsMultiplePrinterString(24, _mappingsList));
        }

        [TestCleanup] 
        public void Cleanup()
        {
            _mappingsList.Clear();
        }
    }
}
