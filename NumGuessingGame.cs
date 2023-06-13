using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eo_NumGuessingGame
{
    class NumGuessingGame
    {
        static void Main(string[] args)
        {
            Random l_rndRandom = new Random();

            int l_intCorrNum = l_rndRandom.Next(0, 100);

            bool l_bolWin = false;

            do
            {
                Console.WriteLine("Please guess a number between 0 and 100: ");
                string l_strAnswer = Console.ReadLine();

                int l_intI = int.Parse(l_strAnswer);

                if (l_intI > l_intCorrNum) Console.WriteLine("Too High!");

                if (l_intI < l_intCorrNum) Console.WriteLine("Too Low!");

                if (l_intI == l_intCorrNum)
                {
                    Console.WriteLine($"Congratulations! {l_intI} is correct!");
                    Console.WriteLine("Press any key to finish.");
                    Console.ReadKey();
                    l_bolWin = true;
                }

            } while (l_bolWin == false);
        }
    }
}
