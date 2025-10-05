using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Si colisiona con un gameobject con tag Player
        if (collision.collider.CompareTag("Player")) 
        {
            Destroy(gameObject); // Se destruye el gameObject
        }
    }
}
