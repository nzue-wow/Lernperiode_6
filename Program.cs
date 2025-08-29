namespace RPGLastAirbendergame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        List<Character> AvatarTeam = new List<Character>()
        {
            new Character("Aang", 20, 7, "Air"),
            new Character("Katara", 15, 5, "Water"),
            new Character("Sokka", 12, 4, "Boomerang"),
            new Character("Toph", 18, 6, "Earth")
        };

        List<Character> TheBadPeople = new List<Character>()
        {
            new Character("Fire Lord Ozai", 25, 8, "Fire"),
            new Character("Princess Azula", 20, 7, "Fire"),
            new Character("Admiral Zhao", 15, 5, "Fire")
        };

        public class Character
        {
            // Eigenschaften
            public string Name { get; set; }
            public int Leben { get; set; }
            public int Angriff { get; set; }
            public string Element { get; set; }

            // Konstruktor
            public Character(string name, int leben, int angriff, string element)
            {
                Name = name;
                Leben = leben;
                Angriff = angriff;
                Element = element;
            }


            //Methoden
            public void Attack(Character target)
            {
                Console.WriteLine($"{Name} greift {target.Name} an und verursacht {Angriff} Schaden.");
                target.Damage(Angriff);
            }

            public void Damage(int damage)
            {
                Leben -= damage;
                if (Leben < 0) Leben = 0; 
                Console.WriteLine($"{Name} verliert {damage} Leben. Verbleibend: {Leben}");
            }
        }
    }
}
