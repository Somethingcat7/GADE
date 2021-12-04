using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class RangedWeapon : Weapon
    {   public enum Weapons { Rifle, Longbow}
        protected RangedWeapon(int x, int y, char symbol) : base(x, y, symbol)
        {
            if (Type == "Rifle")
            {
                Damage = 5;
                Durability = 3;
                Cost = 7;
                Range = 5;
            }
            else
            {
                Damage = 4;
                Durability = 4;
                Cost = 6;
                Range = 2;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
