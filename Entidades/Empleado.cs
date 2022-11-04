using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public Empleado(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Comision = 10000;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public static decimal comision = 1000;
        public static decimal Comision
        {
            get
            {
                return comision;
            }
            set
            {
                comision = value;
            }
        }
        

    }
}
