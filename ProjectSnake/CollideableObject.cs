using System;

namespace ProjectSnake
{
    public abstract class CollideableObject: IHasPosition, ICollideable, IHasProperties
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

        int IHasPosition.posX
        {
            get { return posX; }
            set { posX = value; }
        }

        int IHasPosition.posY
        {
            get { return posY; }
            set { posY = value; }
        }

        int IHasPosition.prevPosX
        {
            get { return prevPosX; }
            set { prevPosX = value; }
        }

        int IHasPosition.prevPosY
        {
            get { return prevPosY; }
            set { prevPosY = value; }
        }

        bool ICollideable.HasCollided
        {
            get { return HasCollided; }
            set { HasCollided = value; }
        }

        bool ICollideable.IsKillable
        {
            get { return IsKillAble; }
            set { IsKillAble = value; }
        }

        bool ICollideable.IsDestructable
        {
            get { return IsDestructAble; }
            set { IsDestructAble = value; }
        }

        bool ICollideable.IsObtainable
        {
            get { return IsObtainAble; }
            set { IsObtainAble = value; }
        }

        bool ICollideable.IsPassable
        {
            get { return IsPassAble; }
            set { IsPassAble = value; }
        }

        bool ICollideable.IsMoveable
        {
            get { return IsMoveAble; }
            set { IsMoveAble = value; }
        }

        float IHasProperties.expModifier
        {
            get { return expModifier; }
            set { expModifier = value; }
        }

        int IHasProperties.givenHP
        {
            get { return givenHP; }
            set { givenHP = value; }
        }

        public void SetBackPosition()
        {
            posX = prevPosX;
            posY = prevPosY;
        }
        

        public int GetPosX()
        {
            return posX;
        }
        public void SetPosX(int x)
        {
            posX = x;
        }

        public int GetPosY()
        {
            return posY;
        }
        public void SetPosY(int x)
        {
            posY = x;
        }

        public int GetPrevPosX()
        {
            return prevPosX;
        }
        public void SetPrevPosX(int x)
        {
            prevPosX = x;
        }

        public int GetPrevPosY()
        {
            return prevPosY;
        }
        public void SetPrevPosY(int x)
        {
            prevPosY = x;
        }

        public int GetMaxHealth()
        {
            return maxHealth;
        }

        public void SetMaxHealth(int x)
        {
            maxHealth = x;
        }

        public int GetCurrentHealth()
        {
            return health;
        }

        public void SetCurrentHealth(int x)
        {
            health += x;
        }

        public int GetDamage()
        {
            return damage;
        }

        public void SetDamage(int x)
        {
            damage = x;
        }

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int x)
        {
            level = x;
        }

        public bool GetHasCollided()
        {
            return HasCollided;
        }

        public void SetHasCollided(bool x)
        {
            HasCollided = x;
        }

        public bool GetKillable()
        {
            return IsKillAble;
        }

        public void SetKillable(bool x)
        {
            IsKillAble = x;
        }

        public bool Destructable()
        {
            return IsDestructAble;
        }

        public void SetDestructable(bool x)
        {
            IsDestructAble = x;
        }

        public bool Obtainable()
        {
            return IsObtainAble;
        }

        public void SetObtainable(bool x)
        {
            IsObtainAble = x;
        }

        public bool Passable()
        {
            return IsPassAble;
        }

        public void SetPassable(bool x)
        {
            IsPassAble = x;
        }

        public bool Moveable()
        {
            return IsMoveAble;
        }

        public void SetMoveable(bool x)
        {
            IsMoveAble = x;
        }

        public float GetExpModifer()
        {
            return expModifier;
        }

        public void SetExpModifer(float x)
        {
            expModifier = x;
        }

        public int Get_Amount_of_heal()
        {
            return givenHP;
        }

        public void Set_Amount_of_heal(int x)
        {

        }

        
    }
}
