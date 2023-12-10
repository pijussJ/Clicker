using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    public float shrinkSpeed = 5;
    public Vector3 rotateSpeed;
    AudioSource source;
    private void OnMouseDown()
    {
        GameManager.clicks++;
        transform.localScale = Vector3.one * 1.5f;
        source.Play();
    }
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime);
        if (transform.localScale.x > 1f)
        {
            transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        }
    }
}
