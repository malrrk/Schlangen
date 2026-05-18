namespace SCHLANGEN
{
    internal partial class GameField
    {
        internal class Player
        {
            public string Name;
            public int Throws;
            public FieldNode Position;

            public Player(string Name)
            {
                this.Name = Name;
                Throws = 0;
            }
        }
    }
}