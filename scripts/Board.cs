using Godot;
using System;

public partial class Board : Node2D
{
	[Export] public int GridWidth=10;
	[Export] public int GridHeight=10;
	[Export] public int CellSize=32;

	private Cell[,] grid;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void InitializeBoard()
	{
		grid = new Cell[GridWidth, GridHeight];

		for (int x = 0; x< GridWidth; x++)
		{
			for(int y = 0 ; y< GridHeight; y++)
			{
				grid[x,y] = new Cell();
			}
		}
	}
}
