using System.Collections;
using System.Collections.Generic;

namespace BrunoZell.Enumerizer
{
    public readonly struct StartToEndEnumerizer : IEnumerable<int>
    {
        public readonly int Start;
        public readonly int End;
        public readonly int Step;

        public StartToEndEnumerizer(int start, int end, int step = 1)
        {
            Start = start;
            End = end;
            Step = step;
        }

        public static StartToEndEnumerizer operator |(StartToEndEnumerizer e, int s) =>
            new StartToEndEnumerizer(e.Start, e.End, s);

        public IEnumerator<int> GetEnumerator() =>
            new ValueEnumerator(Start, End, Step);

        IEnumerator IEnumerable.GetEnumerator() =>
            GetEnumerator();
    }
}
