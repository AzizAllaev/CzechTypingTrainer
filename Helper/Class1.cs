namespace Helper
{
	public static class Helper
	{
		public static void TrainerMode()
		{
			Console.Clear();
			Console.WriteLine("Чтобы начать нажмите Enter || Чтобы выйти 1");
			ConsoleKeyInfo keyInfo = Console.ReadKey();

			switch (keyInfo.Key)
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

			bool IsCorrect = false;
			bool Finish = false;
			string typer = null;
			for (int i = 0; Finish == false; i++)
			{
				if (Text1 == typer)
				{
					Console.WriteLine("Упражнение выполнено!");
					Finish = true;
				}
				if (Finish != true)
				{
					Console.WriteLine(Text1);
					Console.WriteLine(typer);

					if (i > 0)
					{
						if (IsCorrect == false)
						{
							Console.WriteLine("Неверно");
						}
						else
						{
							Console.WriteLine("Верно");
						}
					}
					ConsoleKeyInfo typeInfo = Console.ReadKey();

					char key = (char)typeInfo.Key;
					if (key == Text1[i])
					{
						IsCorrect = true;
						string convertedKey = Convert.ToString(key);
						typer = typer + convertedKey;
					}
					else if (typeInfo.Key == ConsoleKey.Backspace)
					{
						if (typer.Length > 0)
						{
							typer = typer.Remove(typer.Length - 1);
						}
					}
					else
					{
						IsCorrect = false;
					}
				}
			}
		}
	}
}
