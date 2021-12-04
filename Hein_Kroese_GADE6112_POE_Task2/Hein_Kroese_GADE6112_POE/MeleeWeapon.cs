using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class MeleeWeapon : Weapon
    {   public enum Weapons { Dagger, Longsword} 
        protected MeleeWeapon(int x, int y, char symbol) : base(x,y,symbol)
        {
            if (Type == "Dagger")
            {
                Damage = 3;
                Durability = 10;
                Cost = 3;
            }
            else
            {
                Damage = 4;
                Durability = 6;
                Cost = 5;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
