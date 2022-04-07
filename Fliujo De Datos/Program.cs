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
                    streamWriter.Write("Omg you are gay");

                }

                using (FileStream fs = new FileStream("Prueba.txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.WriteLine(sr.ReadToEnd());


                        sr.ReadToEnd();
                    }
                }

                //using (StreamReader sr = new StreamReader(fileStream))
                //{
                //    sr.ReadToEnd();
                //}

            }





            //Console.WriteLine("Hello World!");
        }
    }
}
