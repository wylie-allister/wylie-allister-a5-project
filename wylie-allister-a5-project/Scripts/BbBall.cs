using Godot;
using System;

public partial class BbBall : RigidBody2D
{
	//gives each ball a value
	[Export]
	public int ballValue = 1;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
