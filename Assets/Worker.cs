using UnityEngine;
using TMPro;

public class Worker : MonoBehaviour
{
    public string name;
    public int count;
    public int price;
    public int cps;

    public TMP_Text countText;
    public TMP_Text priceText;

    private void Update()
    {
        countText.text = count.ToString();
        priceText.text = "Price: " + price;
    }
    void Start()
    {
        Load();
    }
    public void Buy()
    {
        if (GameManager.clicks < price) return;

        GameManager.clicks -= price;
        count++;
        Save();
    }

    void Save()
    {
        PlayerPrefs.SetInt(name, count);
    }
    void Load()
    {
        count = PlayerPrefs.GetInt(name);
    }
}
