using Godot;

public partial class Cell : Node2D
{
    [Export] public int CellType = 0;

    private Sprite2D sprite = new Sprite2D();

    public void Initialize(int type)
    {
        CellType = type;
        sprite.Texture = GD.Load<Texture2D>(TypeTextureLink(type));
        AddChild(sprite);
    }

    private string TypeTextureLink(int type)
    {
        string textureLink = type switch
        {
            0 => "res://assets/images/ground.png",
            1 => "res://assets/images/wall.png",
            2 => "res://assets/images/monster1.png",
            3 => "res://assets/images/chest.png",
            _ => "res://assets/images/icon.svg"
        };
        return textureLink;
    }
    
}


