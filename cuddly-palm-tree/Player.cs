class Player
{
 	public string Visuals { get; private set; }
    public Point Position { get; private set; }
    public Point PreviousPosition { get; private set; }

    public Player(string visuals, Point position)
	{
        Visuals = visuals;
        Position = new Point(position.X, position.Y);
        PreviousPosition = new Point(Position.X, Position.Y);
    }
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
