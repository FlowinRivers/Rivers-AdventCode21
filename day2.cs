using System;
using System.IO;

namespace AdventCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            foreach (string line in File.ReadAllLines(@"D:\VSCode\projects\AdventCode\input2.txt")) {
                string[] command = line.Split(' ');
                switch (command[0]) {
                    case "forward": {
                        horizontal = horizontal + Convert.ToInt16(command[1]);
                        depth = depth + (aim * Convert.ToInt16(command[1]));
                        break;
                    }

                    case "up": {
                        aim = aim - Convert.ToInt16(command[1]);
                        break;
                    }

                    case "down": {
                        aim = aim + Convert.ToInt16(command[1]);
                        break;
                    }
                }
                i++;
            }

            Console.WriteLine(horizontal + " * " + aim + " = " + horizontal * aim);
            Console.WriteLine(horizontal + " * " + depth + " = " + horizontal * depth);
        }
    }
}
