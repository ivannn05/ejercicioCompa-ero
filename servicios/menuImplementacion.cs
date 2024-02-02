using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDeCreacionPropia.servicios
{
    internal class menuImplementacion : menuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion;
            Console.WriteLine("Introduzca la opcion a elegir");
            Console.WriteLine("0.Cerrar aplicacion");
            Console.WriteLine("1.Añadir dinero");
            Console.WriteLine("2.Retirar dinero");
            Console.WriteLine("3.Ver dinero total");
            opcion=Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
