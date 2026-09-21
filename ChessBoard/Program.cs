using System;
using Spectre.Console;
using ChessBoard;

namespace ChessBoard
{

    class Program
    {
        static void Main(string[] args) //Startpunkten
        {
            /*Ansiconsole.markupLine("[bold yellow] Chessboard[/]");*/ //markupline lägger fär på rubriken
            // Unicode-stöd i konsolen
            Console.OutputEncoding = System.Text.Encoding.UTF8


            while (true) //yttre loopen som håller programmet igång.
            {
                int nummer; //number måste ligga utanför loopen 

                while (true) // DEn inre Loopar till vi bryter oss ut med "Break" //
                             // när vi inte vet hur många försök det kommer ta
                {
                    Console.WriteLine("Ange storleken på schackbrädet 3 - 50, vill du avsluta ange 0! "); // Vi skriver ut en fråga till använden om att ge en siffra mellan 3 -50. 
                    string input = Console.ReadLine(); //VÄntar på att användaren ska skriva in siffror

                    if (input == "0")
                    {
                        Console.WriteLine("Tack för att du spelade!");
                        return; //Här avslutar vi main-metoden och stänger programmnet
                    }
                    // om gilitig, då går det att tolka som ett tal, det är minst 3, och det är max 50 
                    if (int.TryParse(input, out nummer) && nummer >= 3 && nummer <= 50) //Programmet kommer inte att krascha om man skriver text istället för siffra
                    {
                        break; // Giligt tal, den hoppar ut ur while loopen
                    }

                    Console.WriteLine("Fel inmatning, vad god ange en siffra"); //Skickar ut ett meddelande till användaren att skriva en siffra
                }

                var myBoard = new RenderBoard(nummer); // skapar schackbrädet - när vi anropar konstruktorn med användarens siffra.
                //myBoard.Render(); //Test
            }
        }
    }
}


