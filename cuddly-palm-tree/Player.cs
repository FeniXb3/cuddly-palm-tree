class Player
{
	public string visuals = "@";
	public Point position = new Point();
	public Point previousPosition = new Point();
	
	public void Display()
	{
		Console.SetCursorPosition(position.x, position.y);
		Console.Write(visuals);
	}
	
	public Point GetNextPosition()
	{
		Point point = new Point();
		point.x = position.x;
		point.y = position.y;
		
		ConsoleKeyInfo keyInfo = Console.ReadKey(true);
		if (keyInfo.Key == ConsoleKey.D)
		{
			point.x += 1;
		}
		else if (keyInfo.Key == ConsoleKey.A)
		{
			point.x -= 1;
		}
		else if (keyInfo.Key == ConsoleKey.W)
		{
			point.y -= 1;
		}
		else if (keyInfo.Key == ConsoleKey.S)
		{
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
