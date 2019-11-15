using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2ExamenAFactory
{
    public interface IFabricaVehiculo
    {
        //en el examen esto iiva en la clase pizza que en nuestras clases se interpretaria como el catalogo no?.
       
       Camion creaCamion(string marca, string gremio, double pasaje, string anio, string placa, int capacidad);
       Calafia creaCalafia(string marca, string gremio, double pasaje, string anio, string placa, int capacidad);
       Privado creaPrivado(string marca, string gremio, double pasaje, string anio, string placa, int capacidad);
       Ruta creaRuta(string marca, string gremio, double pasaje, string anio, string placa, int capacidad);

        
    }
}
