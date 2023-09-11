using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Armas
{
    class Hacha : Arma
    {
        private float dmg, aVelocidad, precio;
        private string nombre;

        public Hacha(float dmg, float aVelocidad, float precio, string nombre)
        {
            this.dmg = dmg;
            this.aVelocidad = aVelocidad;
            this.precio = precio;
            this.nombre = nombre;
        }

        public override float DPS()
        {
            return dmg * aVelocidad;
        }
    }
}
