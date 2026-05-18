namespace SCHLANGEN
{
    internal partial class GameField
    {
        internal class Player
        {
            public string Name;
            public int Throws;
            public FieldNode Position;

            public Player(string Name, FieldNode start)
            {
                this.Name = Name;
                Throws = 0;
                Position = start;
            }
        }
    }
}