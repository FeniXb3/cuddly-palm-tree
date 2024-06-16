class Player
{
	string visuals = "@";
	Point position = new Point();
	public Point previousPosition = new Point();
	
	public void Display()
	{
		Console.SetCursorPosition(position.x, position.y);
		Console.Write(visuals);
		//@ at (2, 5)
		// Console.WriteLine($" at ({position.x}, {position.y})");
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
		else if (keyInfo.Key == ConsoleKey.A)
		{
			// dodaj 1 do x
			point.x -= 1;
		}
		else if (keyInfo.Key == ConsoleKey.W)
		{
			// dodaj 1 do x
			point.y -= 1;
		}
		else if (keyInfo.Key == ConsoleKey.S)
		{
			// dodaj 1 do x
			point.y += 1;
		}
		
		return point;
	}
	
	public void MoveTo(int targetX, int targetY)
	{
		previousPosition.x = position.x;
		previousPosition.y = position.y;

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