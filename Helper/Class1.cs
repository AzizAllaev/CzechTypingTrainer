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
			switch(keyInfo.Key)
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
			while(!finish)
			{
				DoTextFinished(TrainingText, TextThatTypedUser, finish);

				ConsoleKeyInfo info = Console.ReadKey(intercept: true);

				if(info.Key == ConsoleKey.Backspace)
				{
					DoBackspace(info, TextThatTypedUser, i);
				}
				else
				{
					WriteString(info, TextThatTypedUser, TrainingText, i);
				}

				TextWriter(TrainingText, TextThatTypedUser, i);
			}
		}

		static void TextWriter(string TrainingText, string TextThatUserType, int CursorPosition)
		{
			Console.SetCursorPosition(0, 0);
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(TrainingText);
			Console.SetCursorPosition(0, 1);
			Console.WriteLine(new string(' ', Console.WindowWidth));
			Console.SetCursorPosition(0, 1);
			if (CursorPosition > TextThatUserType.Length || CursorPosition > TrainingText.Length)
			{
				Console.WriteLine("Ошибка размера массива");
			}
			else
			{
				foreach (char c in TextThatUserType)
				{
					if (TextThatUserType[CursorPosition] == TrainingText[CursorPosition])
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
			}
		}

		#region CheckMethods
		static void DoTextFinished(string TrainingText, string TextThatUserType, bool EndOfCycle)
		{
			if (TextThatUserType == TrainingText)
				EndOfCycle = true;
		}
		static void DoBackspace(ConsoleKeyInfo KeyInfo, string TextThatUserType, int CursorPosition)
		{
			CursorPosition--;
			if (TextThatUserType.Length > 0)
				TextThatUserType = TextThatUserType.Substring(0, TextThatUserType.Length - 1);
		}
		static void WriteString(ConsoleKeyInfo KeyInfo, string TextThatUserType, string TrainingText, int CursorPosition)
		{
			if (char.IsControl(KeyInfo.KeyChar))
			{
				TextThatUserType += KeyInfo.KeyChar;
			}
			else
			{
				CursorPosition++;
				TextThatUserType += KeyInfo.KeyChar;
			}
		}
		#endregion
	}
}