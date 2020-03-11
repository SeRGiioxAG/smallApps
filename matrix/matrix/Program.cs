using System;

namespace matrix
{
    class Program
    {
        //Creación de la matriz en un ámbito global para que esta pueda ser usada en todos los métodos.
        static int[,] matriz = new int[3, 3];
        //Creación de variables usadas en los 2 últimos métodos.
        static string mostrarMatriz = "no";
        static string respuestaModificacion;

        static void Main(string[] args)
        {
            creaciónMatriz();
            repeticionMatriz();
        }

        static void creaciónMatriz()
        {
            //Seteo de valores predeterminados:
            //Fila 1
            matriz[0, 0] = 0;
            matriz[0, 1] = 0;
            matriz[0, 2] = 0;
            //Fila 2
            matriz[1, 0] = 0;
            matriz[1, 1] = 0;
            matriz[1, 2] = 0;
            //Fila 3
            matriz[2, 0] = 0;
            matriz[2, 1] = 0;
            matriz[2, 2] = 0;

            //Creación de la PRIMERA fila de la matriz. Los while se utilizan para que el usuario TAN SOLO pueda introducir un valor del 0 al 9.
            Console.WriteLine("Inserte los valores que quiere añadir a la primera fila de su matriz.");
            Console.WriteLine("Columna 1:");
            matriz[0, 0] = int.Parse(Console.ReadLine());
            while (matriz[0, 0] > 9 || matriz[0, 0] < 0)
            {
                Console.WriteLine("Valor introducido no disponible, por favor introduzca un valor de una única cifra en la columna 1.");
                matriz[0, 0] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Columna 2:");
            matriz[0, 1] = int.Parse(Console.ReadLine());
            while (matriz[0, 1] > 9 || matriz[0, 1] < 0)
            {
                Console.WriteLine("Valor introducido no disponible, por favor introduzca un valor de una única cifra en la columna 2.");
                matriz[0, 1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Columna 3:");
            matriz[0, 2] = int.Parse(Console.ReadLine());
            while (matriz[0, 2] > 9 || matriz[0, 2] < 0)
            {
                Console.WriteLine("Valor introducido no disponible, por favor introduzca un valor de una única cifra en la columna 3.");
                matriz[0, 2] = int.Parse(Console.ReadLine());
            }
            //Creación de la SEGUNDA fila de la matriz. Los while se utilizan para que el usuario TAN SOLO pueda introducir un valor del 0 al 9.
            Console.WriteLine("");
            Console.WriteLine("Inserte los valores que quiere añadir a la segunda fila de su matriz.");
            Console.WriteLine("Columna 1:");
            matriz[1, 0] = int.Parse(Console.ReadLine());
            while (matriz[1, 0] > 9 || matriz[1, 0] < 0)
            {
                Console.WriteLine("Valor introducido no disponible, por favor introduzca un valor de una única cifra en la columna 1.");
                matriz[1, 0] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Columna 2:");
            matriz[1, 1] = int.Parse(Console.ReadLine());
            while (matriz[1, 1] > 9 || matriz[1, 1] < 0)
            {
                Console.WriteLine("Valor introducido no disponible, por favor introduzca un valor de una única cifra en la columna 2.");
                matriz[1, 1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Columna 3:");
            matriz[1, 2] = int.Parse(Console.ReadLine());
            while (matriz[1, 2] > 9 || matriz[1, 2] < 0)
            {
                Console.WriteLine("Valor introducido no disponible, por favor introduzca un valor de una única cifra en la columna 3.");
                matriz[1, 2] = int.Parse(Console.ReadLine());
            }
            //Creación de la TERCERA fila de la matriz. Los while se utilizan para que el usuario TAN SOLO pueda introducir un valor del 0 al 9.
            Console.WriteLine("");
            Console.WriteLine("Inserte los valores que quiere añadir a la tercera fila de su matriz.");
            Console.WriteLine("Columna 1:");
            matriz[2, 0] = int.Parse(Console.ReadLine());
            while (matriz[2, 0] > 9 || matriz[2, 0] < 0)
            {
                Console.WriteLine("Valor introducido no disponible, por favor introduzca un valor de una única cifra en la columna 1.");
                matriz[2, 0] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Columna 2:");
            matriz[2, 1] = int.Parse(Console.ReadLine());
            while (matriz[2, 1] > 9 || matriz[2, 1] < 0)
            {
                Console.WriteLine("Valor introducido no disponible, por favor introduzca un valor de una única cifra en la columna 2.");
                matriz[2, 1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Columna 3:");
            matriz[2, 2] = int.Parse(Console.ReadLine());
            while (matriz[2, 2] > 9 || matriz[2, 2] < 0)
            {
                Console.WriteLine("Valor introducido no disponible, por favor introduzca un valor de una única cifra en la columna 3.");
                matriz[2, 2] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("Estamos creando su matriz, espere unos instantes...");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
        }

        static void repeticionMatriz()
        {
            Console.WriteLine("¿Quiere visualizar la matriz resultante? [Sí/No]");
            mostrarMatriz = Console.ReadLine();
            Console.WriteLine("");

            if (mostrarMatriz.ToLower().Contains("s"))
            {
                //Representación de la primera línea incluyendo el "Enter" de separación.
                Console.Write(matriz[0, 0] + " ");
                Console.Write(matriz[0, 1] + " ");
                Console.WriteLine(matriz[0, 2]);
                //Representación de la segunda línea.
                Console.Write(matriz[1, 0] + " ");
                Console.Write(matriz[1, 1] + " ");
                Console.WriteLine(matriz[1, 2]);
                //Representación de la tercera línea.
                Console.Write(matriz[2, 0] + " ");
                Console.Write(matriz[2, 1] + " ");
                Console.WriteLine(matriz[2, 2]);
                Console.WriteLine("");

            }
            modificarMatriz();
        }

        static void modificarMatriz()
        {
            // Preguntamos al usuario si quiere visualizar la matriz.
            Console.WriteLine("¿Desea eliminar algún valor de la matriz? [Sí/No]");
            respuestaModificacion = Console.ReadLine();
            if (respuestaModificacion.ToLower().Contains("n"))
            {
                Console.WriteLine("");
                Console.WriteLine("Muchísimas gracias por usar el programa. Tenga un buen día.");
            }
            else // En caso de que responda algo contrario a "no" pasamos a ejecutar el método recopilacionDatosMatriz();
            {
                int[] datos = recopilacionDatosMatriz();
                int fila = datos[0]; // El primer valor de nuestro array "datos" es la fila, por lo tanto lo establecemos en una nueva variable.
                int columna = datos[1]; // El segundo valor de nuestro array "datos" es la columna, por lo tanto lo establecemos en una nueva variable.
                matriz[fila, columna] = 0; // Seteamos la fila y columna especificadas en las líneas anteriores a 0, así eliminando esa posición exacta en nuestra matriz bidireccional.
                repeticionMatriz();
            }
        }

        static int[] recopilacionDatosMatriz()
        {
            Console.Clear();
            //Detección de fila y columna mediante un ReadLine.
            Console.WriteLine("De acuerdo, ¿qué fila y columna desea eliminar?");
            Console.WriteLine("Fila:");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Columna:");
            int columna = int.Parse(Console.ReadLine());
            // Tan solo permitimos al usuario introducir un valor del 1 al 3 en ambas variables.
            if ((fila > 3 || fila < 1) || (columna > 3 || columna < 1))
            {
                Console.WriteLine("Por favor, introduzca un valor del 1 al 3. Tanto en \"fila\" como en \"columna\".");
                Console.WriteLine("Intentelo de nuevo en 5 segundos.");
                System.Threading.Thread.Sleep(5000);
                return recopilacionDatosMatriz();
            }
            // Devolvemos los valores restando una unidad a cada uno, por lo tanto si el usuario elige la primera fila (1) realmente se estará refiriendo a la fila 0 en nuestra matriz.
            return new int[] { fila - 1, columna - 1 };
        }
    }
}
