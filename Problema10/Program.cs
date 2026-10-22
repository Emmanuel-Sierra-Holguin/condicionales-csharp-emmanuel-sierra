class program
{
    static void Main()
    {
        object dato = 'S';
        if (dato is string)
        {
            string texto = (string)dato;
            Console.WriteLine($"texto {dato} tiene {texto.Length} caracteres");
        }
        else if (dato is int)
        {
            Console.WriteLine($"Entero: {dato}");
        }
        else if (dato is double)
        {
            Console.WriteLine($"Decimal: {dato}");
        }
        else if (dato is bool)
        {
            Console.WriteLine($"Booleano: {dato}");
        }
        else
        {
            Console.WriteLine("tipo no reconocido");
        }
    }
}