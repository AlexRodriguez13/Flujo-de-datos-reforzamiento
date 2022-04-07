using System;
using System.IO;
using Model;
namespace Flujo_De_Datos

{
    class Program
    {
        public static void Main(string[] args)
        {

            Persona[] GrupoPersona = Persona.GetPersonas();

            //using (FileStream fileStream = new FileStream("Prueba.txt", FileMode.Create, FileAccess.ReadWrite))
            //{
            //    using (StreamWriter streamWriter = new StreamWriter(fileStream))
            //    {
            //        foreach (Persona persona in GrupoPersona)
            //        {
            //            streamWriter.Write(persona.Nombre1);
            //            streamWriter.Write(persona.Apellido1);
            //            streamWriter.Write(persona.Edad1);
            //            streamWriter.Write(persona.Cedula1);
            //        }

            //    }

                using (FileStream fs = new FileStream("Prueba.txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {

                    string linea;

                    while ((linea= sr.ReadLine())  != null)
                    {
                        if (linea.Contains("A"))
                        {
                            Console.WriteLine(linea);
                        }
                    }
                   
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



