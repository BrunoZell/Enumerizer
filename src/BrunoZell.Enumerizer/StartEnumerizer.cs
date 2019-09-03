using System;

namespace BrunoZell.Enumerizer
{
    public readonly ref struct StartEnumerizer
    {
        private const string WrongOperatorChainingExceptionMessage = "Enumerizer operators are not compatible. All 'arrows' have to point in the same direction to make it clear whether to increment or decrement";

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
                throw new NotSupportedException(WrongOperatorChainingExceptionMessage);

            if (start.Value >= end)
                throw new NotSupportedException();

            return new StartToEndEnumerizer(start.Value, end - 1);
        }

        public static StartToEndEnumerizer operator >(StartEnumerizer start, int end)
        {
            if (start.Order != Order.Descending)
                throw new NotSupportedException(WrongOperatorChainingExceptionMessage);

            if (start.Value <= end)
                throw new NotSupportedException();

            return new StartToEndEnumerizer(start.Value, end + 1);
        }

        public static StartToEndEnumerizer operator <=(StartEnumerizer start, int end)
        {
            if (start.Order != Order.Ascending)
                throw new NotSupportedException(WrongOperatorChainingExceptionMessage);

            if (start.Value > end)
                throw new NotSupportedException();

            return new StartToEndEnumerizer(start.Value, end);
        }

        public static StartToEndEnumerizer operator >=(StartEnumerizer start, int end)
        {
            if (start.Order != Order.Descending)
                throw new NotSupportedException(WrongOperatorChainingExceptionMessage);

            if (start.Value < end)
                throw new NotSupportedException();

            return new StartToEndEnumerizer(start.Value, end);
        }
    }
}
