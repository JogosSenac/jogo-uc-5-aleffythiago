
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float jumpForce;
    public float rotationMultiplier;
    public Animator animator;
    public int score;
    public bool startGame = false;
    public UIscript gm;
    public Rigidbody2D rb;
    
    private bool jump;

    void Start()
    {
        rb.Sleep();
        gm = GameObject.Find("UI").GetComponent<UIscript>();
    }
    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            startGame = true;
        }

        if(GameStart())
        {
            rb.WakeUp();
        }

        if(Input.GetMouseButton(0) && GameStart())
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        FlyMode();
    }
    private void OnCollisionEnter2D(Collision collision)
    {
        if(!collision.collider.name.Equals("Parede"))
        {
            if(collision.collider.tag.Equals("Obstaculo"))
            foreach(BoxCollider2D col in collision.collider.transform.parent.GetComponentsInChildren<BoxCollider2D>())
            col.enabled = false;
            animator.enabled = false;
        }
        if(collision.gameObject.CompareTag("Chao"))
        {
            Destroy(rb);
            gm.GameOverPanel();
        }
        if(collision.gameObject.CompareTag("Cano"))
        {
            Destroy(rb);
            gm.GameOverPanel();
        }
        
    }


    void FlyMode()
    {
        if(jump)
        {
            rb.velocity = Vector2.up * jumpForce;
            jump = false;
        }
        if(rb.velocity.sqrMagnitude>0)
        {
            transform.rotation = Quaternion.Euler(0,0, Mathf.Clamp((rb.velocity.y + 2) * rotationMultiplier, -85, 20));
        }
        
    }
    private bool GameStart()
    {
        return startGame;
    }

    
}


