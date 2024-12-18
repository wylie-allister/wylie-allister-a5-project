using Godot;
using System;

public partial class Dropper : Node2D
{
    //Gives player speed
    float speed = 300;
    public int points;
    //Adds balls to scene
    [Export]
    private PackedScene Prefab;
    [Export]
    private PackedScene Prefab2;
    [Export]
    private PackedScene Prefab3;
    [Export]
    private PackedScene Prefab4;
    [Export]
    private PackedScene Prefab5;
    [Export]
    private Node2D BallParent;
    [Export]
    private ScoreUI ScoreUI;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        //Moves dropper
        float moveX = Input.GetAxis("left", "right") * speed * (float)delta;
        Translate(new Vector2(moveX, 0));

        //Randomizes dropped balls
        if (Input.IsActionJustPressed("drop"))
        {
            int randomBat = GD.RandRange(1, 5);
            if (randomBat == 1)
            {
                Node2D balls = Prefab.Instantiate<Node2D>();
                balls.GlobalPosition = this.GlobalPosition;
                BallParent.AddChild(balls);
                points += 1;
            }
            if (randomBat == 2)
            {
                Node2D balls = Prefab2.Instantiate<Node2D>();
                balls.GlobalPosition = this.GlobalPosition;
                BallParent.AddChild(balls);
                points += 2;
            }
            if (randomBat == 3)
            {
                Node2D balls = Prefab3.Instantiate<Node2D>();
                balls.GlobalPosition = this.GlobalPosition;
                BallParent.AddChild(balls);
                points += 3;
            }
            if (randomBat == 4)
            {
                Node2D balls = Prefab4.Instantiate<Node2D>();
                balls.GlobalPosition = this.GlobalPosition;
                BallParent.AddChild(balls);
                points += 4;
            }
            if (randomBat == 5)
            {
                Node2D balls = Prefab5.Instantiate<Node2D>();
                balls.GlobalPosition = this.GlobalPosition;
                BallParent.AddChild(balls);
                points += 5;
            }
            //adds to score
            ScoreUI.ScoreAdd(points);
        }
    }
}
