using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsMapping
{
    /// <summary>
    /// Una classe che stampa una sola delle mappature esistenti se un numero
    /// è divisibile per più di uno dei fattori presenti nelle mappature.
    /// </summary>
    public class SingleFactorPrinter : AbstractFactorPrinter
    {
        public override void PrintFactorsWithMappings(int n, List<KeyValuePair<int, string>> mappings)
        {
            Console.WriteLine("Single factor printer:");
            if (!base.IsInputCorrect(n)) return;
            bool alreadyPrinted = false;
            for (int i = 1; i <= n; i++)
            {
                foreach (var mapping in mappings)
                {
                    /* Se i è un multiplo di uno dei valori inseriti nelle mappature,
                     stampa la stringa corrispondente. Se questo succede, NON eseguire
                    altre stampe di queste mappature, bensì passa al prossimo valore di i.
                    */
                    if (i % mapping.Key == 0)
                    {
                        Console.Write(mapping.Value);
                        alreadyPrinted = true;
                        break;
                    }
                }
                if (!alreadyPrinted)
                {
                    Console.Write(i);
                }
                alreadyPrinted = false;
                /* Il seguente codice serve solo a migliorare l'output della stampa. */
                Console.Write(i == n ? "." : ", ");
            }
            Console.WriteLine("");
        }
    }
}
