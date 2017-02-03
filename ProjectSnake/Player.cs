using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectSnake
{
    //Player in world, inherits from superclass Creature.cs
    public class Player : Creature
    {
        private int currentExp;
        private int maxExp;
        private double MaxExpModifier;

        public Player()
        {
            sprite = "@";
            currentExp = 0;
            color = ConsoleColor.Yellow;
            SetLevel(1);
            SetMaxHealth(20);
            SetCurrentHealth(10);
            SetDamage(2);
        }

        public Player(int posX, int posY)
        {
            sprite = "@";
            currentExp = 0;
            color = ConsoleColor.Yellow;
            SetPosX(posX);
            SetPosY(posY);
            SetLevel(1);
            SetMaxHealth(20);
            SetCurrentHealth(10);
            SetDamage(2);
        }
        
        public void LevelUp()
        {
            int currentLevel = GetLevel();
            SetLevel(currentLevel + 1);
            double temp = maxExp * MaxExpModifier;
            maxExp = (int)temp;
            currentExp = 0;
        }

        public void GiveExp(Monster m)
        {
            currentExp = m.GetMaxHealth() + m.GetLevel();
        }

        public int GetMaxExp()
        {
            return maxExp;
        }

        public double GetMaxExpModifier()
        {
            return MaxExpModifier;
        }
        
    }
}
