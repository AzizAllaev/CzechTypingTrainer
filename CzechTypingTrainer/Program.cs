﻿using Helper;

namespace CzechTypingTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тренажер печати V1 || Simulátor tisku V1");
            Console.WriteLine("Режим тренажера - 1");
            Console.WriteLine("Скорость печати - 2");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch(consoleKeyInfo.Key)
            {
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                default:
                    break;
            }
        }

    
       
    }
}
