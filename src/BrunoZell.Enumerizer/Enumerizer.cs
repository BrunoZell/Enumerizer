using BrunoZell.Enumerizer;

public readonly struct Enumerizer
{
    public static readonly Enumerizer i = default;

    public static StartEnumerizer operator <(int start, Enumerizer _) =>
        new StartEnumerizer(start + 1, Order.Ascending);

    public static StartEnumerizer operator >(int start, Enumerizer _) =>
        new StartEnumerizer(start - 1, Order.Descending);

    public static StartEnumerizer operator <=(int start, Enumerizer _) =>
        new StartEnumerizer(start, Order.Ascending);

    public static StartEnumerizer operator >=(int start, Enumerizer _) =>
        new StartEnumerizer(start, Order.Descending);
}
