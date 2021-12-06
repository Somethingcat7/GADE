using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class MeleeWeapon : Weapon
    { public enum Weapons { Dagger, Longsword }

        public override int getRange { get { return 1; } }
        Random Randumb = new Random();

        public MeleeWeapon( Weapons types, int x, int y) : base(x, y, 'W')
        {

            if (types == Weapons.Dagger)
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
