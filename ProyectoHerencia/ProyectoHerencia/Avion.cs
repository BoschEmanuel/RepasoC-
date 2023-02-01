using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    public class Avion : Vehiculo
    {
        public override void conducir(string destino)
        {
            if (validarDestino(destino))
            {
                base.conducir(destino + "por el aeropuerto andino");
            }
            else
            {
                Console.WriteLine("No se puede llegar al destino en avion ya que no posee aeropuerto");
            }

        }

        private bool validarDestino(string destino)
        {
            if (destino == "tierra")
            {
                return false;
            }
            return true;
        }
    }
}
