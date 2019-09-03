using System;

namespace BrunoZell.Enumerizer
{
    public partial struct StartToEndEnumerizer
    {
        public readonly int Start;
        public readonly int End;
        public readonly int Step;
        private int? _current;

        public StartToEndEnumerizer(int start, int end, int step = 1)
        {
            if (step <= 0)
                throw new ArgumentOutOfRangeException(nameof(step),
                    "step parameter has to be larger than zero. It will automatically decrement when the iteration start is larger than the iteration end.");

            Start = start;
            End = end;
            Step = step;
            _current = null;
        }

        public static StartToEndEnumerizer operator |(StartToEndEnumerizer e, int s) =>
            new StartToEndEnumerizer(e.Start, e.End, s);
    }
}
