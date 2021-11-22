using System;
using System.Collections.Generic;
using System.Text;

namespace Morpion
{
    class Player
    {
        private readonly string name;

        public string Name
        {
            get { return name; }
        }

        public Player(string _name)
        {
            name = _name;
        }


    }
}
