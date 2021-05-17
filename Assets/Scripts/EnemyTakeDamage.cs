using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    private int HP;
    public GameObject enemy;
    public HealthBar healthBar;
    public Canvas canvas;
    private GameObject game;
    private GameObject Shooting;
    // Start is called before the first frame update
    void Start()
    {
        int choice = Random.Range(0, 1);
        if (choice == 0)
        {
            HP = Constant.MIN_HP_ENEMY;
        }
        else HP = Constant.MAX_HP_ENEMY;
        healthBar.SetMaxHealth(HP);
        game = GameObject.FindGameObjectWithTag("GameController");
        Shooting = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (HP <= 0)
        {
            Destroy(enemy);
            Destroy(healthBar);
            Destroy(canvas.gameObject);
            game.GetComponent<GameControl>().count();
            Shooting.GetComponent<ShootingPlayer>().power++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag.Equals("bouncy bullet normal"))
        {
            HP -= Constant.BOUNCY_BULLET_NORMAL_DAMAGE;
            healthBar.SetHealth(HP);
        }
        if (collision.collider.tag.Equals("bouncy bullet power"))
        {
            HP -= Constant.BOUNCY_BULLET_POWER_DAMAGE;
            healthBar.SetHealth(HP);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            game.GetComponent<GameControl>().EndGame();
        }
        if (collision.tag.Equals("piercing bullet normal"))
        {
            HP -= Constant.PIERCING_BULLET_NORMAL_DAMAGE;
            healthBar.SetHealth(HP);
        }
        if (collision.tag.Equals("piercing bullet power"))
        {
            HP -= Constant.PIERCING_BULLET_POWER_DAMAGE;
            healthBar.SetHealth(HP);
        }
    }
}
