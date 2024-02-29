int n1, n2;
char op;

Console.WriteLine("Ingrese el primer numero:");
if (!int.TryParse(Console.ReadLine(), out n1))
{
    Console.WriteLine("Por favor ingrese un numero entero valido");
    return;
}

Console.WriteLine("Ingrese el segundo numero:");
if (!int.TryParse(Console.ReadLine(), out n2))
{
    Console.WriteLine("Por favor ingrese un numero entero valido");
    return;
}

Console.WriteLine("Ingrese el operador matematico (+, -, *, /) que desea utilizar:");
if (!char.TryParse(Console.ReadLine(), out op) || !EsOperadorValido(op))
{
    Console.WriteLine("Por favor ingrese un operador valido");
    return;
}

CalcularYMostrarResultado(n1, n2, op);

static bool EsOperadorValido(char op)
{
    return op == '+' || op == '-' || op == '*' || op == '/';
}

static void CalcularYMostrarResultado(int n1, int n2, char op)
{
    double resultado = 0;

    switch (op)
    {
        case '+':
            resultado = n1 + n2;
            break;

        case '-':
            resultado = n1 - n2;
            break;

        case '*':
            resultado = n1 * n2;
            break;

        case '/':  
            if (n2 != 0)
            {
                resultado = n1 / n2;
            }
            else
            {
                Console.WriteLine("No se puede dividir entre 0");
                return;
            }
            break;
        default:
            Console.WriteLine("Operador no valido");
            return;
    }
    Console.WriteLine($"El resultado de la operacion es: {resultado}");
}