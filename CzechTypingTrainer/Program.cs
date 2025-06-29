using Helper;
using TypingModes;

namespace CzechTypingTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.ForegroundColor = ConsoleColor.Gray;
			while (true)
			{
				Console.WriteLine("Тренажер печати V1 || Simulátor tisku V1");
				Console.WriteLine("Режим тренажера - 1");
				Console.WriteLine("Скорость печати - 2");
				ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
				switch (consoleKeyInfo.Key)
				{
					case ConsoleKey.D1:
						TypingModes.TrainingMode.LaunchTrainingSession();
						break;
					case ConsoleKey.D2:
						TypingModes.SpeedTypingMode.LaunchSpeedTypingSession();
						break;
					default:
						Console.Clear();
						break;
				}
			}
		}
    }
}
