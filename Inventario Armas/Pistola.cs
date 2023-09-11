using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Armas
{
    class Pistola : Arma
    {
        private float dmg, aVelocidad, precio;
        private string nombre;
        private int balas;

        public Pistola(float dmg, float aVelocidad, float precio, string nombre, int balas)
        {
            this.dmg = dmg;
            this.aVelocidad = aVelocidad;
            this.precio = precio;
            this.balas = balas;
        }

        public override float DPS()
        {
            return dmg * aVelocidad;
        }
    }
}
