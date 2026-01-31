using System;
using Godot;

public partial class Board : Node2D
{
	[Export] public int GridWidth=10;
	[Export] public int GridHeight=10;
	[Export] public int CellSize=32;

	private int[,] _board;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		InitializeBoard();
		DrawBoard();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void InitializeBoard()
	{
		_board = new int[GridWidth, GridHeight];
		var displayBoard = "";
		for (int x = 0; x< GridWidth; x++)
		{
			for(int y = 0 ; y< GridHeight; y++)
			{
				_board[x, y] = 8;
				displayBoard += _board[x, y] + ", ";
			}
			displayBoard += "\n";
		}
		GD.Print(displayBoard);
	}

	private void DrawBoard()
	{
		
		var cellPackedScene = ResourceLoader.Load<PackedScene>("res://scenes/cell.tscn");
		for (int x = 0; x < GridWidth; x++)
		{
			for (int y = 0; y < GridHeight; y++)
			{
				var type = _board[x, y];
				Vector2 position = new Vector2(x * CellSize, y * CellSize);
				var instCell = (Cell)cellPackedScene.Instantiate();
				instCell.Initialize(type);
				instCell.Position = position;
				AddChild(instCell);
			}
		}
	}
}
