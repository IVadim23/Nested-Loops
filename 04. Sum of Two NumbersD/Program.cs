using System;

namespace P04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start of the interval
            int start = int.Parse(Console.ReadLine());
            //End of the interval
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinationCnt = 0;
            bool comboFound = false;
            for (int firstNum = start; firstNum <= end; firstNum++)
            {
                for (int secondNum = start; secondNum <= end; secondNum++)
                {
                    //One Combination -> {firstNum} {secondNum}
                    combinationCnt++;

                    if (firstNum + secondNum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationCnt} ({firstNum} + {secondNum} = {magicNum})");
                        comboFound = true;
                        break;
                    }
                }

                if (comboFound)
                {
                    break;
                }
            }

            if (!comboFound)
            {
                Console.WriteLine($"{combinationCnt} combinations - neither equals {magicNum}");
            }
        }
    }
}
