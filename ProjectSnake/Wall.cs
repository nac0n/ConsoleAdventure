﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectSnake
{
    //Wall object in world. Unpassable! Unbreakable!
    public class Wall : IObject, IHasPosition
    {
        public int posX;
        public int posY;
        public int prevPosX;
        public int prevPosY;
        private int giveHP = 0;
        private bool hasCollided;

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


        float IObject.expModifier
        {
            get { return 0; }

        }

        int IObject.giveHP
        {
            get { return giveHP; }

        }

        bool IObject.IsDestructable
        {
            get
            {
                return false;
            }
        }

        bool IObject.IsObtainable
        {
            get
            {
                return false;
            }
        }

        bool IObject.IsPassable
        {
            get
            {
                return false;
            }
        }
        bool IObject.IsMoveable
        {
            get
            {
                return false;
            }
        }
        bool IObject.HasCollided
        {
            get
            {
                return hasCollided;
            }

            set
            {
                hasCollided = value;
            }
        }
        //bool IObject.IsCollideable
        //{
        //    get
        //    {
        //        return true;
        //    }
        //}

    }
}
