using UnityEngine;

public class ExplosiveBarrel : MonoBehaviour
{
    [SerializeField] private float destroyForceThreshold = 8f; // минимальная скорость столкновения для уничтожения игрока

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log($"Столкновение с бочкой. Относительная скорость: {collision.relativeVelocity.magnitude}");
            if (collision.relativeVelocity.magnitude >= destroyForceThreshold)
            {
                Destroy(collision.gameObject);
                Debug.Log("Игрок уничтожен бочкой!");
                // Здесь позже можно добавить эффект взрыва
            }
        }
    }
}