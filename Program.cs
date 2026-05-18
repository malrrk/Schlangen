using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace SCHLANGEN
{
    public class Program 
    {
        public static void Main(string[] args)
        {          
            Console.WriteLine("1. Spieler:");

            string? Player1_Name = Console.ReadLine();
            while(Player1_Name == null)
            {
                Console.WriteLine("Bitte richtigen Namen angeben");
                Player1_Name = Console.ReadLine();
            }

            Console.WriteLine("1. Spieler:");

            string? Player2_Name = Console.ReadLine();
            while(Player2_Name == null)
            {
                Console.WriteLine("Bitte richtigen Namen angeben");
                Player2_Name = Console.ReadLine();
            }

            int FieldX = int.Parse(Console.ReadLine());
            int FieldY = int.Parse(Console.ReadLine());
            int FieldLength = FieldX*FieldY;

            GameField game = new GameField(FieldLength, Player1_Name, Player2_Name);

            //MainGameLoop
            game.Play();
            


        }
    }
}