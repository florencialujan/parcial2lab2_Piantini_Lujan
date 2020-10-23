using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    class Pantalones : Prendas
    {
        private bool esBermuda;
        /* protected double precioBase;
        protected int cantidadDePrendas;
        protected bool esPremium; */
        public Pantalones(double precioBase, int cantidadDePrendas, bool esPremium, bool esBermuda) : base(precioBase, cantidadDePrendas, esPremium)
        {
            this.esBermuda = esBermuda;
            this.esPremium = esPremium;
            this.cantidadDePrendas = cantidadDePrendas;
            this.precioBase = precioBase;
        }

        public override double precioFinal()
        {
            
            
            if (esBermuda == true)
            {
                precioBase = precioBase - precioBase * 0.2;
            }

            return base.precioFinal();
        }


    }
}
