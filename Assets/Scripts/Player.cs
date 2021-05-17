using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxPower;
    public int curPower;
    public PowerBar pBar;

    void Start()
    {
        curPower = 0;
        pBar.setMaxPower(Constant.MAX_POWER_ENERGY);
    }

    // Update is called once per frame
    void Update()
    {
        pBar.setPower( GetComponent<ShootingPlayer>().power);
    }
   
}
