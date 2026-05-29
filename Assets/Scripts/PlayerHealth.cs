using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 10;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log($"Игрок получил урон. Осталось HP: {currentHealth}");
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Игрок погиб!");
        Destroy(gameObject);
        // Можно перезагрузить сцену: SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}