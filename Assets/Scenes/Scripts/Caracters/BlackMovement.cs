using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;
    public LayerMask groundLayer;
    [SerializeField]
    private AudioSource SoundJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float blackXdir = Input.GetAxis("Horizontal Negro");

        rb.velocity = new Vector2 (blackXdir*speed, rb.velocity.y);

        if (Input.GetKey(KeyCode.UpArrow) && IsGrounded()) 
        {rb.velocity = new Vector2 (rb.velocity.x,jumpForce);
        SoundJump.Play();}
        
    }

    bool IsGrounded() {
    Vector2 position = transform.position;
    Vector2 direction = Vector2.down;
    float distance = transform.localScale.magnitude*0.055f;
    
    RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
    if (hit.collider != null) {
        return true;
    }
    
    return false;
    }

    

    
}