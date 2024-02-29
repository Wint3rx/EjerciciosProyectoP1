Random random = new Random();
int Nsecreto = random.Next(1, 101);

int intentos = 0;
int intentousuario;

Console.WriteLine(" Welcome to the Guessing Game ");
Console.WriteLine("Bienvenido al Juego de Adivinar");

do
{
    Console.WriteLine("Introduce un numero");
    if (!int.TryParse(Console.ReadLine(), out intentousuario))
    {
        Console.WriteLine("Por favor ingrese un numero valido.");
        continue;
    }

    intentos++;

    if (intentousuario == Nsecreto)
    {
        Console.WriteLine($"Felicidades, has adivinado el numero secreto ({Nsecreto})");
    }
    else if (intentousuario < Nsecreto)
    {
        Console.WriteLine("El numero secreto es mayor. ¡Sigue intentando!");
    }
    else
    {
        Console.WriteLine("El numero secreto es menor. ¡Sigue intentando!");
    }
}
while (intentousuario != Nsecreto);
Console.WriteLine("Gracias por jugar <3");