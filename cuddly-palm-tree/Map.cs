
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
        Console.CursorTop = mapOrigin.y;
        foreach (string row in mapData)
        {
            Console.CursorLeft = mapOrigin.x;
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
        int x = position.x + origin.x;
        int y = position.y + origin.y;

        Console.SetCursorPosition(x, y);
    }

    public void RedrawCell(Point position)
    {
        string row = mapData[position.y];
        char cell = row[position.x];

        SetCursorPositionWithOrigin(position);
        Console.Write(cell);
    }

    internal bool IsPositionCorrect(Point position)
    {
        if (position.y >= 0 && position.y < mapData.Length
            && position.x >= 0 && position.x < mapData[position.y].Length)
        {
            return true;
        }

        return false;
    }
}