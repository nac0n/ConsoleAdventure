using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectSnake
{

    //As class name suggests, contains funtions that can check for collisions.

    public static class CollisionHandler
    {

        //Initialcheck to see if collision has happened.

        public static void CollisionCheck()
        {
            for (int i = 0; i < ListHandler.GetInstance().GetAllCollideables().Count; i++)
            {
                var clist = ListHandler.GetInstance().GetAllCollideables();

                if (i != clist.Count -1)
                {
                    
                    for (int x = i+1; x < clist.Count; x++)
                    {
                        if(clist.ElementAt(i).GetPosX() == clist.ElementAt(x).GetPosX() && clist.ElementAt(i).GetPosY() == clist.ElementAt(x).GetPosX())
                        {
                            clist.ElementAt(i).SetHasCollided(true);
                            clist.ElementAt(x).SetHasCollided(true);
                            AfterCollision(clist.ElementAt(i), clist.ElementAt(x));
                        }
                    }
                }
            }
        }

        public static void AfterCollision(CollideableObject x, CollideableObject y)
        {
            var clist = ListHandler.GetInstance().GetAllCollideables();

            if (x.Destructable() || y.Destructable())
            {
                if (x.Destructable())
                {
                    RemoveObject(x);
                }
                if (y.Destructable())
                {
                    RemoveObject(y);
                }
                else
                {
                    x.SetBackPosition();
                    y.SetBackPosition();
                }
            }
            else if (x.Obtainable() || y.Obtainable())
            {
                if (x.Obtainable())
                {

                }
                if (y.Obtainable())
                {

                }
                else
                {
                    x.SetBackPosition();
                    y.SetBackPosition();
                }
            }
            else if (x.Moveable() || y.Moveable())
            {
                if (x.Moveable())
                {

                }
                if (y.Moveable())
                {

                }
                else
                {
                    x.SetBackPosition();
                    y.SetBackPosition();
                }
            }
            else if (x.Passable() || y.Passable())
            {
                if (x.Passable())
                {

                }
                if (y.Passable())
                {

                }
                else
                {
                    x.SetBackPosition();
                    y.SetBackPosition();
                }
            }
            else if (x.GetKillable() || y.GetKillable())
            {
                if (x.GetKillable())
                {
                    x.SetBackPosition();
                    y.SetBackPosition();

                    if (y.GetKillable())
                    {

                    }
                }
                if (y.GetKillable())
                {
                    x.SetBackPosition();
                    y.SetBackPosition();

                    if (x.GetKillable())
                    {
                        x.SetBackPosition();
                        y.SetBackPosition();
                    }
                }

            }
        }

        public static void RemoveObject(CollideableObject co)
        {
            if(co.Destructable())
            {
                PurgeFromWorld(co);
            }
        }

        public static void ObtainObject(CollideableObject obj1, CollideableObject obj2)
        {
            if(obj1.Obtainable())
            {
                //obj2.GiveHP();
                //obj1.GiveHP();
            }
            else if(obj2.Obtainable())
            {

            }
        }

        public static void MoveObject(CollideableObject co)
        {

        }

        public static void Kill(CollideableObject co)
        {

        }



        public static void PurgeFromWorld(CollideableObject co)
        {
            for (int i = 0; i < ListHandler.GetInstance().GetAllCollideables().Count; i++)
            {
                if(co == ListHandler.GetInstance().GetAllCollideables().ElementAt(i))
                {
                    ListHandler.GetInstance().GetAllCollideables().RemoveAt(i);
                }
            }
        }
    }
}
