using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse.Constructor
{
    class Player
    {

        private int shields = 50;
        private int health = 100;

        public Player(string name) => Name = name;       

        public string Name { get; set; }
        
        public int Shields {
            get { return shields; }
            set { shields = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }


    }
}
