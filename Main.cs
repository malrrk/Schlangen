using System.Security.Cryptography.X509Certificates;

namespace SCHLANGEN
{
    public class Main 
    {
        public static void Main(string[] args)
        {          
            string Player1 = Console.ReadLine();
            string Player2 = Console.ReadLine();

            int FieldX = int.Parse(Console.ReadLine());
            int FieldY = int.Parse(Console.ReadLine());
            int FieldLength = FieldX*FieldY;

            GameField game = new GameField(FieldLength, Player1, Player2);

        }
    }
}