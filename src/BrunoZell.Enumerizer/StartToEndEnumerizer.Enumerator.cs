using System.Collections;
using System.Collections.Generic;

namespace BrunoZell.Enumerizer
{
    public partial struct StartToEndEnumerizer : IEnumerable<int>, IEnumerator<int>
    {
        public int Current => _current ?? 0;
        object IEnumerator.Current => Current;

        public bool MoveNext() =>
            _current.HasValue
                ? (Start < End)
                    ? (_current += Step) <= End
                    : (_current -= Step) >= End
                : true | (_current = Start) != 0;

        public void Reset() =>
            _current = null;

        public void Dispose() { }

        public IEnumerator<int> GetEnumerator() => this;
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
