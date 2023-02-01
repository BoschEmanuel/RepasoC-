using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    public class Vehiculo
    {
        public Vehiculo() { }


        public void arrancarMotor()
        {
            Console.WriteLine("Se arranco el motor");
        }

        public void pararMotor()
        {
            Console.WriteLine("Se paro el motor");
        }

        public virtual void conducir(string destino)
        {
            Console.WriteLine("conduciendo hacia " + destino);
        }
    }
}
