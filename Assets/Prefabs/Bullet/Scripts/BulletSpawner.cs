using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    
    void Start()
    {
        Invoke("ShootBulletInvoke", 1f); // Solo se instancia una vez
        InvokeRepeating("ShootBulletRepeating", 3f, 2f); // Se instancia cada 2 segundo
    }

    public void ShootBulletInvoke()
    {
        Debug.Log("Invoke");
        GameObject bulletClone = Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.GetComponent<Renderer>().material.color = Color.red; // Cambia a color rojo (para diferenciar)
        Destroy(bulletClone, 3f); // Destruye la bala clonada
    }
    public void ShootBulletRepeating()
    {
        Debug.Log("InvokeRepeating");
        GameObject bulletClone = Instantiate(bullet, transform.position, transform.rotation);
        Destroy(bulletClone, 3f); // Destruye la bala clonada
    }
}
