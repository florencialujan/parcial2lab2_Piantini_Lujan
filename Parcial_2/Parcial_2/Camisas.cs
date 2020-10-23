using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    class Camisas : Prendas
    {
        private bool esMangaCorta;

        public Camisas(bool esMangaCorta, double precioBase, int cantidadDePrendas, bool esPremium) : base(precioBase, cantidadDePrendas, esPremium)
        {
            this.esMangaCorta = esMangaCorta;
            this.esPremium = esPremium;
            this.cantidadDePrendas = cantidadDePrendas;
            this.precioBase = precioBase;
        }

        public override double precioFinal()
        {

            if (esMangaCorta == true)
            {
                this.precioBase = this.precioBase - this.precioBase * 0.1;
            }
            
            return base.precioFinal();
        }
    }
}
