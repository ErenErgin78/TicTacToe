using TicTacToe;
using System.Xml.Serialization;

internal class Program
{    
    static int Oyuncu = 1;
    public static int Secilen;
    static int Durum;
    private static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Player1:X and Player2:O" + "\n");

            if (Oyuncu == 1) { Console.WriteLine("1.Oyuncunun sırası" + "\n"); }
            else { Console.WriteLine("2.Oyuncunun sırası" + "\n"); }

            TicTac.BoardGetir();

            TicTac.SayiAl();

            if (TicTac.Alan[Secilen] != 'X' && TicTac.Alan[Secilen] != 'O')
            {
                if(Oyuncu == 1) { TicTac.Alan[Secilen] = 'X'; Oyuncu++; }
                else { TicTac.Alan[Secilen] = 'O'; Oyuncu--; }
            }

            Durum = TicTac.GetWinControl();
        }

        while (Durum != 1 && Durum != -1);
        Console.Clear();
        TicTac.BoardGetir() ;

        if (Durum == 1)
        {
            if (Oyuncu == 1) { Oyuncu = 2; }
            else {  Oyuncu = 1; }

            Console.WriteLine("Oyuncu {0} kazandı!", (Oyuncu)); 
        }

        else if(Durum == -1) { Console.WriteLine("Berabere!"); }
    }
}