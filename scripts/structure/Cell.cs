using System.IO;
using Godot;

public struct Cell
{
    public enum Type
    {
        Empty,
        Wall,
        Monster,
        Treasure
    }

    public Type CellType { get; set; }

    public Cell(Type type = Type.Empty)
    {
        CellType = type;
    }
}