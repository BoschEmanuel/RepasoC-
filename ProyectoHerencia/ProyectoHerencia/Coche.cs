using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    public class Coche : Vehiculo
    {
        public Coche() { }


        public override void conducir(string destino)
        {
            if (validarDestino(destino))
            {
                base.conducir(destino + " por ruta 9");
            }
            else
            {
                Console.WriteLine("No se puede llegar al destino en coche.");
            }

        }

        private bool validarDestino(string destino)
        {
            if (destino == "aire")
            {
                return false;
            }
            return true;
        }
    }
}
