using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbingMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody2D rb;

    private bool isLadder;
    private bool isClimbing;
    private float speed = 5f;
    private float vertical;

   //Добавить привязку к тегу 2 руки
    private void FixedUpdate() {
        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x,vertical * speed);
        }
        else
        {
            rb.gravityScale = 3f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");

        if (isLadder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = true;
            
        }

    }
private void OnTriggerExit2D(Collider2D collision) {
         if (collision.CompareTag("Ladder"))
        {
            isLadder = false;
            isClimbing = false;
        }   
}
}
