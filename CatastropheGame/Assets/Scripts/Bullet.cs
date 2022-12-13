using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 50;

    private Rigidbody2D rb;
    public GameObject enemy;

    private Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        mousePos = Input.mousePosition;
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Enemy enemy = collision.GetComponent<Enemy>();
        if(enemy != null) {
            enemy.TakeDamage(damage);
        }
        Object.Destroy(this.gameObject);
    }
}
