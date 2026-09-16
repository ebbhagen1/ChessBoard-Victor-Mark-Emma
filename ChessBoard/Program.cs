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