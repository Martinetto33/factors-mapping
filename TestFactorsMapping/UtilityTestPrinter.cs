using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactorPrinters
{
    /// <summary>
    /// Una utility class con metodi utili per lo unit testing. Simula il comportamento
    /// di un SingleFactorPrinter e di un MultipleFactorPrinter.
    /// </summary>
    internal class UtilityTestPrinter
    {
        /// <summary>
        /// Dato un numero currentIndex > 0, questo metodo restituisce l'output (senza punteggiatura)
        /// che un SingleFactorPrinter restituirebbe con una chiamata a PrintFactorsWithMappings().
        /// </summary>
        /// <param name="currentIndex">Il numero da valutare.</param>
        /// <param name="mappingsList">L'attuale lista di mappature tra interi e stringhe.</param>
        /// <returns></returns>
        public string GetFactorsAsSinglePrinterString(int currentIndex, List<KeyValuePair<int, string>> mappingsList)
        {
            StringBuilder builder = new();
            bool alreadyPrinted = false;
            foreach (var mapping in mappingsList)
            {
                if (currentIndex % mapping.Key == 0)
                {
                    builder.Append(mapping.Value);
                    alreadyPrinted = true;
                    break;
                }
            }
            if (!alreadyPrinted)
            {
                builder.Append(currentIndex);
            }
            return builder.ToString();
        }

        /// <summary>
        /// Dato un numero currentIndex > 0, questo metodo restituisce l'output (senza punteggiatura)
        /// che un MultipleFactorPrinter restituirebbe con una chiamata a PrintFactorsWithMappings().
        /// </summary>
        /// <param name="currentIndex">Il numero da valutare.</param>
        /// <param name="mappingsList">L'attuale lista di mappature tra interi e stringhe.</param>
        /// <returns></returns>
        public string GetFactorsAsMultiplePrinterString(int currentIndex, List<KeyValuePair<int, string>> mappingsList)
        {
            StringBuilder builder = new();
            bool alreadyPrinted = false;
            foreach (var mapping in mappingsList)
            {
                if (currentIndex % mapping.Key == 0)
                {
                    builder.Append(mapping.Value);
                    alreadyPrinted = true;
                }
            }
            if (!alreadyPrinted)
            {
                builder.Append(currentIndex);
            }
            return builder.ToString();
        }
    }
}
