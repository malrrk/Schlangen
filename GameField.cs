namespace SCHLANGEN
{
    internal partial class GameField
    {
        public int FieldLength;
        public FieldNode start;
        public FieldNode end;
        public Player Player1;
        public Player Player2;

        Random random = new Random();

        public int probLadder = 10; //Wahrscheinlichkeit, dass eine Leiter erscheint
        public int probSnake = 10; //Wahrscheinlichkeit, dass eine Schlange erscheint

        public GameField(int FieldLength, string Player1, string Player2)
        {
            this.FieldLength = FieldLength;
            this.Player1 = new Player(Player1);
            this.Player2 = new Player(Player2);

            start = new FieldNode(false, false, null, null);
            FieldNode current = start;

            for(int i = 0; i <= FieldLength; i++)
            {
                if(random.Next(1, probLadder) == 1)
                {
                    FieldNode newNode = new FieldNode(false, true, current, null);
                    start.Next = newNode;
                    current = newNode;
                }
                else if(random.Next(1, probSnake) == 1)
                {
                    FieldNode newNode = new FieldNode(true, false, current, null);
                    start.Next = newNode;
                    current = newNode;
                }
                else
                {
                    FieldNode newNode = new FieldNode(false, true, current, null);
                    start.Next = newNode;
                    current = newNode;
                }
            }

            end = current;
        }
    }
}