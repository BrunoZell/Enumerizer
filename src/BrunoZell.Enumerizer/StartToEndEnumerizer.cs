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
            Start = start;
            End = end;
            Step = step;
            _current = null;
        }

        public static StartToEndEnumerizer operator |(StartToEndEnumerizer e, int s) =>
            new StartToEndEnumerizer(e.Start, e.End, s);
    }
}
