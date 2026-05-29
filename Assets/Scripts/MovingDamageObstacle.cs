using UnityEngine;

public class MovingDamageObstacle : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private float speed = 3f;
    [SerializeField] private int damage = 5;
    [SerializeField] private float damageCooldown = 1f;

    private float lastDamageTime;
    private Vector3 targetPosition;

    void Start()
    {
        // Начинаем движение к точке B
        targetPosition = pointB.position;
    }

    void Update()
    {
        // Плавно двигаемся к целевой точке на фиксированной скорости
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Когда почти дошли — меняем цель на противоположную
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            targetPosition = (targetPosition == pointA.position) ? pointB.position : pointA.position;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Time.time - lastDamageTime >= damageCooldown)
            {
                PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(damage);
                    lastDamageTime = Time.time;
                }
            }
        }
    }
}