using System;
using System.Runtime.InteropServices.Marshalling;
using Spectre.Console;  //Spectre låter oss rita ut snygga gränssnitt med färgstark text eller animationer.

namespace ChessBoard
{
	public class RenderBoard //Klass Renderboard 
	{
		public RenderBoard(int size) //Konstruktor tar emot storleken som en parameter = int size
		{

			for (int rad = 0; rad < size; rad++)  //yttrelopp för rader baserat på användarens inmatning 
			{
				for (int kolumn = 0; kolumn < size; kolumn++) //inre loop (Kolumn är bredden på schackbrädet)
				{
					//Modulo kan räkna ut schackmönstret oavsett vilken storlek användaren väljer
					if (IsDarkSquare(rad, kolumn)) // Om rad och kolumn är jämna, skriver programemet ut en ◼︎ ruta, ananrs ◻︎ 

                    {
						AnsiConsole.Markup($"[white] ◼︎ [/]");//För att kunna skriva ut i färger/tecken behöver vi använda AnsiConsole. 

					}
					else
					{
						AnsiConsole.Markup($"[white] ◻︎ [/]"); //skapar en svart ruta 
					}
				}

				Console.WriteLine(); //Hoppar till nästa rad när kolumnerna är klara
			}


			bool IsDarkSquare(int rad, int kolumn)

			{
				return (rad + kolumn) % 2 == 0; //Tar emot 2 vården, om summan blir jämn (true) skapas en mörk ruta annars vit. (ojämn)

			}
		}
	}
}








