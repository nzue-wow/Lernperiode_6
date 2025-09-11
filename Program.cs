namespace RPGLastAirbendergame
{
    internal class Program
    {
        static void Main(string[] args)
        {

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


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Willkommen zum Last Airbender RPG-Spiel!");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Wähle dein Helden: ");
            for (int i = 0; i < AvatarTeam.Count; i++)
            {
                var character = AvatarTeam[i];
                Console.WriteLine($"{i + 1}. {character.Name} (Leben: {character.Leben}, Angriff: {character.Angriff}, Element: {character.Element})");
            }

            
            
            int choice = -1;
            while(true)
            {

                Console.WriteLine("Gib die Zahl ein (1-" + AvatarTeam.Count + "): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    if (choice >= 1 && choice <= AvatarTeam.Count)
                    {
                        break; // Gültige Eingabe, Schleife verlassen
                    }
                    else
                    {

                        Console.WriteLine("Ungültige Eingabe. Bitte wähle eine Zahl zwischen 1 und " + AvatarTeam.Count);
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
                    
                }
            }

            Character chosenhero = AvatarTeam[choice - 1];
            Console.WriteLine($"Du hast {chosenhero.Name} gewählt!");

            Character chosenEnemy = TheBadPeople[0];
            Console.WriteLine($"Dein Gegner ist: {chosenEnemy.Name} ({chosenEnemy.Element})");

            Fight fight = new Fight(chosenhero, chosenEnemy);
            fight.StartFight();

        }



    }
}
