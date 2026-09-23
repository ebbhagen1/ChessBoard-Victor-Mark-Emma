using System;
using System.Runtime.InteropServices.Marshalling;
using Spectre.Console;  //Installerat Spectre.console som låter oss rita ut snygga gränssnitt med färgstark text eller animationer.

namespace ChessBoard
{
	public class RenderBoard //Klass som ansvarar för att bygga och skriva ut schackbrädet. 
	{
		public RenderBoard(int size) //Konstruktor tar emot storleken som en parameter = int size när objektet skapas
		{

			for (int rad = 0; rad < size; rad++)  //yttrelopp som håller reda på rader (höjden) baserat på användarens inmatning 
			{
				for (int kolumn = 0; kolumn < size; kolumn++) //inre loop som håller reda på kolumnerna, (bredden på varje enskild rad)
				{
					
					if (IsDarkSquare(rad, kolumn)) // Anropar hjälpmetod IsDarkSquare för att avgöra om raden ska vara mörk eller ljus 

                    {
						AnsiConsole.Markup($"[white] ◼︎ [/]");//För att kunna skriva ut i färger/tecken behöver vi använda AnsiConsole. 
																// Skriver ut en mörk ruta med vit tecken
					}
					else
					{
						AnsiConsole.Markup($"[white] ◻︎ [/]"); //skriver ut en ljus markerad ruta om inte villkoret uppfylls
					}
				}

				Console.WriteLine(); //När den inre loopen är klar för en rad för vi ett radbyte
			}


			bool IsDarkSquare(int rad, int kolumn) //Lokal hjälpmetod för att räkna ut schackmönstret

            {       //Modulo (% 2) kollar om summan av rad och kolumn är jämn (villkoret)
                return (rad + kolumn) % 2 == 0; //om summan är jämn blir det true (mörk ruta) annars false (ljus ruta)

			}
		}
	}
}








