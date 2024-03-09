using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_01_progra_Krystel_Salazar.Encapsulamiento
{
    internal class Trabajador
    {
        private int Id;
        private string Nombre;
        private string Tipo_Trabajo;

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string nombre
        {
                get { return Nombre; }
                set { Nombre = value; }    
        }
        public string tipo_Trabajo
        {
            get { return Tipo_Trabajo; }
            set { Tipo_Trabajo = value; }
        }
    }
}
