using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace SCHLANGEN
{
    public class Program 
    {
        public static void Main(string[] args)
        {          
            Console.WriteLine("1. Spieler:");

            string? Player1 = Console.ReadLine();
            while(Player1 == null)
            {
                Console.WriteLine("Bitte richtigen Namen angeben");
                Player1 = Console.ReadLine();
            }

            Console.WriteLine("1. Spieler:");

            string? Player2 = Console.ReadLine();
            while(Player2 == null)
            {
                Console.WriteLine("Bitte richtigen Namen angeben");
                Player2 = Console.ReadLine();
            }

            int FieldX = int.Parse(Console.ReadLine());
            int FieldY = int.Parse(Console.ReadLine());
            int FieldLength = FieldX*FieldY;

            GameField game = new GameField(FieldLength, Player1, Player2);

        }
    }
}