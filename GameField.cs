namespace SCHLANGEN
{
    internal partial class GameField
    {
        public int FieldLength;
        public Player Player1;
        public Player Player2;

        public GameField(int FieldLength, string Player1, string Player2)
        {
            this.FieldLength = FieldLength;
            this.Player1 = new Player(Player1);
            this.Player2 = new Player(Player2);
        }
    }
}