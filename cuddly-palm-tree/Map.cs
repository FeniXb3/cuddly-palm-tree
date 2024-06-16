
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
    
    public void Display()
    {
        foreach (string row in mapData)
        {
            Console.WriteLine(row);
        }
    }

    public void RedrawCell(Point position)
    {
        string row = mapData[position.y];
        char cell = row[position.x];

        Console.SetCursorPosition(position.x, position.y);
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