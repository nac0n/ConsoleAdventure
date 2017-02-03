using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSnake
{
    public interface ICollideable
    {
        bool HasCollided { get; set; }

        bool IsKillable { get; set; }
        bool IsDestructable { get; set; }
        bool IsObtainable { get; set; }
        bool IsPassable { get; set; }
        bool IsMoveable { get; set; }
        
    }
}