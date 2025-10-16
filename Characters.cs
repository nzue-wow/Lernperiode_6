public class Character
{
    public string Name { get; private set; }
    public int Leben { get; set; }
    public int Angriff { get; private set; }
    public string Element { get; private set; }
    public int Schutz { get; private set; }

    public Character(string name, int leben, int angriff, string element, int schutz)
    {
        Name = name;
        Leben = leben;
        Angriff = angriff;
        Element = element;
        Schutz = schutz;
    }

    public void TakeDamage(int damage)
    {
        int reduced = Math.Max(1, damage - Schutz);
        Leben -= reduced;
    }

    public int Attack()
    {
        Random rnd = new Random();
        return rnd.Next(Angriff - 2, Angriff + 3);
    }
}
