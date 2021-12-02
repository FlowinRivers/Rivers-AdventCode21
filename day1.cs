using System;
using System.IO;

namespace AdventCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] numberList = new int[2000];

            int previousNumber = 0;
            int currentNumber = 0;
            int numberCount = 0;
            int sumCount = 0;

            foreach (string line in File.ReadAllLines(@"D:\VSCode\projects\AdventCode\input.txt")) {
                numberList[i] = Convert.ToInt32(line);
                i++;
            }

            i = 0;

            while (i < 2000) {
                currentNumber = numberList[i];

                if (i > 0 && currentNumber > previousNumber) {
                    numberCount++;
                }

                previousNumber = currentNumber;
                i++;
            }

            i = 0;
            previousNumber = 0;
            currentNumber = 0;

            while (i < 1998) {
                currentNumber = numberList[i] + numberList[i + 1] + numberList[i + 2];

                if (i > 0 && currentNumber > previousNumber) {
                    sumCount++;
                }

                previousNumber = currentNumber;
                i++;
            }

            Console.WriteLine("Amount of measurements larger than the previous one: " + numberCount);
            Console.WriteLine("Three-measurement sums larger than the previous one: " + sumCount);
        }
    }
}
