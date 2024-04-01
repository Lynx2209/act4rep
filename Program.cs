using System.Reflection.Metadata;

namespace ejercicio4rep
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Numero de la linea: ");
            int linea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Posicion: ");
            int posicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Texto a insertar: ");
            string texto = Console.ReadLine();

            StreamWriter sw;
            sw = File.CreateText("fichero.txt");
            for (int i = 0; i < linea; i++)
            {
                sw.WriteLine("");
            }
            for (int j = 0; j < posicion; j++)
            {
                sw.Write(" ");
            }
            sw.WriteLine(texto);
            sw.Close();
            Console.WriteLine("Ingresado con exito");
        }
    }
}