using UnityEngine;

public class SmoothMovementStrategy : IMovementStrategy
{
    void IMovementStrategy.Move(Transform transform, Player player)
    {
        float moveInX = Input.GetAxis("Horizontal") * player.Speed * Time.deltaTime;
        transform.Translate(moveInX,0,0);
    }
}
