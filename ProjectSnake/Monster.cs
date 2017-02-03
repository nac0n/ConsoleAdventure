using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectSnake
{
    //A monster in the world, inherits from superclass Creature.cs
    public class Monster : Creature
    {
        private int givenExp = 10;
        
        public Monster()
        {
            sprite = "M";
            color = ConsoleColor.Red;
            SetLevel(1);
            SetMaxHealth(20);
            SetCurrentHealth(20);
            SetDamage(1);

        }
        public Monster(int posX, int posY)
        {
            sprite = "M";
            color = ConsoleColor.Red;
            SetLevel(1);
            SetMaxHealth(20);
            SetCurrentHealth(20);
            SetDamage(1);
            SetPosX(posX);
            SetPosY(posY);
        }

        public void LevelUp()
        {
            //Do a check later if player has finished level or not
            //if(course > level) { levelup()  };

            SetLevel(GetLevel() + 1);
            givenExp *= GetLevel();
            SetMaxHealth(GetMaxHealth() + 10);
            SetCurrentHealth(GetMaxHealth());
            SetDamage(GetDamage() + 2);
        }

    }
}

    
