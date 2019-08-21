using System.Collections;
using System.Collections.Generic;

namespace BrunoZell.Enumerizer
{
    public struct ValueEnumerator : IEnumerator<int>
    {
        private readonly int _start;
        private readonly int _end;
        private readonly int _step;
        private int? _current;

        public ValueEnumerator(int start, int end, int step)
        {
            _start = start;
            _end = end;
            _step = step;
            _current = null;
        }

        public int Current => _current ?? 0;
        object IEnumerator.Current => Current;

        public bool MoveNext() =>
            _current.HasValue
                ? (_start < _end)
                    ? (_current += _step) <= _end
                    : (_current -= _step) >= _end
                : true | (_current = _start) != 0;

        public void Reset() =>
            _current = null;

        public void Dispose() { }
    }
}
