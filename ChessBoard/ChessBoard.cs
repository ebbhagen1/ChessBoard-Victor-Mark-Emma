using System;

public class ChessBoard //Klass Chessboard (När vi skapar ett objekt i Program.cs skickar vi med nummer via konstruktor
{
	public ChessBoard(int size) //Konstruktor tar emot storleken som en parameter 
	{ 
		
		for (int rad = 0; rad < size, rad++) //yttrelopp för rader baserat på användarens inmatning 
		{
			for (int kolumn = 0; kolumn < size; kolumn++) //inre loop (Kolumn är bredden på schackbrädet)
			{
				//Modulo kan räkna ut schackmönstret oavsett vilken storlek användaren väljer
				if ((rad + kolumn) % 2 == 0) // Om rad och kolumn är jämna, skriver programemet ut en X ruta, ananrs 0

				{
				Console.Write(" X "); 

				}
				 else
				{
					Console.Write(" 0 "); 
				}
			}
			Console.WriteLine(); //Hoppar till nästa rad när kolumnerna är klara
		}
	}
   
   
}
