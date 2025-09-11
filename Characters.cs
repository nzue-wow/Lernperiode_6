using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Character
{
    public string Name { get; private set; }
    public int Leben { get; private set; }
    public int Angriff { get; private set; }
    public string Element { get; private set; }

    public Character(string name, int leben, int angriff, string element)
    {
        Name = name;
        Leben = leben;
        Angriff = angriff;
        Element = element;
    }

    public void TakeDamage(int damage)
    {
        Leben -= damage;
        if (Leben < 0) Leben = 0;
    }
}
