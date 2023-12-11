using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int clicks;
    public TMP_Text clicksText;
    private void Start()
    {
        Load();
        InvokeRepeating("Save", 3f, 3f);
    }
    private void Update()
    {
        clicksText.text = clicks.ToString();
    }
    void Save()
    {
        PlayerPrefs.SetInt("clicks", clicks);
    }
    void Load()
    {
        clicks = PlayerPrefs.GetInt("clicks");
    }
    private void OnApplicationQuit()
    {
        Save();

    }


}
