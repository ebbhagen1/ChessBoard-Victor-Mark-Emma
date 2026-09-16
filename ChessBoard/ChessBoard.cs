using System;

public class ChessBoard
{
	public ChessBoard()
	{

	}
    public static int ReadSize()
    {
        Console.WriteLine("Ange storleken på schackbrädet 3 - 50. "); // Vi skriver ut en fråga till använden om att ge en siffra mellan 3 -50. 
        string input = Console.ReadLine();
    }
}
