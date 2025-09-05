using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLastAirbendergame
{
    public class Character
    {
        // Eigenschaften
        public string Name { get; private set; }
        public int Leben { get; private set; }
        public int Angriff { get; private set; }
        public string Element { get; private set; }

        private static readonly Random Rng = new Random();

        // Konstruktor
        public Character(string name, int leben, int angriff, string element)
        {
            Name = name;
            Leben = leben;
            Angriff = angriff;
            Element = element;
        }

        
    }
}
