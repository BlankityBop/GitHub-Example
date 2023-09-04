internal abstract class HogwartStudent
{

    public abstract string Name { get; }
    public int HitPoints { get; private set; }
    public int Defense { get; private set; }
    public House House { get; private set; }

    public HogwartStudent(int hitPoints, int defense, House house)
    {
        HitPoints = hitPoints;
        Defense = defense;
        House = house;

    }

    public override string ToString()
    {
        string s = "STATS \n" + "--------------------\n";
        s += "Student Name: " + Name + "\n";
        s += "Hit Points: " + HitPoints + "\n";
        s += "Defense: " + Defense + "\n";
        s += "House: " + House + "\n\n";

        s += "CATCH PHRASE \n" + "--------------------\n";
        s += SayCatchPhrase() + "\n\n";

        s += "CAST SPELL \n" + "--------------------\n";
        s += CastSpell() + "\n\n";

        return s;
    }

    protected abstract string SayCatchPhrase();
    protected abstract string CastSpell();
}

internal enum House
{
    Gryffindor,
    Hufflepuff,
    Ravenclaw,
    Slytherin
}