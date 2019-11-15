using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2ExamenAFactory
{
    public abstract class Privado
    {
        protected string marca;
        protected string gremio;
        protected double pasaje;
        protected string anio;
        protected string placa;
        protected int capacidad;

        public Privado(string marca, string gremio, double pasaje, string anio,string placa,int capacidad)
        {
            this.marca = marca;
            this.gremio = gremio;
            this.pasaje = pasaje;
            this.anio = anio;
            this.placa = placa;
        }
        public abstract void mostrarCaracteristicas();
    }
}