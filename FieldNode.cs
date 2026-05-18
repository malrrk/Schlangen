namespace SCHLANGEN
{
    internal partial class GameField
    {
        internal class FieldNode
        {
            public bool Snake = false;
            public bool Ladder = false;
            public FieldNode Next;
            public FieldNode Prev;
        }
    }
}