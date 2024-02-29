using static System.Runtime.InteropServices.JavaScript.JSType;

int n1;

do
{
    Console.WriteLine("Ingrese un numero entero positivo (Tambien puede escribir un 0 para salir)");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out n1) )
    {
        Console.WriteLine("Por favor ingrese un numero valido.");
        continue;
    }

    if ( n1 < 0 )
    {
        Console.WriteLine("Por favor ingrese un numero positivo.");
        continue;
    }

    if (n1 == 0) 
    {
        Console.WriteLine("Gracias por usar el programa :3");
        break;
    }

    Mostrarmenu(n1);

}
while (true);

static void Mostrarmenu(int n1)
{
    Console.WriteLine(">>>>>>>>>>Menu<<<<<<<<<<");
    Console.WriteLine("Eliga una de las siguientes opciones:");
    Console.WriteLine("1. Calcular el factorial del número.");
    Console.WriteLine("2. Calcular la raíz cuadrada del número.");
    Console.WriteLine("3. Salir del programa.");
    string opcion = Console.ReadLine();

    switch ( opcion )
    {
        case "1":
            long factorial = CalcularFactorial (n1);
            Console.WriteLine($"El factorial de {n1} es: {factorial}");
            break;

        case "2":
            double raizcuadrada = CalcularRaiz (n1);
            Console.WriteLine($"La raiz cuadrada de {n1} es: {raizcuadrada}");
            break;

        case "3":
            Console.WriteLine("Gracias por usar el programa :3");
            Environment.ExitCode = 0;
            break;

        default:
            Console.WriteLine("Opcion no valida, por favor seleccione uno entre estos (1, 2, 3)");
            break;
    }
}
static long CalcularFactorial(int n1)
{
    if ( n1 == 0 || n1 == 1 )
    {
        return 1;
    }
    else
    {
        return n1 * CalcularFactorial(n1 - 1);
    }
}
static double CalcularRaiz(int n1)
{
    return Math.Pow(n1, 0.5);
}
