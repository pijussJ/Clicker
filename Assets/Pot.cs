using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameManager.clicks++;
        print("clicked");
    }
}
