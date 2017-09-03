using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByWall : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "MainCamera")
        {
            return;
        }

        else
        {
            Destroy(collision.gameObject);
        }
    }
}

