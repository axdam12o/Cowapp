namespace Kuhbsp;

public class Cow:IEquatable<Cow>,IComparable<Cow>
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Alter { get; set; }


    public bool Equals(Cow? other)
    {
        throw new NotImplementedException();
    }

    public int CompareTo(Cow? other)
    {
        throw new NotImplementedException();
    }
}