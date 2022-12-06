using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void FixedUpdate() {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Bullet") {
            Object.Destroy(this.gameObject);
        }
    }
}
