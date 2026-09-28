namespace Kuhbsp;

public class CombareByAge:IComparer<Cow>
{
    public int Compare(Cow? x, Cow? y)
    {
        return x.Alter.CompareTo(y.Alter);
    }
}