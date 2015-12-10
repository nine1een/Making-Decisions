using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab9
{
    class Lottery
    {
        static void Main(string[] args)
        {
            Random lotteryNumberGen = new Random(); //creates rand var

            int
                userNum1,
                userNum2,
                userNum3,
                lotteryNum1,
                lotteryNum2,
                lotteryNum3,
                matches = 0;

            string
                jackpot,
                userRoll,
                original1,
                original2,
                original3;

            bool
                jackpotCheck = false;

            lotteryNum1 = lotteryNumberGen.Next(1, 5);  
            lotteryNum2 = lotteryNumberGen.Next(1, 5);
            lotteryNum3 = lotteryNumberGen.Next(1, 5);

            //RETRIEVES DATA FROM USER
            WriteLine("Enter three numbers (1-4) to enter the lottery!\n");
            Write("First Number: ");
            userNum1 = Convert.ToInt32(ReadLine());
            Write("Second Number: ");
            userNum2 = Convert.ToInt32(ReadLine());
            Write("Third Number: ");
            userNum3 = Convert.ToInt32(ReadLine());

            //CONVERTS JACKPOT AND USER ROLL TO STRINGS TO TEST AGAINST EACH OTHER
            jackpot = String.Format("{0}{1}{2}", lotteryNum1, lotteryNum2, lotteryNum3);
            userRoll = String.Format("{0}{1}{2}", userNum1, userNum2, userNum3);

            //SAVES CURRENT VALUES FOR LOTTERY NUMBERS TO REDISPLAY AT END
            original1 = String.Format("{0}", lotteryNum1);
            original2 = String.Format("{0}", lotteryNum2);
            original3 = String.Format("{0}", lotteryNum3);

            Clear();

            //TEST EACH NUMBER
            if (userNum1 == lotteryNum1 || userNum1 == lotteryNum2 || userNum1 == lotteryNum3)
            {
                ++matches;

                if (userNum1 == lotteryNum1)
                    lotteryNum1 = 0;
                else if (userNum1 == lotteryNum2)
                    lotteryNum2 = 0;
                else if (userNum1 == lotteryNum3)
                    lotteryNum3 = 0;
            }
                

            if (userNum2 == lotteryNum1 || userNum2 == lotteryNum2 || userNum2 == lotteryNum3)
            {
                ++matches;

                if (userNum2 == lotteryNum1)
                    lotteryNum1 = 0;
                else if (userNum2 == lotteryNum2)
                    lotteryNum2 = 0;
                else if (userNum2 == lotteryNum3)
                    lotteryNum3 = 0;
            }


            if (userNum3 == lotteryNum1 || userNum3 == lotteryNum2 || userNum3 == lotteryNum3)
            {
                ++matches;

                if (userNum3 == lotteryNum1)
                    lotteryNum1 = 0;
                else if (userNum3 == lotteryNum2)
                    lotteryNum2 = 0;
                else if (userNum3 == lotteryNum2)
                    lotteryNum3 = 0;
            }
            
            if (userRoll == jackpot)
                jackpotCheck = true;

            //DISPLAY RESULTS
            WriteLine("The Lottery Rolls: {0}-{1}-{2}\n", original1, original2, original3);
            WriteLine("Your Rolls: {0}-{1}-{2}\n", userNum1, userNum2, userNum3);
            WriteLine("Matches: {0}\n", matches);

            //REWARDS
            if (matches == 1)
                WriteLine("Your Reward: $10 ..... 1 MATCH\n");
            if (matches == 2)
                WriteLine("Your Reward: $100 ..... 2 MATCHES\n");
            if (matches == 3 && jackpotCheck == false)
                WriteLine("Your Reward: $1,000 ..... 3 MATCHES\n");
            if (matches == 3 && jackpotCheck == true)
                WriteLine("Your Reward: $10,000 ..... JACKPOT!!\n");
            if (matches == 0)
                WriteLine("Your Reward: $0 ..... NO MATCHES\n");
        }
    }
}
