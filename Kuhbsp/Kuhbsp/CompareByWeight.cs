namespace Kuhbsp;

public class CompareByWeight:IComparer<Cow>
{
    public int Compare(Cow? x, Cow? y)
    {
        if(ReferenceEquals(x,y))return 1;
        if(x is null)return -1;
        if(y is null)return 1;
        return x.Weight.CompareTo(y.Weight);
    }
}