using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroller : MonoBehaviour
{
    [SerializeField]
    float jumpforce = 1000;
    [SerializeField]
    float walkspeed = 40;
    Rigidbody2D rb;
    SpriteRenderer sr;
    private float movementX;
    [SerializeField]
    GameObject bluenotePrefab;
    [SerializeField]
    Transform shootingpoints;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {
        rb.linearVelocityX = movementX * walkspeed;
    }
    void OnJump(InputValue value)
    {
        rb.AddForce(Vector2.up * jumpforce);
    }
    void OnMove(InputValue value)
    {


        movementX = value.Get<Vector2>().x;

        if (movementX < 0)
        {
            sr.flipX = true;
        }
        else if (movementX > 0)
        {
            sr.flipX = false;
        }
    }
    void OnFire(InputValue value)
    {
        Debug.Log("HELLO");
        if (value.isPressed)
        {
            GameObject bluenote = Instantiate(bluenotePrefab, shootingpoints.position, Quaternion.identity);
        }
        float direction = sr.flipX ? -1f : 1f;
        bluenotePrefab.GetComponent<projectilebluenote>().SetDirection(direction);
    }
}