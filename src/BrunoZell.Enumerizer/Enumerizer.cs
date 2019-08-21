using BrunoZell.Enumerizer;
using System;
using System.Collections.Generic;

public readonly struct Enumerizer
{
    public static readonly Enumerizer i = default;

    public static StartEnumerizer operator <(int start, Enumerizer _) =>
        new StartEnumerizer(start + 1);

    public static StartEnumerizer operator >(int start, Enumerizer _) =>
        throw new NotImplementedException();

    public static StartEnumerizer operator <=(int start, Enumerizer _) =>
        new StartEnumerizer(start);

    public static StartEnumerizer operator >=(int start, Enumerizer _) =>
        throw new NotImplementedException();
}

namespace BrunoZell.Enumerizer
{
    public readonly struct StartEnumerizer
    {
        public readonly int Value;

        public StartEnumerizer(int value) =>
            Value = value;

        public static IEnumerable<int> operator <(StartEnumerizer start, int end)
        {
            for (int i = start.Value; i < end; i++)
                yield return i;
        }

        public static IEnumerable<int> operator >(StartEnumerizer start, int end) =>
            throw new NotImplementedException();

        public static IEnumerable<int> operator <=(StartEnumerizer start, int end)
        {
            for (int i = start.Value; i <= end; i++)
                yield return i;
        }

        public static IEnumerable<int> operator >=(StartEnumerizer start, int end) =>
            throw new NotImplementedException();
    }
}
