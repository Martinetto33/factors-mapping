using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsMapping
{
    /// <summary>
    /// Una classe che stampa tutte le mappature esistenti se un numero
    /// è divisibile per più di uno dei fattori presenti nelle mappature.
    /// </summary>
    public class MultipleFactorPrinter : AbstractFactorPrinter
    {

        public override void PrintFactorsWithMappings(int n, List<KeyValuePair<int, string>> mappings)
        {
            Console.WriteLine("Multiple factors printer:");
            if (!base.IsInputCorrect(n)) return;
            bool alreadyPrinted = false;
            for (int i = 1; i <= n; i++)
            {
                foreach(var mapping in mappings)
                {
                    /* Se i è un multiplo di uno dei valori inseriti nelle mappature,
                     stampa la stringa corrispondente. Ripeti per tutti i fattori di i
                    per cui è presente una mappatura. */
                    if (i % mapping.Key == 0)
                    {
                        Console.Write(mapping.Value);
                        alreadyPrinted = true;
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
