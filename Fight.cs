using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGLastAirbendergame
{
    internal class Fight
    {
        public Fight() {

           Console.WriteLine($"{chosenhero} vs. {chosenenemy}");

            // chosen hero greift an
            int neueslebenenemy = leben.cosenenemy - chosenhero.angriff;

            // chosen enemy greift an
            int neueslebenhero = leben.chosenhero - chosenenemy.angriff;

            // aktualisiere leben
            lebenenemy = neueslebenenemy;
            lebenhero = neueslebenhero;

            if (lebenenemy <= 0)
            {
                Character chosenEnemy = TheBadPeople, i++; // nächster gegner in der liste
            }
            else
            {
                Fight(); // wiederhole den kampf
            };

            if (lebenhero <= 0)
            {
               Console.WriteLine("Game Over! Du wurdest besiegt."); // spiel beenden
            }
            else
            {
                Fight();// wiederhole den kampf
            };
        }

    }
}
