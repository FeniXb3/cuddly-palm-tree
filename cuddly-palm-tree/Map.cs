
class Map
{
    string[] mapData = new string[]{
        "#########",
        "#.......#",
        "#.......#",
        "#.......#",
        "#.......#",
        "#.......#",
        "#########",
    };
    
    private Point origin = new Point();
    
    public void Display(Point mapOrigin)
    {
        origin = mapOrigin;
        Console.CursorTop = mapOrigin.Y;
        foreach (string row in mapData)
        {
            Console.CursorLeft = mapOrigin.X;
            Console.WriteLine(row);
        }
    
    }

    internal void DrawSomethingAt(string visuals, Point position)
    {
        SetCursorPositionWithOrigin(position);
        Console.Write(visuals);
    }

    private void SetCursorPositionWithOrigin(Point position)
    {
        int x = position.X + origin.X;
        int y = position.Y + origin.Y;

        Console.SetCursorPosition(x, y);
    }

    public void RedrawCell(Point position)
    {
        string row = mapData[position.Y];
        char cell = row[position.X];

        SetCursorPositionWithOrigin(position);
        Console.Write(cell);
    }

    internal bool IsPositionCorrect(Point position)
    {
        if (position.Y >= 0 && position.Y < mapData.Length
            && position.X >= 0 && position.X < mapData[position.Y].Length)
        {
            return true;
        }

        return false;
    }
}