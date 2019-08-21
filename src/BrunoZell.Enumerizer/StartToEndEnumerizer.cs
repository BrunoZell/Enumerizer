using System.Collections;
using System.Collections.Generic;

namespace BrunoZell.Enumerizer
{
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
