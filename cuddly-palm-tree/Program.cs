using System;

public class Program
{
	public static void Main()
	{
		Console.CursorVisible = false;
		Console.Clear();
		Player hero = new Player("@", new Point(3, 2));
		Map map = new Map();
        Point mapOrigin = new Point(5, 3);

		try
		{
			map.Display(mapOrigin);
			map.DrawSomethingAt(hero.Visuals, hero.Position);
			while (true)
			{
				Point nextPosition = hero.GetNextPosition();
				if (map.IsPositionCorrect(nextPosition))
				{
					hero.MoveTo(nextPosition.X, nextPosition.Y);
					map.RedrawCell(hero.PreviousPosition);
					map.DrawSomethingAt(hero.Visuals, hero.Position);
				}
			}
		}
		catch (WindowToSmallToDrawException ex)
		{
			// Console.WriteLine($"Minimum required window size is ({ex.ExpectedSize.X}, {ex.ExpectedSize.Y})");
			Console.WriteLine(ex.Message);
			Console.WriteLine("Terminal window is to small to draw map. Make it bigger and restart the game.");
			Console.WriteLine("Press any key to close...");
            Console.ReadKey(true);
		}
		
	}
}

