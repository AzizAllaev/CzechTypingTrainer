namespace TypingModes
{
	public static class TrainingMode
	{
		const string Text1 = "Dneska je krásné počasí, takže půjdu na procházku do parku";
		public static void LaunchTrainingSession()
		{
			Console.Clear();
			Console.WriteLine("Чтобы начать нажмите Enter || Чтобы выйти нажмите 1");
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			if(keyInfo.Key == ConsoleKey.Enter) 
				Helper.KeyProcessingMethods.ProcessKeyInput(Text1);
		}
	}
	public static class SpeedTypingMode
	{
		const string Text1 = "Dneska je krásné počasí, takže půjdu na procházku do parku";
		public static void LaunchSpeedTypingSession()
		{
			Console.Clear();
			Console.WriteLine("Чтобы начать нажмите Enter || Чтобы выйти нажмите 1");
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			if (keyInfo.Key == ConsoleKey.Enter)
				Helper.KeyProcessingMethods.ProcessKeyInputAndMistakes(Text1);
		}
	}
}
