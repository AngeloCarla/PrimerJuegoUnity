using UnityEngine;

public class SmoothMovementStrategy : IMovementStrategy
{
    void IMovementStrategy.Move(Transform transform, Player player, float dir)
    {
        float moveInX = dir * player.Speed * Time.deltaTime;
        transform.Translate(moveInX,0,0);
    }
}
