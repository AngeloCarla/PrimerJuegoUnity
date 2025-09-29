using System;

public class Player
{
    private float speed;
    private float acceleration;

    public Player(float speed, float acceleration)
    {
        this.speed = speed;
        this.acceleration = acceleration;
    }

    public float Speed { get => speed; set => speed = value; }
    public float Acceleration { get => acceleration; set => acceleration = value; }
}
