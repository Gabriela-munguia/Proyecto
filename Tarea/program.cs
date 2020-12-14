using System;

namespace cuenta
{
    class Program
    {  
              
        static void Main(string[] args)
        {
            string opcion = "";
            Cuentas cuentas = new Cuentas();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de las cuentas");
                Console.WriteLine("2 - Ingreso de efectivo");
                Console.WriteLine("3 - Salida de efectivo");
                Console.WriteLine("4 - Estado financiero de  cuenta");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        cuentas.listaCuentas();
                        break;
                    case "2":
                        cuentas.ingresoEfectivo();
                        break; 
                    case "3":
                        cuentas.Pagoefectivo();
                        break;
                    case "4":
                        cuentas.Estadofinanciero();
                        break;                       
                    default:
                    break;
                }

                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}