namespace Helper
{
	public static class Helper
	{
		public static void TrainerMode()
		{
			Console.Clear();
			Console.WriteLine("Чтобы начать нажмите Enter || Чтобы выйти 1");
			ConsoleKeyInfo keyInfo = Console.ReadKey();

			switch(keyInfo.Key)
			{
				case ConsoleKey.Enter:
					Trainer();
					break;
			}
		}
		public static void Trainer()
		{
			Console.Clear();
			string Text1 = "Dneska je krásné počasí, takže půjdu na procházku do parku";
			string Text2 = "Včera jsem si koupil nový telefon, protože ten starý už nefungoval";
			string Text3 = "Rád poslouchám hudbu, když pracuji nebo se učím";
			string Text4 = "Moje sestra studuje na univerzitě a chce být lékařkou";
			string Text5 = "Každé ráno vstávám v sedm hodin a snídám s rodinou";
			KeyChecker(Text1);
		}
		public static void KeyChecker(string text)
		{
			bool finish = false;
			string TextThatTypedUser = "";
			while(!finish)
			{

				if(TextThatTypedUser ==  text)
				{
					finish = true;
				}


				ConsoleKeyInfo info = Console.ReadKey(intercept: true);
				if(info.Key == ConsoleKey.Backspace)
				{
					if (TextThatTypedUser.Length > 0)
					{
						TextThatTypedUser = TextThatTypedUser.Substring(0, TextThatTypedUser.Length - 1);
					}
				}
				else 
				{
					TextThatTypedUser += info.KeyChar;
				}
				Console.WriteLine(text);
				Console.SetCursorPosition(0, 1);
				Console.WriteLine(new string(' ', Console.WindowWidth));
				Console.SetCursorPosition(0, 1);
				foreach(char c in TextThatTypedUser)
				{
					Console.Write(c);
				}
			}
		}
	}
}