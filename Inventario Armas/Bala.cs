using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Armas
{
    class Bala : Proyectil
    {
        public float dmg;
        public float precio;
        private string nombre;
        public Bala(float dmg, float precio, string nombre)
        {
            this.dmg = dmg;
            this.precio = precio;
            this.nombre = nombre;
        }
    }
}
