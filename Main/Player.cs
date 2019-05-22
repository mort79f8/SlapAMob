using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Player : Stats 
    {
        private int exp;

        public Player(string name)
        {
            Name = name;
        }

        public int Exp { get => exp; set => exp = value; }

        
    }
}
