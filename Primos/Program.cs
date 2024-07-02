using Utilidades;

internal class Program
{
    static utilidades util = new utilidades();

    static void Main()
    {
        // Datos de entrada
        Console.WriteLine("Ingrese un numero:");
        int i = Convert.ToInt32(Console.ReadLine()); // Número inicial desde donde se iniciará a calcular

        Console.WriteLine("Ingrese la cantidad de numeros a evaluar:");
        int n = Convert.ToInt32(Console.ReadLine()); // Cantidad de números primos que se quiere calcular a partir de i

        // Obtener y mostrar los n números primos a partir de i
        List<int> numerosPrimos = util.CalcularPrimos(i, n);

        // Mostrar los resultados
        Console.WriteLine($"Los {n} numeros primos a partir de {i} son:");
        foreach (int primo in numerosPrimos)
        {
            Console.Write($"{primo} ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}