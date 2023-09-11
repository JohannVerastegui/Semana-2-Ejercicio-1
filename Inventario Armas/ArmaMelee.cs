using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Armas
{
    class ArmaMelee : Arma
    {
        public float dmg, aVelocidad;
        public override float DPS()
        {
            return dmg / aVelocidad;
        }
    }
}
