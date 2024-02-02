using ejercicioDeCreacionPropia.servicios;

namespace ejercicioDeCreacionPropia.controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* 
            Concepto:Repasar el pasar y recoger una variable para usarla en otro metodo.  
              
            Cree una aplicacion con toda la estructura vista en clase.
            Donde el usuario tendra un menu de una tienda donde podra elegir
            si quiere añadir dinero a la cuenta , restar dinero a la cuenta,
            o ver todo el dinero que tiene en ella y ademas podra cerrar el menu
            con una opcion.

            Las cantidades de dinero de la cuenta se guardaran hasta que se cierre la aplicacion.
            tendran que especificar cuanto es el dinero que esta añadiendo o eliminando en la cuenta.
            Ejemplo:

            #########################################
            -Añadir dinero:
            ¿Cuanto dinero quiere añadir?
            10
            Se añadio 10 euros a la cuenta.
            #########################################
            -------------------------------------------
            #########################################
            -Retirar dinero:
            ¿Cuanto dinero quiere retirar?
            5
            Se retiro 5 euros de la cuenta.
            #########################################
            -------------------------------------------
            #########################################
            
            -Dinero restante en la cuenta:5

            #########################################
            
            Aclaracion:Debe haber una clase para el menu y otra para las operaciones, y toda las operaciones se haran con numero enteros. 
             */

            menuInterfaz mi = new menuImplementacion();
            operativaInterfaz op = new operativaImplementacion();
            int opcion;
            bool cerrarMenu = false;
            while (!cerrarMenu)
            {
               opcion= mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcion);
                switch (opcion)
                {
                    case 0:
                        cerrarMenu= true;
                        break;
                    case 1:
                        op.anyadirDinero();
                        break;
                    case 2:
                        op.eliminarDinero();
                        break;
                    case 3:
                        op.verDinero();
                        break;
                }

            }
           

        }
    }
}
