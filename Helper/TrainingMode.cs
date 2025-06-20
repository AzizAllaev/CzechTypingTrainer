namespace Helper
{
	public static class MainMethods
	{
		public static void FirstMethod()
		{
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Тренажер печати V1 || Simulátor tisku V1");
			Console.WriteLine("Режим тренажера - 1");
			Console.WriteLine("Скорость печати - 2");
			ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
			switch (consoleKeyInfo.Key)
			{
				case ConsoleKey.D1:
					Helper.TrainingMode.LaunchTrainingSession();
					break;
				case ConsoleKey.D2:

					break;
				default:
					break;
			}
		}
	}
	public static class TrainingMode
	{
		const string Text1 = "Dneska je krásné počasí, takže půjdu na procházku do parku";
		public static void LaunchTrainingSession()
		{
			Console.Clear();
			Console.WriteLine("Чтобы начать нажмите Enter || Чтобы выйти нажмите 1");
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			Console.Clear();
			switch (keyInfo.Key)
			{
				case ConsoleKey.Enter:
					ProcessKeyInput(Text1);
					break;
				case ConsoleKey.D1:
					MainMethods.FirstMethod();
					break;
			}
		}

		#region Key proccessing methods

		static void ProcessKeyInput(string TrainingText)
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
				DisplayUserInput(TextThatTypedUser, TrainingText);
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
	}
	public static class SpeedTypingMode
	{
		public static void LaunchSpeedTypingSession()
		{
			Console.Clear();
			Console.WriteLine("Чтобы начать нажмите Enter || Чтобы выйти нажмите 1");
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			Console.Clear();
			switch (keyInfo.Key)
			{
				case ConsoleKey.Enter:

					break;
				case ConsoleKey.D1:
					Helper.MainMethods.FirstMethod();
					break;
			}
		}
	}
}