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


            while (true) //yttre loopen som gör att programmet fortsätter tills användaren väljer att avsluta med 0
            {
                int nummer = Readsize(); //Anropar metoden ReadSize för att få godkänd storlek från användaren

                
                if (nummer == 0) //Stänger spelet om användaren skriver 0. 
                {
                    Console.WriteLine("Tack för att du spelade!");
                    break; //Avbryter loopen och avslutar programmet. 
                }


                var myBoard = new RenderBoard(nummer); // skapar schackbrädet med den godkända siffran, ritar brädet. 
                
            }
        }
                public static int Readsize() //En metod som hanterar användarens inmatning och validering
                {
                while (true) //loopar tills användaren matar in en giltig siffra
                {
                    Console.WriteLine("Ange storleken på schackbrädet 3 - 50, vill du avsluta ange 0! "); // Vi skriver ut en fråga till använden om att ge en siffra mellan 3 -50. 
                    string input = Console.ReadLine(); //Läser in råtext
                    
                    if (input == "0") //Snabbkoll om användaren vill avsluta programmet direkt 
                    {
                    return 0;
                    }
                //int.tryparse kollar om inmatningen är ett giltigt heltal 3-50 och gör så att programmet ej kommer att krascha om man skriver text istället för siffra
                if (int.TryParse(input, out int nummer) && nummer >= 3 && nummer <= 50) 
                    {
                    return nummer; //Skickar tillbaka den godkända siffran till main.
                    }
                    

                        Console.WriteLine("Fel inmatning, vad god ange en siffra"); //Skickar ut ett meddelande till användaren att skriva en siffra
                    }
                }
    }   
}
