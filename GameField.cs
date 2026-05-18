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

            start = new FieldNode(false, false, null, null);
            FieldNode current = start;

            for(int i = 0; i <= FieldLength; i++)
            {
                if(random.Next(1, probLadder) == 1)
                {
                    FieldNode newNode = new FieldNode(false, true, null, current);
                    start.Next = newNode;
                    current = newNode;
                }
                else if(random.Next(1, probSnake) == 1)
                {
                    FieldNode newNode = new FieldNode(true, false, null, current);
                    start.Next = newNode;
                    current = newNode;
                }
                else
                {
                    FieldNode newNode = new FieldNode(false, true, null, current);
                    start.Next = newNode;
                    current = newNode;
                }
            }

            this.Player1 = new Player(Player1, start);
            this.Player2 = new Player(Player2, start);

            end = current;
        }

        public void Play()
        {
            bool gameOver = false;

            while (!gameOver)
            {
                gameOver = takeTurn(Player1, Player2);

                if(!gameOver)
                {
                    gameOver = takeTurn(Player1, Player2);
                }
            }
        }

        public bool takeTurn(Player player, Player other)
        {
            int diceResult = rollDice();

            if(diceResult == 1)
            {
                rolledOne();
                return false;
            }
            else if(diceResult == 6)
            {
                rolledSix(player);
                return false;
            }
            else
            {
                FieldNode? pos = movePlayer(diceResult, player);

                if(pos == other.Position)
                {
                    pos = movePlayer(-1, player);
                }
                if (pos.Snake)
                {
                    pos = movePlayer(-3, player);    
                }
                else if (pos.Ladder) //else if um doppeltzug zu verhindern
                {
                    pos = movePlayer(3, player);
                }
                if(pos == end)
                {
                    return true;
                }
            }
            return false;
        }

        public int rollDice()
        {
            return random.Next(1, 7);
        }

        public void rolledOne()
        {
            FieldNode current = end;
            for(int i = 0; i <= 5; i++)
            {
                FieldNode newNode = new FieldNode(false, false, current, null);
                end.Next = newNode;
                current = newNode;
            }
        }

        public void rolledSix(Player player)
        {
            FieldNode current = player.Position;
            
            for(int i = 0; i <= 5; i++)
            {
                FieldNode newNode = new FieldNode(false, false, current.Prev, current);
                current = newNode;
            }
        }

        public FieldNode? movePlayer(int fields, Player player)
        {
            if(fields > 0){
                for(int i = 0; i <= fields; i++)
                {
                    player.Position = player.Position.Next;
                }
                return player.Position;
            }
            else
            {
                for(int i = 0; i <= -fields; i++)
                {
                    player.Position = player.Position.Prev;
                }
                return player.Position;
            }

        }

    }
}