using BrunoZell.Enumerizer;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

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

namespace BrunoZell.Enumerizer
{
    public enum Order
    {
        Ascending,
        Descending
    }

    public readonly struct StartEnumerizer
    {
        public readonly int Value;
        public readonly Order Order;

        public StartEnumerizer(int value, Order order)
        {
            Value = value;
            Order = order;
        }

        public static StartToEndEnumerizer operator <(StartEnumerizer start, int end)
        {
            Debug.Assert(start.Order == Order.Ascending);
            Debug.Assert(start.Value < end);
            return new StartToEndEnumerizer(start.Value, end - 1);
        }

        public static StartToEndEnumerizer operator >(StartEnumerizer start, int end)
        {
            Debug.Assert(start.Order == Order.Descending);
            Debug.Assert(start.Value > end);
            return new StartToEndEnumerizer(start.Value, end + 1);
        }

        public static StartToEndEnumerizer operator <=(StartEnumerizer start, int end)
        {
            Debug.Assert(start.Order == Order.Ascending);
            Debug.Assert(start.Value <= end);
            return new StartToEndEnumerizer(start.Value, end);
        }

        public static StartToEndEnumerizer operator >=(StartEnumerizer start, int end)
        {
            Debug.Assert(start.Order == Order.Descending);
            Debug.Assert(start.Value >= end);
            return new StartToEndEnumerizer(start.Value, end);
        }

    }

    public readonly struct StartToEndEnumerizer : IEnumerable<int>
    {
        public readonly int Start;
        public readonly int End;

        public StartToEndEnumerizer(int start, int end)
        {
            Start = start;
            End = end;
        }

        public IEnumerator<int> GetEnumerator() =>
            (Start < End)
                ? Upwards()
                : Downwards();

        private IEnumerator<int> Upwards()
        {
            for (int i = Start; i <= End; i++)
                yield return i;
        }

        private IEnumerator<int> Downwards()
        {
            for (int i = Start; i >= End; i--)
                yield return i;
        }

        IEnumerator IEnumerable.GetEnumerator() =>
            GetEnumerator();
    }
}
