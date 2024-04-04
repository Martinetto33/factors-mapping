namespace FactorsMapping
{
    /// <summary>
    /// Un'interfaccia che modella un oggetto in grado di stampare tutti i numeri
    /// da 1 a n; se viene fornita una mappatura fra numeri e stringhe, ogni
    /// volta che si stampa un numero per cui esiste una mappatura si stampa invece
    /// il valore della stringa associata.
    /// </summary>
    public interface IFactorPrinter
    {
        void PrintFactorsWithMappings(int n, List<KeyValuePair<int, string>> mappings);

        void PrintFactors(int n);

    }
}
