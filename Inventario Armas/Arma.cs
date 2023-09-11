using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Armas
{
    class Arma
    {
        protected string nombre;
        protected float dmg;
        protected float aVelocidad;
        protected float precio;

        public Arma(string nombre, float dmg, float aVelocidad, float precio) : base(precio)
        {
            this.nombre = nombre;
            this.dmg = dmg;
            this.precio = precio;

        }
        public virtual float DPS()
        {
            return dmg * aVelocidad;
        }
    }
}
