using System;
using System.IO;
namespace Flujo_De_Datos
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("Prueba.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter streamWriter= new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine("Hello everyone I'm Dickson");
                }
            }





            //Console.WriteLine("Hello World!");
        }
    }
}
