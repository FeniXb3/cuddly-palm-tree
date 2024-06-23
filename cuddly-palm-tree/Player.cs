class Player
{
	public string Visuals { get; private set; } = "@";
	public Point Position { get; private set; } = new Point();
	public Point PreviousPosition { get; private set; } = new Point();
	
	public void Display()
	{
		Console.SetCursorPosition(Position.x, Position.y);
		Console.Write(Visuals);
	}
	
	public Point GetNextPosition()
	{
		Point point = new Point();
		point.x = Position.x;
		point.y = Position.y;
		
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
		PreviousPosition.x = Position.x;
		PreviousPosition.y = Position.y;

		Position.x = targetX;
		Position.y = targetY;
	}
}
