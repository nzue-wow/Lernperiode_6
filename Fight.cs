using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using System;

namespace RPGLastAirbendergame
{
    internal class Fight
    {
        private Character hero;
        private Character enemy;

        public Fight(Character hero, Character enemy)
        {
            this.hero = hero;
            this.enemy = enemy;
        }

        public void StartFight()
        {
            Console.WriteLine($"\n--- Der Kampf beginnt: {hero.Name} vs. {enemy.Name} ---\n");

            while (hero.Leben > 0 && enemy.Leben > 0)
            {
                // Held greift an
                enemy.TakeDamage(hero.Angriff);
                Console.WriteLine($"{hero.Name} greift an! {enemy.Name} hat nun {enemy.Leben} Leben.");

                if (enemy.Leben <= 0)
                {
                    Console.WriteLine($"{enemy.Name} wurde besiegt!");
                    break;
                }

                // Gegner greift an
                hero.TakeDamage(enemy.Angriff);
                Console.WriteLine($"{enemy.Name} greift zurück! {hero.Name} hat nun {hero.Leben} Leben.");

                if (hero.Leben <= 0)
                {
                    Console.WriteLine($"{hero.Name} wurde besiegt! Game Over.");
                    break;
                }

                Console.WriteLine("Drücke eine Taste für die nächste Runde...");
                Console.WriteLine(" ");
                Console.ReadKey();
            }
        }
    }
}

