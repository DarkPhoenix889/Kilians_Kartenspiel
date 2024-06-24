using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilians_Klaustrophobisches_Kartenspiel
{
    internal class MonsterCard
    {
        public int Atk;
        public int Hp;
        public int Mana;
        
        

        public MonsterCard(int hp, int atk, int mana)
        {
            Hp = hp; Atk = atk; Mana = mana;
        }
     

    }
}
