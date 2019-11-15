using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2ExamenAFactory
{
    class FabricaVehiculoHibrido : IFabricaVehiculo
    {

        public Camion creaCamion(string marca, string gremio, double pasaje, string anio, string placa, int capacidad)
        {
            return new CamionHibrido(marca, gremio, pasaje, anio, placa, capacidad);
        }

        public Privado creaPrivado(string marca, string gremio, double pasaje, string anio, string placa, int capacidad)
        {
            return new PrivadoHibrido(marca, gremio, pasaje, anio, placa, capacidad);
        }


        public Ruta creaRuta(string marca, string gremio, double pasaje, string anio, string placa, int capacidad)
        {
            return new RutaHibrido(marca, gremio, pasaje, anio, placa, capacidad);
        }


        public Calafia creaCalafia(string marca, string gremio, double pasaje, string anio, string placa, int capacidad)
        {
            return new CalafiaHibrido(marca, gremio, pasaje, anio, placa, capacidad);
        }


    }
}

   