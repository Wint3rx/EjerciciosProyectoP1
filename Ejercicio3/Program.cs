Console.WriteLine("Ingrese un numero valido");
int n1 = Convert.ToInt32(Console.ReadLine());
if (n1 < 0)
{
    Console.WriteLine("Por favor ingrese un numero positivo.");
    return;
}
Console.WriteLine($"La tabla de Multiplicar de {n1} es");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n1} x {i} = {n1 * i}");
}