using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Player
    {

        float hp, atk, dmg, def, spd, crtrate, crtdmg;
        int inv, money;
        string name;
        ArrayList invertory;

        public Player()
        {
            hp = 100;
            atk = 1;
            dmg = 10;
            def = 1;
            spd = 1;
            crtrate = 30;
            crtdmg = 50;
            inv = 10;
            money = 0;
            name = "player";
        }

        int Damage()
        {
            Random rnd = new Random();
            if (crtrate < rnd.Next(100))
            {
                return (int)((atk * 0.1 * dmg) * (1 + (0.01 * crtdmg)));
            }
            else return (int)(atk * 0.1 * dmg);

        }
    }
}
