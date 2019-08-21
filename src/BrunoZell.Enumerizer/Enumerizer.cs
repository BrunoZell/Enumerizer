using System;
using System.Collections.Generic;

public readonly struct Enumerizer
{
    public static readonly Enumerizer i = default;

    public Enumerizer(int start)
    {
        Start = start;
    }

    public readonly int Start;

    public static Enumerizer operator <(int start, Enumerizer _) =>
        new Enumerizer(start);

    public static Enumerizer operator >(int _, Enumerizer __) =>
        throw new NotImplementedException();

    public static IEnumerable<int> operator <=(Enumerizer start, int end)
    {
        for (int i = start.Start; i < end; i++)
        {
            yield return i;
        }
    }

    public static IEnumerable<int> operator >=(Enumerizer _, int __) =>
        throw new NotImplementedException();
}
