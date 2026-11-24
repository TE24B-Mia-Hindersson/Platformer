using System;
using UnityEngine;

public class projectilebluenote : MonoBehaviour
{
    [SerializeField]
    float speed = 8f;
    [SerializeField]
    float lifetime = 3f;
    float direction = 1f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * direction * Time.deltaTime);
    }
    public void SetDirection(float newDirection)
    {
        direction = newDirection;
    }

   void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("phantom"))
    {
        collision.GetComponent<phantomhealth>().TakeDamage();

        Destroy(gameObject);
    }
}


}
