class Player : Character
{
	public Player(string visuals, Point position) : base(visuals, position)
	{
	}

    protected override Point GetDirection()
    {
		Point point = new Point(0, 0);

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
}
