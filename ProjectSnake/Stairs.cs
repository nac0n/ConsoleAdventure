using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSnake
{
    //Stairs object in the world. Ends the game and is gonna
    //  bring the player to the next level in other versions.
    public class Stairs : CollideableObject
    {
        private int posX;
        private int posY;
        private int prevPosX;
        private int prevPosY;
        private int maxHealth;// { get; set; }
        private int health;// { get; set; }
        private int damage;// { get; set; }
        private int level; // { get; set; }
        private bool HasCollided; // { get; set; }

        private bool IsKillAble; // { get; set;}
        private bool IsDestructAble; // { get; set;}
        private bool IsObtainAble; // { get; set;}
        private bool IsPassAble; // { get; set; }
        private bool IsMoveAble; // { get; set; }
        private float expModifier; // { get; set; }
        private int givenHP; // { get; set; }
    }
}
