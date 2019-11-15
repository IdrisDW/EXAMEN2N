using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2ExamenAFactory
{
    public class Catalogo
    {
        /*
        public static int nCamion = 3;
        public static int nRuta = 2;

            FabricaVehiculo fabrica;
            IFabricaVehiculo fabrica;
            Camion[] camiones = new Camion[nCamion];
            Ruta[] ruta = new Ruta[nRuta];


        public static string eleccion = Console.ReadLine();*/

        /*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
         * INTENTE PROBAR ESTO PARA VER QUE ONDA PERO NO ME SALIA LA CONSOLA PARA PROBAR, NO SE SI MI CEREBRO SE QUEDO TRABADO Y ES ALGO TONTO
         * AHI ME DICES
         * LA IDEA ES PONER LOS DATOS EN EL FORM, A COMO VEO LAS CLASES POR EJEMPLO EN TIPO DE AUTOMOVIL QUE YA DIGA LAS OPCIONES Y AL FINAL EN CREAR
         * SE PASAN ESOS DATOS AL CREA Y DE AHI ALA BD Y DE AHI AL DATAVIEW.
                public static void Main(String[] arg) { 

                IFabricaVehiculo fabrica;
                        //Camion[] camiones = new Camion[1];

                        Console.WriteLine("Desea utilizar " + "vehículos diesel (1) o a gasolina (2):");
                        string eleccion = Console.ReadLine();
                        if (eleccion == "1")
                        {
                            fabrica = new FabricaVehiculoDiesel();
                        }
                        else
                        {
                            fabrica = new FabricaVehiculoGasolina();
                        }
                        Console.WriteLine("tipo : ");
                        string tipo = Console.ReadLine();
                        Console.WriteLine("num : ");
                        string num = Console.ReadLine();
                        Console.WriteLine("texto : ");
                        double mas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("texto aqui : ");
                        string aqui = Console.ReadLine();
                        Console.WriteLine("texto aqui mas: ");
                        string aqui2 = Console.ReadLine();
                        Console.WriteLine("otro numero : ");
                        int Num2 = Convert.ToInt32(Console.ReadLine());


                       fabrica.creaCamion(tipo, num, mas, aqui, aqui2, Num2).mostrarCaracteristicas();
                }

            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*/


    }
}
        //
        /*
        public static int nCamion = 3; public static int nRuta = 2;
                static void Main(string[] args)
        {
            IFabricaVehiculo fabrica;
            Camion[] camiones = new Camion[nCamion];
            Ruta[] ruta = new Ruta[nRuta];
            Console.WriteLine("Desea utilizar " + "vehículos diesel (1) o a gasolina (2):");
            string eleccion = Console.ReadLine();
            if (eleccion == "1")
            {
                fabrica = new FabricaVehiculoDiesel();
            }
            else
            {
                fabrica = new FabricaVehiculoGasolina();
            }
            for (int index = 0; index < nCamion; index++)
                camiones[index] = fabrica.creaCamion("estándar", "amarillo", 6 + index, "mas", "aqui", 2);
            for (int index = 0; index < nRuta; index++)
                ruta[index] = fabrica.creaRuta("clásico", "rojo", 2 + index, "dato", "otro", 3);
            foreach (Camion auto in camiones) auto.mostrarCaracteristicas();
            foreach (Ruta scooter in ruta) scooter.mostrarCaracteristicas();
        } */
        //
  