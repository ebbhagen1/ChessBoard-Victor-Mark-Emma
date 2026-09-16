using System;

namespace ChessBoard
{

    class Program
    {
        static void Main(string[] args) //Startpunkten
        {
            int nummer; //number måste ligga utanför loopen för att använda senare

            while (true) // Vi Loopar till vi bryter oss ut med "Break" //
                         // när vi inte vet hur många försök det kommer ta
            {
                Console.WriteLine("Ange storleken på schackbrädet 3 - 50. "); // Vi skriver ut en fråga till använden om att ge en siffra mellan 3 -50. 
                string input = Console.ReadLine(); //VÄntar på att användaren ska skriva in siffror

                // om gilitig, då går det att tolka som ett tal, det är minst 3, och det är max 50 
                if (int.TryParse(input, out nummer) && nummer >= 3 && nummer <= 50) //Programmet kommer inte att krascha om man skriver text istället för siffra
                {
                    break; // Giligt tal, den hoppar ut ur while loopen
                }

                Console.WriteLine("Fel inmatning, vad god ange en siffra"); //Skickar ut ett meddelande till användaren att skriva en siffra
            }
            RenderBoard myBoard = new RenderBoard(nummer); // skapar schackbrädet - när vi anropar konstruktorn med användarens siffra.
        }
    }
}


    //Refaktuering - fixar/städar upp koden så att den blir lättare att förstå. Byta namn, ta bort dubbleter och långa metoder
    //Merge konflikt - Att inte ändra medans den andra kodar. Svårt att läsa in koden igen, kunde undo via "git changes" och sen hela filer. 
