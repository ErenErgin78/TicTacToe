using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    internal class TicTac
    {
        
           public static char[] Alan = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

           private static void Board()
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", Alan[1], Alan[2], Alan[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", Alan[4], Alan[5], Alan[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", Alan[7], Alan[8], Alan[9]);
                Console.WriteLine("     |     |      ");
            }
           public static void BoardGetir() { Board(); }


           private static int WinControl()
        {
            // 1 = kazandı , 0 = devam ediyor , -1 = berabere

            //1.Satır
            if (Alan[1] == Alan[2] && Alan[2] == Alan[3])
            { return 1; }
            //2.Satır
            else if (Alan[4] == Alan[5] && Alan[5] == Alan[6])
            { return 1; }
            //3.Satır
            else if (Alan[7] == Alan[8] && Alan[8] == Alan[9])
            { return 1; }


            //1.Sütun
            else if (Alan[1] == Alan[4] && Alan[4] == Alan[7])
            { return 1; }
            //2.Sütun
            else if (Alan[2] == Alan[5] && Alan[5] == Alan[8])
            { return 1; }
            //3.Sütun 
            else if (Alan[3] == Alan[6] && Alan[6] == Alan[9])
            { return 1; }


            //sağ üstten çarpraz
            else if (Alan[1] == Alan[5] && Alan[5] == Alan[9])
            { return 1; }
            //sol üstten çarpraz 
            else if (Alan[3] == Alan[5] && Alan[5] == Alan[7])
            { return 1; }


            //Berabere
            else if (Alan[1] != '1' && Alan[2] != '2' && Alan[3] != '3' && Alan[4] != '4' && Alan[5] != '5' && Alan[6] != '6' && Alan[7] != '7' && Alan[8] != '8' && Alan[9] != '9')
            { return -1; }


            //Devam ediyor
            else { return 0;}

        }
           public static int GetWinControl() { return WinControl(); }


           public static void SayiAl()
        {
            Program.Secilen = int.Parse(Console.ReadLine());
            if ((Program.Secilen > TicTac.Alan.Length || Program.Secilen <= 0))
            { Console.WriteLine("Lütfen yukarıdaki tahtada olan bir bölgeyi seçin!");
                SayiAl();
            }
            else {}

        }
            



        

    }
}
