using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Shop
    {
       
        public string[] weaponarray = new string[3];

        Random random = new Random();
        public virtual void SoldItem(Character Buyer)
        {
            Buyer.getGoldAmount -= 5;
        }

        public void FillShop()
        {
            for (int i = 0; i < weaponarray.Length; i++)
            {
                if (random.Next(0, 5) == 1)
                {
                 weaponarray[i] = "Dagger";
                }
                else if (random.Next(0, 5) == 2)
                {
                    weaponarray[i] = "LongSword";
                }
                else if (random.Next(0, 5) == 3)
                {
                    weaponarray[i] = "Rifle";
                }
                else if (random.Next(0, 5) == 4)
                {
                    weaponarray[i] = "LongBow";
                }
            }

           
        }

        public Weapon RandomWeapon()
        {
            
            int type = random.Next(0, 4);

            switch (type)
            {
                case 0:
                    return new MeleeWeapon(MeleeWeapon.Weapons.Dagger);
                case 1:
                    return new MeleeWeapon(MeleeWeapon.Weapons.Longsword);
                case 2:
                    return new RangedWeapon(RangedWeapon.Weapons.Rifle);
                case 3:
                    return new RangedWeapon(RangedWeapon.Weapons.Longbow);
                default:
                    return null;
            }
        }
    } 

}     



