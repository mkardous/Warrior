using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour {


    public int damage = 1;
    public bool playerAttack = false;

    private GameObject other;
    private Player otherScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (playerAttack)
        {
            
        }

        else
        {
            
        }
         
    }
}
