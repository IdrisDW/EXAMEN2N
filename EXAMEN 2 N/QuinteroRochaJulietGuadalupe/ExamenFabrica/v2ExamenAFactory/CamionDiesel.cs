using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2ExamenAFactory
{
    public class CamionDiesel : Camion
    {

        public CamionDiesel(string marca, string gremio, double pasaje, string anio, string placa, int capacidad) : base(marca,gremio,pasaje,anio,placa,capacidad ) { }
        public override void mostrarCaracteristicas()
        {
            MessageBox.Show("Camion Diesel de MARCA: " + marca + " de gremio: " + gremio + " de pasaje: " + pasaje + " del anio: " + anio + " de placas: " + placa + " de capacidad: " + capacidad);

        }
    }

}