using System;
					
public class Program
{
	public static void Main()
	{
		Player hero = new Player();
		hero.Display();
		while (true)
		{
			Point nextPosition = hero.GetNextPosition();
			hero.MoveTo(nextPosition.x, nextPosition.y);
			hero.Display();
		}
	}
}

class Point
{
	public int x;
	public int y;
}

class Player
{
	string visuals = "@";
	Point position = new Point();
	
	public void Display()
	{
		Console.Write(visuals);
		//@ at (2, 5)
		Console.WriteLine($" at ({position.x}, {position.y})");
	}
	
	public Point GetNextPosition()
	{
		Point point = new Point();
		point.x = position.x;
		point.y = position.y;
		
		ConsoleKeyInfo keyInfo = Console.ReadKey(true);
		if (keyInfo.Key == ConsoleKey.D)
		{
			// dodaj 1 do x
			point.x += 1;
		}
		
		
		return point;
	}
	
	public void MoveTo(int targetX, int targetY)
	{
		position.x = targetX;
		position.y = targetY;
	}
}

/*
Klasa Player
dane:
- nick
- reprezentacja wizualna
- punkty życia
- siła ataku
- pozycja

akcje:
- poruszanie się
- atak
- zbieranie obrażeń
- leczenie się
- wyświetlanie
- animacja

*/