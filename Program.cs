using System;

namespace HashovaciTabulka
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] tabulka = new string[10];
			while (true) {
				Console.SetCursorPosition (1,1);
				Console.Write ("                                                       ");
				Console.SetCursorPosition (2,1);
				Console.Write ("                                                       ");
				Console.SetCursorPosition (1,1);
				Console.Write ("Vloz retezec: ");
				string vstup = Console.ReadLine ();
				char[] vstupNaKousky = vstup.ToCharArray ();
				Console.SetCursorPosition (1,2);
				Console.Write ("{0} > (",vstup);
				double sum = 1;
				for (int i = 0; i <= vstupNaKousky.GetLength (0) - 1; i++) {
					Console.Write ((int)vstupNaKousky[i]);
					sum = sum * (int)vstupNaKousky [i];
					if (i == vstupNaKousky.GetLength (0) - 1) {
						Console.Write (") mod 10 = {0}",(sum % 10));
					} else {
						Console.Write (" * ");
					}
				}
				double sumMod = sum % 10;
				tabulka [(int)sumMod] = vstup;
				for (int i = 0; i <= tabulka.GetLength (0) - 1; i++) {
					Console.SetCursorPosition (1,4+i);
					Console.Write ("                                                  ");
				}
				for (int i = 0; i <= tabulka.GetLength (0) - 1; i++) {
					Console.SetCursorPosition (1,4+i);
					Console.Write ("{0} - {1}",i,tabulka[i]);
				}
			}
		}
	}
}
