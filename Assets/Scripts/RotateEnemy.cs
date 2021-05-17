using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy : MonoBehaviour
{
    private GameObject obj;
    private Rigidbody2D rig;
    private Vector3 cur;
    private Vector2 playerPosition = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        rig = obj.GetComponent<Rigidbody2D>();
        cur = obj.transform.position;
        float rot = Mathf.Atan2(cur.y, cur.x) * 180f / Mathf.PI;
        obj.transform.Rotate(playerPosition.x, playerPosition.y, rot - 180);
    }
}
