namespace ChessBoard;

class Program
{
    static void Main(string[] args) //Startpunkten
    {
        {
            Console.WriteLine("Ange storleken på schackbrädet 3 - 50. "); // Vi skriver ut en fråga till använden om att ge en siffra mellan 3 -50. 
            string input = Console.ReadLine(); //VÄntar på att användaren ska skriva in siffror


            if int.TryParse(input.out int nummer 3 && 50;); //Programmet kommer inte att krascha om man skriver text istället för siffra
            {
                Console.WriteLine("Fel inmatning, vad god ange en siffra"); //Skickar ut ett meddelande till användaren att skriva en siffra
            }
        }
}

    //Refaktuering - fixar/städar upp koden så att den blir lättare att förstå. Byta namn, ta bort dubbleter och långa metoder
    //Merge konflikt - Att inte ändra medans den andra kodar. Svårt att läsa in koden igen, kunde undo via "git changes" och sen hela filer. 
