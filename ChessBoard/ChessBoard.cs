using System;

public class ChessBoard
{
	public ChessBoard
	{
		for (int rad = 3; < rad 50; rad++) //yttreloopen som går rad för rad upp till 50 (höjden)
		{
			for (int kolumn = 3; < kolumn 50; kolumn++) //inre loop för aktuella raden (bredden)
			{
				if (rad + kolumn % 2 == 0) ; // Om rad och kolumn är jämna, skriv ut en X ruta, ananrs 0

				{
					Console.writeline("X"); //Skriver ut X 

				}
				 else
				{
					Console.WriteLine("0"); // Skriver ut 0
				}
			}
		}
	}
   
   
}
