using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public GameObject bullet;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("surrounding wall"))
        {
            Destroy(bullet);
        }
    }
}
   
