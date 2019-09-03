using System;

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
            if (start.Order != Order.Ascending)
                throw new NotSupportedException();

            if (start.Value >= end)
                throw new NotSupportedException();

            return new StartToEndEnumerizer(start.Value, end - 1);
        }

        public static StartToEndEnumerizer operator >(StartEnumerizer start, int end)
        {
            if (start.Order != Order.Descending)
                throw new NotSupportedException();

            if (start.Value <= end)
                throw new NotSupportedException();

            return new StartToEndEnumerizer(start.Value, end + 1);
        }

        public static StartToEndEnumerizer operator <=(StartEnumerizer start, int end)
        {
            if (start.Order != Order.Ascending)
                throw new NotSupportedException();

            if (start.Value > end)
                throw new NotSupportedException();

            return new StartToEndEnumerizer(start.Value, end);
        }

        public static StartToEndEnumerizer operator >=(StartEnumerizer start, int end)
        {
            if (start.Order != Order.Descending)
                throw new NotSupportedException();

            if (start.Value < end)
                throw new NotSupportedException();

            return new StartToEndEnumerizer(start.Value, end);
        }
    }
}
