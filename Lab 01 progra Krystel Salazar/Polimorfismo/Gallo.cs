using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_progra_Krystel_Salazar.Polimorfismo
{
    public class Gallo : IAnimal
    {
        void IAnimal.HaceSonido()
        {
            Console.WriteLine("El gallo hace kikiriki");
        }
    }
}
