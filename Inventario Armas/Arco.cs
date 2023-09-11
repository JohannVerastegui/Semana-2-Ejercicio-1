using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Armas
{
    class Arco : Arma
    {
        private float dmg, aVelocidad, precio;
        private string nombre;
        private int flechas;

        public Arco(float dmg, float aVelocidad, float precio, string nombre, int flechas)
        {
            this.precio = precio;
            this.dmg = dmg;
            this.aVelocidad = aVelocidad;
            this.flechas = flechas;
        }

        public override float DPS()
        {
            return dmg * aVelocidad;
        }
    }
}
