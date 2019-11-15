using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using v2ExamenAFactory.Forms;

namespace v2ExamenAFactory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
     //   [STAThread]
       static void Main()
        {



              Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
     //   static void Main()
     //   {
      //      Application.EnableVisualStyles();
      //      Application.SetCompatibleTextRenderingDefault(false);
       //     Application.Run(new Form1());



            /*  public static int nCamion = 3; public static int nRuta = 2;
             *  
             *  static void Main(string[] args)
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
                 else {
                     fabrica = new FabricaVehiculoGasolina();
                 }
                 for (int index = 0; index < nCamion; index++)
                     camiones[index] = fabrica.creaCamion("estándar", "amarillo", 6 + index, "mas", "aqui", 2);
                 for (int index = 0; index < nRuta; index++)
                     ruta[index] = fabrica.creaRuta("clásico", "rojo", 2 + index ,"dato","otro",3);
                 foreach (Camion auto in camiones) auto.mostrarCaracteristicas();
                 foreach (Ruta scooter in ruta) scooter.mostrarCaracteristicas();
             }*/
      //  }
  //  }
//}
