namespace SCHLANGEN
{
    internal partial class GameField
    {
        internal class FieldNode
        {
            public bool Snake = false;
            public bool Ladder = false;
            public FieldNode? Next;
            public FieldNode? Prev;

            public FieldNode(bool Snake, bool Ladder, FieldNode? Next, FieldNode? Prev)
            {
                this.Snake = Snake;
                this.Ladder = Ladder;
                this.Next = Next;
                this.Prev = Prev;
            }

            public FieldNode? GetNext()
            {
                return Next;
            }
        }
    }
}