using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    abstract class Prendas
    {
        protected double precioBase;
        protected int cantidadDePrendas;
        protected bool esPremium;

        public Prendas(double precioBase, int cantidadDePrendas, bool esPremium)
        {
            this.precioBase = precioBase;
            this.cantidadDePrendas = cantidadDePrendas;
            this.esPremium = esPremium;
        }

        public virtual double precioFinal()
        {
            this.precioBase = this.precioBase * cantidadDePrendas;
            if (esPremium == true)
            {
                this.precioBase = this.precioBase + this.precioBase * 0.3;
            }
            return this.precioBase;
        }
        
    }
}
