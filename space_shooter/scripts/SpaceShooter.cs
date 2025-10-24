using Godot;
using System;

public partial class SpaceShooter : Node
{
	public override void _Ready()
	{
		// GODOT write debug message
		GD.Print("SpaceShooter is ready!");
	}

	public override void _Process(double delta)
	{
		GD.Print($"Frame updated. Delta time: {delta}");
	}
}
