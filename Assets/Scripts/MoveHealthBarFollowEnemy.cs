using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHealthBarFollowEnemy : MonoBehaviour
{
    public GameObject healthBar;
    public GameObject enemy;
    public bool isBoss;

    // Update is called once per frame
    void Update()
    {
        if (healthBar != null && enemy != null)
        {
            float distance = isBoss ? 0.5f : 0.4f;
            healthBar.transform.position = new Vector3(enemy.transform.position.x, enemy.transform.position.y - distance, enemy.transform.position.z);
        }
    }
}
