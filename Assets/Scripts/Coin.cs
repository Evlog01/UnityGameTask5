using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1; // Сколько очков дает монетка
    public float rotateSpeed = 90f; // Скорость вращения монетки

    void Update()
    {
        transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime); // Вращение монетки
    }

    // Функция триггера
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Триггер на игрока
        {
            GameManager.Instance.AddCoin(coinValue); // Добавляем очки

            Destroy(gameObject); // Уничтожаем монетку
        }
    }
}