using System;
using Spectre.Console;
using ChessBoard;

namespace ChessBoard
{

    class Program
    {
        static void Main(string[] args) //Startpunkten
        {
           
            // Unicode-stöd i konsolen
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            while (true) //yttre loopen som håller programmet igång.
            {
                int nummer = Readsize(); //Hämtar storleken från metoden nedan. 

                
                if (nummer == 0) //Stänger spelet om användaren skriver 0. 
                {
                    Console.WriteLine("Tack för att du spelade!");
                    break; 
                }


                var myBoard = new RenderBoard(nummer); // skapar schackbrädet med den godkända siffran, ritar brädet. 
                
            }
        }
                public static int Readsize()
                {
                while (true)
                {
                    Console.WriteLine("Ange storleken på schackbrädet 3 - 50, vill du avsluta ange 0! "); // Vi skriver ut en fråga till använden om att ge en siffra mellan 3 -50. 
                    string input = Console.ReadLine(); //VÄntar på att användaren ska skriva in siffror{
                    
                    if (input == "0")
                    {
                    return 0;
                    }
                    // om gilitig, då går det att tolka som ett tal, det är minst 3, och det är max 50 
                    if (int.TryParse(input, out int nummer) && nummer >= 3 && nummer <= 50) //Programmet kommer inte att krascha om man skriver text istället för siffra
                    {
                    return nummer; //Skickar tillbaka den godkända siffran till main.
                    }
                    

                        Console.WriteLine("Fel inmatning, vad god ange en siffra"); //Skickar ut ett meddelande till användaren att skriva en siffra
                    }
                }
    }   
}
