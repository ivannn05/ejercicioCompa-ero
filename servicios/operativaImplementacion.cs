using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDeCreacionPropia.servicios
{
    internal class operativaImplementacion : operativaInterfaz
    {
        int cantidadTotal;
        public int anyadirDinero()
        {
            int cantidadSeleccionada;

          Console.WriteLine("\t ¿Cuanto dinero quiere añadir? ");
            cantidadSeleccionada =Convert.ToInt32(Console.ReadLine());

            cantidadTotal = cantidadTotal + cantidadSeleccionada;
            Console.WriteLine("#########################################################");
            Console.WriteLine("\t Se añadio"+" " + cantidadSeleccionada+" "+ "euros en la cuenta.");

            Console.WriteLine("#########################################################");
            return cantidadTotal;

        }

        public int eliminarDinero()
        {
            int cantidadSeleccionada;
            Console.WriteLine("\t ¿Cuanto dinero quiere retirar? ");
            cantidadSeleccionada = Convert.ToInt32(Console.ReadLine());

            cantidadTotal = cantidadTotal - cantidadSeleccionada;
            Console.WriteLine("#########################################################");
            Console.WriteLine("\t Se retiro" + " " + cantidadSeleccionada + " " + "euros de la cuenta.");
            Console.WriteLine("#########################################################");
            return cantidadTotal;
        }
       
        public int verDinero()
        {
            Console.WriteLine("#########################################################");
            Console.WriteLine("\tDinero restante en la cuenta:" + cantidadTotal);
            Console.WriteLine("#########################################################");

            return cantidadTotal;
        }
    }
}
