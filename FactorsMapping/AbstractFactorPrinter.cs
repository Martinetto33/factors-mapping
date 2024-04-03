using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsMapping
{
    public abstract class AbstractFactorPrinter : IFactorPrinter
    {
        /// <summary>
        /// Controlla se l'input è corretto.
        /// </summary>
        /// <param name="input">L'intero fornito.</param>
        /// <returns>True se l'input è > 0, falso altrimenti</returns>
        protected bool IsInputCorrect(int input) 
        {
            if (input <= 0)
            {
                Console.WriteLine("Incorrect input! The number `n' must be >= 0 !");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Stampa i numeri da 1 a n se nessuna mappatura
        /// viene fornita.
        /// </summary>
        /// <param name="n">Il limite superiore dei numeri
        /// da stampare, incluso.</param>
        public void PrintFactors(int n)
        {
            if (!IsInputCorrect(n)) return;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + (i == n ? "." : ", "));
            }
            Console.WriteLine("");
        }

        public abstract void PrintFactorsWithMappings(int n, List<KeyValuePair<int, string>> mappings);

    }
}
