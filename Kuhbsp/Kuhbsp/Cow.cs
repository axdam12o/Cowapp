namespace Kuhbsp;

public class Cow : IEquatable<Cow>, IComparable<Cow>
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Alter { get; set; }
    public bool Coolness { get; set; }
    public double Weight { get; set; }
    

    public Cow(string name, string color, int alter,bool coolness,double weight)
    {
        Name = name;
        Color = color;
        Alter = alter;
        Coolness = coolness;
        Weight = weight;    
    }

    public bool Equals(Cow? other)
    {
        if (other == null)
            return false;

        return Name == other.Name &&
               Color == other.Color &&
               Alter == other.Alter;
    }

    public int CompareTo(Cow? other)
    {
        throw new NotImplementedException();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Color, Alter);
    }

    public override string ToString()
    {
        return $"{Name}, {Color}, {Alter}";
    }
}