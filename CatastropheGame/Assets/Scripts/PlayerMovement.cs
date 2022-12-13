using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 5f;
    public GameObject bullet;
    private bool lookingRight;

    // Start is called before the first frame update
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        lookingRight = true;
    }

    // Update is called once per frame
    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if(Input.GetKeyDown(KeyCode.A) && lookingRight) {
            transform.Rotate(0, 180f, 0);
            lookingRight = false;
        }
        
        if(Input.GetKeyDown(KeyCode.D) && !lookingRight) {
            transform.Rotate(0, 180f, 0);
            lookingRight = true;
        }
    }

    private void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
