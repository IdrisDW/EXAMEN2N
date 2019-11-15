using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2ExamenAFactory
{
    public class FabricaVehiculoGasolina : IFabricaVehiculo
    {

        public Camion creaCamion(string marca, string gremio, double pasaje, string anio, string placa, int capacidad) 
        {
            return new CamionGasolina(marca, gremio, pasaje, anio,placa,capacidad);
        }

        public Privado creaPrivado(string marca, string gremio, double pasaje, string anio, string placa, int capacidad)
        {
            return new PrivadoGasolina(marca, gremio, pasaje, anio, placa, capacidad);
        }


        public Ruta creaRuta(string marca, string gremio, double pasaje, string anio, string placa, int capacidad)
        {
            return new RutaGasolina(marca, gremio, pasaje, anio, placa, capacidad);
        }


        public Calafia creaCalafia(string marca, string gremio, double pasaje, string anio, string placa, int capacidad)
        {
            return new CalafiaGasolina(marca, gremio, pasaje, anio, placa, capacidad);
        }


    }
}
