using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private int Edad;
        private string Cedula;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public string Cedula1 { get => Cedula; set => Cedula = value; }

        Persona[] GrupoPersona =
        {
            new Persona(){Nombre= "Alex", Apellido = "Rodriguez", Edad = 18, Cedula="0011313131033i" },
            new Persona(){Nombre= "Dara", Apellido = "Garcia", Edad = 18, Cedula="0011313131033i" },
            new Persona(){Nombre= "Jasser", Apellido = "Romero", Edad = 18, Cedula="0011313131033i" },
            new Persona(){Nombre= "Yader", Apellido = "Mendez", Edad = 18, Cedula="0011313131033i" },
            new Persona(){Nombre= "Juan", Apellido = "Morales", Edad = 18, Cedula="0011313131033i" }
        };



    }

    


}
