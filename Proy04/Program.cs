internal class Program
{
    private static void Main(string[] args)
    {
        int secretNumber = new Random().Next(1, 100);
        ushort attempts = 0;
        Console.Clear();
        Console.WriteLine($"Adivine el numero secreto entre 1 y 100. En el menor numero de intentos: ");
        Console.WriteLine($"Para Salir sin adivinar digite 0 ");
        ushort userNumber = 1000;
        Console.Write($"Ingrese el numero => ");
        do
        {
            try
            {
                userNumber = ushort.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Debe Ingresar Numeros.");
                // Console.WriteLine($"error {error} ");
            }
            
            if (userNumber == 0) break;
            attempts++;
            if (userNumber > secretNumber)
                Console.WriteLine($"Intento {attempts}. El numero ingresado es mayor que el numero secreto. ");
            if (userNumber < secretNumber)
                Console.WriteLine($"Intento {attempts}. El numero ingresado es menor que el numero secreto. ");

        } while (userNumber != secretNumber);
        if (userNumber == 0)
            Console.WriteLine($"Ni en {attempts} intento(s) pudiste adivinar. El numero era {userNumber} ");
        else
            Console.WriteLine($"Felicitaciones! Completaste el juego en {attempts} intento(s). ");
    }
}