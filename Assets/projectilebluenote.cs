using System;
using UnityEngine;

public class projectilebluenote : MonoBehaviour
{
    [SerializeField]
    float speed = 8f;
    [SerializeField]
    float lifetime = 3f;
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("phantom"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
