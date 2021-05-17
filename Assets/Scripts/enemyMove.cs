using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    private Rigidbody2D rb;
    // The speed of enemy movement
    private float speed;
    // position of the player
    public GameObject player;
    void Start()
    {
        speed = Random.Range(Constant.MIN_ENEMY_SPEED, Constant.MAX_ENEMY_SPEED);
        rb = transform.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2((player.transform.position.x - transform.position.x) * speed, (player.transform.position.y - transform.position.y) * speed);
    }
    // Update is called once per frame
    
}
