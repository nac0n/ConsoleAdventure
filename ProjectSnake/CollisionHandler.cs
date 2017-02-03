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
                            //clist.ElementAt(i).HasCollided = true;
                            //clist.ElementAt(x).HasCollided = true;
                            AfterCollision(clist.ElementAt(i), clist.ElementAt(x));
                        }
                    }
                }
            }
        }

        public static void AfterCollision(CollideableObject x, CollideableObject y)
        {
            var clist = ListHandler.GetInstance().GetAllCollideables();

            if (x.GetDestructable() || y.GetDestructable())
            {
                if (x.GetDestructable())
                {
                    RemoveObject(x);
                }
                if (y.GetDestructable())
                {
                    RemoveObject(y);
                }
                else
                {
                    x.SetBackPosition();
                    y.SetBackPosition();
                }
            }
            else if (x.GetObtainable() || y.GetObtainable())
            {
                if (x.GetObtainable())
                {

                }
                if (y.GetObtainable())
                {

                }
                else
                {
                    x.SetBackPosition();
                    y.SetBackPosition();
                }
            }
            else if (x.GetMoveable() || y.GetMoveable())
            {
                if (x.GetMoveable())
                {

                }
                if (y.GetMoveable())
                {

                }
                else
                {
                    x.SetBackPosition();
                    y.SetBackPosition();
                }
            }
            else if (x.GetPassable() || y.GetPassable())
            {
                if (x.GetPassable())
                {

                }
                if (y.GetPassable())
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
            if(co.GetDestructable())
            {
                PurgeFromWorld(co);
            }
        }

        public static void ObtainObject(CollideableObject obj1, CollideableObject obj2)
        {
            if(obj1.GetObtainable())
            {
                //obj2.GiveHP();
                //obj1.GiveHP();
            }
            else if(obj2.GetObtainable())
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
