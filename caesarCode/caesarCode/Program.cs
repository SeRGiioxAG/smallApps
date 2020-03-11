using System;

namespace Ejercicio1
{
    class Program
    {
        //Variables globales.
        public static readonly char[] abecedario = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static string fraseSinCifrar;
        public static int numeroDesplazamiento;

        static void Main(string[] args)
        {
            // Una simple bienvenida al programa.
            Console.WriteLine("¿Quiere encriptar un texto? Recuerde que tan solo se cifrarán caracteres del abecedario. [Sí/No]");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "si" || respuesta.ToLower() == "sí")
            {
                Console.WriteLine("Accediendo al procedimiento de encriptación...");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                cifrarTexto();
            }
            if (respuesta.ToLower() == "no")
            {
                Console.WriteLine("\n");
                Console.WriteLine("El programa se cerrará automáticamente en 5 segundos. Gracias por utilizarlo.");
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }

        public static void textoParaCifrar()
        {
            // Pedimos la frase que quiere cifrar junto con el número de desplazamientos. Le limitamos ya que con 25 desplazamientos es más que suficiente y si usásemos 26 saldría la misma frase.
            fraseSinCifrar = Console.ReadLine();
            fraseSinCifrar = fraseSinCifrar.ToLower();
            // Limitamos la respuesta del usuario únicamente a letras.
            if (fraseSinCifrar.Contains(",") || fraseSinCifrar.Contains(".") || fraseSinCifrar.Contains(";") || fraseSinCifrar.Contains(":") || fraseSinCifrar.Contains("-") || fraseSinCifrar.Contains("_") || fraseSinCifrar.Contains("\"") || fraseSinCifrar.Contains("*") || fraseSinCifrar.Contains("+") || fraseSinCifrar.Contains("¿") || fraseSinCifrar.Contains("?") || fraseSinCifrar.Contains("!") || fraseSinCifrar.Contains("¡") || fraseSinCifrar.Contains("\\") || fraseSinCifrar.Contains("0") || fraseSinCifrar.Contains("1") || fraseSinCifrar.Contains("2") || fraseSinCifrar.Contains("3") || fraseSinCifrar.Contains("4") || fraseSinCifrar.Contains("5") || fraseSinCifrar.Contains("6") || fraseSinCifrar.Contains("7") || fraseSinCifrar.Contains("8") || fraseSinCifrar.Contains("9") || fraseSinCifrar.Contains("ñ"))
            {
                Console.WriteLine("Recuerde introducir ÚNICAMENTE caracteres incluidos en el abecedario. [No estan incluidos números, símbolos ni la \"n\".]");
                cifrarTexto();
            }
            Console.WriteLine("¿Cuántos desplazamientos quiere realizar? (Entre 1 y 25): ");
            numeroDesplazamiento = int.Parse(Console.ReadLine());
            while (numeroDesplazamiento < 1 || numeroDesplazamiento > 25)
            {
                Console.WriteLine("Valor no admitido.\nPor favor establezca un desplazamiento entre 1 y 25:");
                numeroDesplazamiento = int.Parse(Console.ReadLine());
            }
        }

        public static void cifrarTexto()
        {
            Console.WriteLine("Por favor, introduzca la frase que quiera cifrar:");
            textoParaCifrar();
            // Ahora pasamos la frase introducida por el usuario a un array de chars, para que cada uno de estos pueda realizar los desplazamientos posteriormente.
            char[] fraseEnChar = fraseSinCifrar.ToCharArray();
            char[] fraseEncriptada = new char[fraseEnChar.Length];
            for (int i = 0; i < fraseEnChar.Length; i++) // Creamos un bucle que tan solo se repetirá tantas veces como char tenga nuestra frase/mensaje.
            {
                char itemEncriptado = fraseEnChar[i]; // Con esto vamos almacenando la posición del char en el array "fraseEnChar". Lo pasaremos a la variable char "itemEncriptado", para poder realizar el desplazamiento de forma individual. Por cada repetición del bucle este avanzará en su posición.
                // Un if para que muestre los espacios correctamente a la hora de sacar el texto encriptado por pantalla.
                if (itemEncriptado == ' ')
                {
                    continue;
                }
                int index = Array.IndexOf(abecedario, itemEncriptado); // En esta línea buscamos el char "itemEncriptado" en nuestro "abecedario" y nos guarda en "index" la posición de ese valor dentro del abecedario.
                int posicionLetra = (index += numeroDesplazamiento) % 26; // Aquí lo que hacemos es almacenar la posición del char ya encriptado en "posicionLetra". El char ya está encriptado porque hemos cogido el "index" y le hemos sumado el "numeroDesplazamiento" determinado por el usuario.
                char charEncriptado = abecedario[posicionLetra]; // Pasamos el nuevo char (ya encriptado) a la variable "charEncriptado". Con el final de la línea indicamos la nueva posición de ese char en nuestro "abecedario", el cual hemos conseguido en la línea anterior.
                fraseEncriptada[i] = charEncriptado; // Aquí vamos guardando en el array "fraseEncriptada" el "charEncriptado", resultante de esa repetición del bucle. Con cada una de ellas iremos almacenando un nuevo valor en el array de "fraseEncriptada".
            }

            string encriptacionFinal = String.Join("", fraseEncriptada); //Concatenamos en forma de string todos los char que conforman nuestra frase.
            Console.Write("\nTexto encriptado con un desplazamiento de " + numeroDesplazamiento + " saltos:\n" + encriptacionFinal + "\n"); //Imprimimos por consola el resultado de la concatenación de chars, la cual forma nuestro string.
            Console.WriteLine("\n");
            Console.WriteLine("El programa se cerrará automáticamente en 5 segundos. Gracias por utilizarlo.");
            System.Threading.Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}
