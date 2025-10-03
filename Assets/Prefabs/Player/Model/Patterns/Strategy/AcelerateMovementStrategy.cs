using UnityEngine;

public class AcelerateMovementStrategy : IMovementStrategy
{
    private float currentSpeed = 0f;
    void IMovementStrategy.Move(Transform transform, Player player, float dir)
    {
        currentSpeed += dir * player.Acceleration * Time.deltaTime;
        player.Speed = Mathf.Clamp(currentSpeed,-player.Speed,player.Speed);
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
    }
}
