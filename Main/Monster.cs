using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Monster : Stats
    {
        private int worthExp;

        public int WorthExp { get => worthExp; set => worthExp = value; }
    }
}
