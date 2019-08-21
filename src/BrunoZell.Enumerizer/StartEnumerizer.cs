using System.Diagnostics;

namespace BrunoZell.Enumerizer
{
    public readonly ref struct StartEnumerizer
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
}
