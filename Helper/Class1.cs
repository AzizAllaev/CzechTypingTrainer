using static System.Net.Mime.MediaTypeNames;

namespace Helper
{
	public static class Helper
	{
		const string Text1 = "Dneska je krásné počasí, takže půjdu na procházku do parku";
		public static void TrainerMode()
		{
			Console.Clear();
			Console.WriteLine("Чтобы начать нажмите Enter || Чтобы выйти 1");
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			Console.Clear();
			switch (keyInfo.Key)
			{
				case ConsoleKey.Enter:
					KeyChecker(Text1);
					break;
			}
		}

		static void KeyChecker(string TrainingText)
		{
			int i = -1;
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
					TextThatTypedUser = WriteString(TextThatTypedUser, info);
				}
				WriteConsole(TextThatTypedUser, TrainingText);
			}
		}

		#region Methods that work with string
		static string DoBackspace(string UserKeyboardText)
		{
			if (UserKeyboardText.Length > 0)
				UserKeyboardText = UserKeyboardText.Substring(0, UserKeyboardText.Length - 1);
			return UserKeyboardText;
		}
		static string WriteString(string UserKeyboardText, ConsoleKeyInfo KeyInfo)
		{
			if (!char.IsControl(KeyInfo.KeyChar))
			{
				UserKeyboardText += KeyInfo.KeyChar;
			}
			return UserKeyboardText;
		}
		#endregion

		#region Methods that display typed text

		static void WriteConsole(string UserKeyboardText, string TrainingText)
		{
			int i = 0;
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.SetCursorPosition(0, 0);
			Console.WriteLine(TrainingText);

			MakeConsoleClear();

			foreach (char c in UserKeyboardText)
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
				i++;
			}

		}

		#region Methods that inside WriteConsole
		static void MakeConsoleClear()
		{
			Console.SetCursorPosition(0, 1);
			Console.Write(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, 1);
		} 
		#endregion

		#endregion

	




	
	}
}