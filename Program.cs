namespace RPGLastAirbendergame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> AvatarTeam = new List<Character>()
            {
                new Character("Aang", 80, 15, "Air", 5),
                new Character("Katara", 70, 12, "Water", 6),
                new Character("Sokka", 65, 10, "Boomerang", 4),
                new Character("Toph", 90, 14, "Earth", 8)
            };

            List<Character> TheBadPeople = new List<Character>()
            {
                new Character("Fire Lord Ozai", 100, 18, "Fire", 7),
                new Character("Princess Azula", 85, 16, "Fire", 6),
                new Character("Admiral Zhao", 75, 13, "Fire", 5)
            };

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Willkommen zum Last Airbender RPG-Spiel!");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Wähle deinen Helden: ");
            for (int i = 0; i < AvatarTeam.Count; i++)
            {
                var character = AvatarTeam[i];
                Console.WriteLine($"{i + 1}. {character.Name} (Leben: {character.Leben}, Angriff: {character.Angriff}, Element: {character.Element})");
            }

            int choice = -1;
            while (true)
            {
                Console.WriteLine($"Gib die Zahl ein (1-{AvatarTeam.Count}): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    if (choice >= 1 && choice <= AvatarTeam.Count)
                        break;
                    else
                        Console.WriteLine($"Ungültige Eingabe. Bitte wähle eine Zahl zwischen 1 und {AvatarTeam.Count}.");
                }
                else
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
            }

            // Gewählter Held
            Character chosenHero = AvatarTeam[choice - 1];
            Console.WriteLine($"Du hast {chosenHero.Name} gewählt!");

            // Spiel starten
            Game game = new Game(AvatarTeam, TheBadPeople, chosenHero);
            game.Start();
        }
    }
}
