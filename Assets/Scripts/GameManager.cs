using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Ссылка статическая

    public int totalCoins = 0;
    public TMP_Text coinText;      // Ссылка на UI

    void Awake()
    {
        if (Instance == null) // GameManager в одном экземпляре
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Не уничтожать при загрузке новой сцены
        }
        else
        {
            Destroy(gameObject); // Удаляем дубликат
        }
    }

    public void AddCoin(int amount)
    {
        totalCoins += amount;
        if (coinText != null)
        {
            coinText.text = "Coins: " + totalCoins;
        }
    }
}