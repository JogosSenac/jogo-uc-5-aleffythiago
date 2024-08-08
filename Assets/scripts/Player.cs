
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;
    public float rotationMultiplier;
    public Animator animator;
    public int score;

    public GameManeger gm;
    public Rigidbody2D rb;
    private bool jump;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        jump = true;
    }
    private void FixedUpdate()
    {
        if (jump)
        {
            rb.velocity = Vector2.up * jumpForce;
            jump = false;
        }
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationMultiplier);
    }
}
