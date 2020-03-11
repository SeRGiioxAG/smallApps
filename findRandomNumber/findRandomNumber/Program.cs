using System;

namespace findRandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa servirá para comprobar si es capaz de adivinar un número aleatorio.\n");
            Random numero = new Random();

            int numIntento = 0;
            int numeroIntroducido = 120;
            int numeroAleatorio = numero.Next(0, 100);
            while (numeroAleatorio >= 0 && numeroAleatorio <= 100)
            {
                Console.WriteLine("Introduzca un número comprendido entre el 0 al 100. \nLe ayudaremos estableciendo si el número escogido es mayor o menor.");
                numeroIntroducido = int.Parse(Console.ReadLine());

                if (numeroIntroducido < numeroAleatorio)
                {
                    Console.WriteLine("El número que busca es mayor al introducido.\n\n");
                    System.Threading.Thread.Sleep(7000);
                    Console.Clear();
                    numIntento++;
                }

                if (numeroIntroducido > numeroAleatorio)
                {
                    Console.WriteLine("El número que busca es menor al introducido.\n\n");
                    System.Threading.Thread.Sleep(5000);
                    Console.Clear();
                    numIntento++;
                }

                if (numeroAleatorio == numeroIntroducido)
                {
                    Console.WriteLine("Bien hecho, ha adivinado usted el número.\nHa necesitado " + numIntento + " intentos");
                    break;
                }

            }


        }
    }
}
