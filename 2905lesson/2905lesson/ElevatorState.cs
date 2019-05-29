using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2905lesson
{
    [Flags]
    public enum ElevatorState
    {
        GOING_UP = 1,
        GOING_DOWN = 2,
        OPENING_DOORS = 4,
        RESTING = 8
    }
}
