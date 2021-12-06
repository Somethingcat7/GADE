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
        public Character Buyer;
        public Character buyer { set { value = Buyer; } get { return Buyer; } }
        public Shop()
        {
            Buyer = new Hero(0,0);
        }

        Random random = new Random();
        public void Buy(int num)
        {
            num -= 5;
        }

        public bool CanBuy(int num)
        {
            if (Buyer.getGoldAmount < num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string DisplayWeapon(int num)
        {
            return "Buy Weapon type " + num.ToString();
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
                    return new MeleeWeapon(MeleeWeapon.Weapons.Dagger,0,0);
                case 1:
                    return new MeleeWeapon(MeleeWeapon.Weapons.Longsword,0,0);
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



