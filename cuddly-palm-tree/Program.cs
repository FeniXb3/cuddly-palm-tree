using System;

public class Program
{
	public static void Main()
	{
		Console.CursorVisible = false;
		Console.Clear();
		Player hero = new Player("@", new Point(3, 2));
		Enemy troll = new Enemy("T", new Point(4, 5));
		Map map = new Map();
        Point mapOrigin = new Point(5, 3);

		int round = 1;

		try
		{
			map.Display(mapOrigin);
			map.DrawSomethingAt(hero.Visuals, hero.Position);
			map.DrawSomethingAt(troll.Visuals, troll.Position);
			while (true)
			{
				Point nextPosition = hero.GetNextPosition();
				// if (round % 5 == 0)
				// {
				// 	nextPosition = hero.respawnPosition;
				// }

				if (map.IsPositionCorrect(nextPosition))
				{
					hero.MoveTo(nextPosition.X, nextPosition.Y);
					map.RedrawCell(hero.PreviousPosition);
					map.DrawSomethingAt(hero.Visuals, hero.Position);
				}

				int distanceX = Math.Abs(hero.Position.X - troll.Position.X);
				int distanceY = Math.Abs(hero.Position.Y - troll.Position.Y);

				if ((distanceX == 1 && distanceY == 0) || (distanceX == 0 && distanceY == 1))
				{
					Console.SetCursorPosition(2, 0);
					Console.WriteLine("Troll!! Troll in the dungeon!!! Press any key to continue");
					Console.ReadKey(true);
					Console.SetCursorPosition(2, 0);
					Console.WriteLine("Troll!! Troll in the dungeon!!!                           ");
				}
				else
				{
					Console.SetCursorPosition(2, 0);
					Console.WriteLine("                                 ");
				}
				
				nextPosition = troll.GetNextPosition();
				if (map.IsPositionCorrect(nextPosition))
				{
					troll.MoveTo(nextPosition.X, nextPosition.Y);
					map.RedrawCell(troll.PreviousPosition);
					map.DrawSomethingAt(troll.Visuals, troll.Position);
				}

				distanceX = Math.Abs(hero.Position.X - troll.Position.X);
				distanceY = Math.Abs(hero.Position.Y - troll.Position.Y);

				if ((distanceX == 1 && distanceY == 0) || (distanceX == 0 && distanceY == 1))
				{
					Console.SetCursorPosition(2, 1);
					Console.WriteLine("Spotted by troll!");
				}
				else
				{
					Console.SetCursorPosition(2, 1);
					Console.WriteLine("                                 ");
				}

				round++;
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

