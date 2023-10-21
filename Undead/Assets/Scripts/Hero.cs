using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField]private float jumpForce = 4f;
    // Start is called before the first frame update
   
private Rigidbody2D rb;
private SpriteRenderer sprite;
private bool isGrounded = false;
[SerializeField] private AudioSource jumpEffect;
private void Awake()
{
    rb = GetComponent<Rigidbody2D>();
    sprite = GetComponentInChildren<SpriteRenderer>();
}

    
   
   private void FixedUpdate()
   {
    CheckGround();
   }
       void Update()
    {
        if (Input.GetButton("Horizontal"))
        Run();
        if (isGrounded && Input.GetButtonDown("Jump") && (gameObject.tag=="One leg" || gameObject.tag=="two legs"))
        Jump();
    }

private void Run()
{
    Vector3 dir = transform.right * Input.GetAxis("Horizontal");
    transform.position = Vector3.MoveTowards(transform.position,transform.position + dir, speed * Time.deltaTime);
    sprite.flipX = dir.x < 0.0f; 
}
   
private void Jump()
{
    
    if (gameObject.tag == "two legs"){
        jumpEffect.Play();
        rb.AddForce(transform.up * jumpForce*2, ForceMode2D.Impulse);
    } // переделать 
    else{
        jumpEffect.Play();
    rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
}

private void CheckGround()
{
    Collider2D[]collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
    isGrounded = collider.Length > 1;
}
   
    void Start()
    {
        
    }

    // Update is called once per frame

}
