class Player
{
	public string Visuals { get; private set; } = "@";
	public Point Position { get; private set; } = new Point(0, 0);
	public Point PreviousPosition { get; private set; } = new Point(0, 0);
	
	public void Display()
	{
		Console.SetCursorPosition(Position.X, Position.Y);
		Console.Write(Visuals);
	}
	
	public Point GetNextPosition()
	{
		Point point = new Point(Position.X, Position.Y);
		
		ConsoleKeyInfo keyInfo = Console.ReadKey(true);
		if (keyInfo.Key == ConsoleKey.D)
		{
			point.X += 1;
		}
		else if (keyInfo.Key == ConsoleKey.A)
		{
			point.X -= 1;
		}
		else if (keyInfo.Key == ConsoleKey.W)
		{
			point.Y -= 1;
		}
		else if (keyInfo.Key == ConsoleKey.S)
		{
			point.Y += 1;
		}
		
		return point;
	}
	
	public void MoveTo(int targetX, int targetY)
	{
		PreviousPosition.X = Position.X;
		PreviousPosition.Y = Position.Y;

		Position.X = targetX;
		Position.Y = targetY;
	}
}
