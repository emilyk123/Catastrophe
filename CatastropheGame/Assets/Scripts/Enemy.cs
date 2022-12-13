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
    public int health;

    // Start is called before the first frame update
    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
        health = 100;
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void FixedUpdate() {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.fixedDeltaTime);
    }

    private void Die() {
        Destroy(gameObject);
    }

    public void TakeDamage(int damage) {
        health -= damage;
        if(health <= 0) {
            Die();
        }
    }
}
