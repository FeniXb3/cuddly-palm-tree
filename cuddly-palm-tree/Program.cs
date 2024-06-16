using System;

/*

#########
#.......#
#.......#
#.......#
#.......#
#########

*/


public class Program
{
	public static void Main()
	{
		Console.CursorVisible = false;
		Console.Clear();
		Player hero = new Player();
		Map map = new Map();
		map.Display();
		hero.Display();
		while (true)
		{
			Point nextPosition = hero.GetNextPosition();
			if (map.IsPositionCorrect(nextPosition))
			{
				hero.MoveTo(nextPosition.x, nextPosition.y);
				map.RedrawCell(hero.previousPosition);
				hero.Display();
			}
		}
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
