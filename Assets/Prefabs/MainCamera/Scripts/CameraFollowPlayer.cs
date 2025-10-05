using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField]private Vector3 offset; // Con el SerializeField se puede modificar en el inspector
    private PlayerMovement playerMovement;
    
    void Start()
    {
        playerMovement = FindFirstObjectByType<PlayerMovement>(); // Busca el objeto con PlayerMovement
    }

    private void LateUpdate()
    {
        // La cámara sigue al jugador manteniendo el offset
        gameObject.transform.position = playerMovement.transform.position + offset; 
    }
}
