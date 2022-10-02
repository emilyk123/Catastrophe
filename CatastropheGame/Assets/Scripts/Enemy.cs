using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void FixedUpdate() {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, moveSpeed * Time.fixedDeltaTime);
    }
}
