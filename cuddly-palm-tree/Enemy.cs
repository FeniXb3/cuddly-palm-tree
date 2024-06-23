class Enemy
{
	public string Visuals { get; private set; }
	public Point Position { get; private set; }
	public Point PreviousPosition { get; private set; }

    private Random rng;

	public Enemy(string visuals, Point position)
	{
		Visuals = visuals;
		Position = new Point(position.X, position.Y);
		PreviousPosition = new Point(Position.X, Position.Y);

        rng = new Random();
	}
	public void Display()
	{
		Console.SetCursorPosition(Position.X, Position.Y);
		Console.Write(Visuals);
	}

	public Point GetNextPosition()
	{
		Point point = new Point(Position.X, Position.Y);
        point.X += rng.Next(-1, 2);
        point.Y += rng.Next(-1, 2);

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
