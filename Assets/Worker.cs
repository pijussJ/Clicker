using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Worker : MonoBehaviour
{
    public string name;
    public int count;
    public int price;
    public int cps;
    public Button button;

    public TMP_Text countText;
    public TMP_Text priceText;

    private void Update()
    {
        countText.text = count.ToString();
        priceText.text = "Price: " + price;

        var canClick = GameManager.clicks >= price;
        button.interactable = canClick;
    }
    void Start()
    {
        InvokeRepeating("Work", 1f, 1f);
        Load();
    }
    void Work()
    {
        GameManager.clicks += count * cps;
    }
    public void Buy()
    {
        if (GameManager.clicks < price) return;

        GameManager.clicks -= price;
        price = (int)(price * 1.4f);
        count++;
        Save();
    }

    void Save()
    {
        PlayerPrefs.SetInt(name, count);
        PlayerPrefs.SetInt(name + "price", price);
    }
    void Load()
    {
        count = PlayerPrefs.GetInt(name);
        price = PlayerPrefs.GetInt(name + "price", price);
    }
}
