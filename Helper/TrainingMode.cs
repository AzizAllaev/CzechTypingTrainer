namespace Helper
{
	public static class KeyProcessingMethods
	{
		#region Key processing methods of TrainingMode

		public static void ProcessKeyInput(string TrainingText)
		{ 
			bool finish = false;
			string TextThatTypedUser = "";
			while (!finish)
			{
				ConsoleKeyInfo info = Console.ReadKey(intercept: true);

				if (info.Key == ConsoleKey.Backspace)
				{
					TextThatTypedUser = DoBackspace(TextThatTypedUser);
				}
				else
				{
					TextThatTypedUser = UpdateUserInput(TextThatTypedUser, info);
				}

				if (TextThatTypedUser != TrainingText)
				{
					DisplayUserInput(TextThatTypedUser, TrainingText);
				}
				else
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.WriteLine("Вы завершили задание!");
					Console.ReadLine();
					Console.Clear();
					break;
				}
			}
		}
		#region Methods that work with string

		static string DoBackspace(string UserKeyboardText)
		{
			if (UserKeyboardText.Length > 0)
				UserKeyboardText = UserKeyboardText.Substring(0, UserKeyboardText.Length - 1);
			return UserKeyboardText;
		}
		static string UpdateUserInput(string UserKeyboardText, ConsoleKeyInfo KeyInfo)
		{
			if (!char.IsControl(KeyInfo.KeyChar))
				UserKeyboardText += KeyInfo.KeyChar;
			return UserKeyboardText;
		}

		#endregion
		#region Methods that display typed text

		static void DisplayUserInput(string UserKeyboardText, string TrainingText)
		{
			int i = 0;
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.SetCursorPosition(0, 0);
			Console.WriteLine(TrainingText);

			MakeConsoleClear();
			
			foreach (char c in UserKeyboardText)
			{
				if (i < TrainingText.Length)
				{
					if (c == TrainingText[i])
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write(c);
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(c);
					}
				}
				i++;
			}
		}

		#region Methods that inside DisplayUserInput
		static void MakeConsoleClear()
		{
			Console.SetCursorPosition(0, 1);
			Console.Write(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, 1);
		}
		#endregion

		#endregion
		#endregion

		#region Methods of speedTyping

		public static void ProcessKeyInputAndMistakes(string TrainingText)
		{
			bool finish = false;
			string TextThatTypedUser = "";
			while (!finish)
			{
				ConsoleKeyInfo info = Console.ReadKey(intercept: true);

				if (info.Key == ConsoleKey.Backspace)
				{
					TextThatTypedUser = DoBackspace(TextThatTypedUser);
				}
				else
				{
					TextThatTypedUser = UpdateUserInput(TextThatTypedUser, info);
				}

				if (TextThatTypedUser != TrainingText)
				{
					DisplayUserInputAndMistakes(TextThatTypedUser, TrainingText);
				}
				else
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.WriteLine("Вы завершили задание!");
					Console.ReadKey();
					break;
				}
			}
		}

		#region Methods that display text and mistakes with time
		static void DisplayUserInputAndMistakes(string UserKeyboardText, string TrainingText)
		{
			int i = 0;
			int TotalTyped = 0;
			int CorrectTyped = 0;
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.SetCursorPosition(0, 0);
			Console.WriteLine(TrainingText);
			MakeConsoleClear();
			foreach (char c in UserKeyboardText)
			{
				if (i < TrainingText.Length)
				{
					if (c == TrainingText[i])
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write(c);
						CorrectTyped++;
						TotalTyped++;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(c);
						TotalTyped++;
					}
				}
				i++;
			}
		}
		#endregion
		#region Methods for counting mistakes
		public static double HowMuchMistake(int TotalTypedChars, int CorrectTypedChars)
		{
			return (CorrectTypedChars / TotalTypedChars) * 100;
		}
		#endregion
		#endregion
	}
}