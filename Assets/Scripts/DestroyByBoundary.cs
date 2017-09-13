using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("On Trigger Enter");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("On trigger Exit");
    }
}
