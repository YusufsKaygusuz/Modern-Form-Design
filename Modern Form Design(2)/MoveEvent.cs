using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Form_Design_2_
{
    public sealed class MoveEvent
    {
        public bool moveControl = false;
        private int muouse_X;
        private int mouse_Y;

        public int M_X { get { return muouse_X; } set {muouse_X = value; } }
        public int M_Y { get {return mouse_Y ; } set { mouse_Y = value; } }

    }
}
