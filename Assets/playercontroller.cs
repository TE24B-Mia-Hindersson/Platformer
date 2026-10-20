using System.Runtime.InteropServices;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
    
    } 
    void OnJump(Input value)
        {
            print("Jump");
            rb.AddForce(Vector2.up * 2000);
        }
}