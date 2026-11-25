using UnityEngine;

public class phantomhealth : MonoBehaviour
{
    [SerializeField]
    int health = 30;

    public void TakeDamage()
    {
        health--;

        Debug.Log("Phantom health: " + health);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}