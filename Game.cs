using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;

internal class Game
{
    private List<Character> heroes;
    private List<Character> enemies;
    private Character currentHero;
    private Random rnd = new Random();

    public Game(List<Character> heroes, List<Character> enemies, Character chosenHero)
    {
        this.heroes = new List<Character>(heroes);
        this.enemies = new List<Character>(enemies);
        this.currentHero = chosenHero;
    }

    public void Start()
    {
        Console.WriteLine("\nDas Abenteuer beginnt!\n");
        int heroIndex = heroes.IndexOf(currentHero);

        while (heroes.Count > 0 && enemies.Count > 0)
        {
            Character currentEnemy = enemies[rnd.Next(enemies.Count)];
            Fight fight = new Fight(currentHero, currentEnemy);
            bool heroWon = fight.StartFight();

            if (heroWon)
            {
                Console.WriteLine($"{currentHero.Name} hat {currentEnemy.Name} besiegt!");
                enemies.Remove(currentEnemy);

                if (enemies.Count == 0)
                {
                    Console.WriteLine("\nAlle Gegner wurden besiegt! 🏆 Du hast gewonnen!");
                    return;
                }

                Console.WriteLine($"Nächster zufälliger Gegner wird gewählt...\n");
            }
            else
            {
                Console.WriteLine($"{currentHero.Name} wurde besiegt...");
                heroes.Remove(currentHero);

                if (heroes.Count == 0)
                {
                    Console.WriteLine("\nAlle Helden wurden besiegt! 😢 Game Over!");
                    return;
                }

                currentHero = heroes[rnd.Next(heroes.Count)];
                Console.WriteLine($"Neuer Held tritt an: {currentHero.Name}!\n");
            }
        }
    }
}
