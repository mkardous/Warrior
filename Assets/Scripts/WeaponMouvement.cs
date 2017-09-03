using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponMouvement: MonoBehaviour
{

    public Transform myPosition;
    public float linSpeed = 5f;
    public float maxDistance = 100f;
    public float myDistance = 5.0f;
    // Use this for initialization

    void Awake()
    {
        myPosition = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myPosition.Translate(Vector3.up * Time.deltaTime * linSpeed);

        myDistance += Time.deltaTime * linSpeed;

        if (myDistance > maxDistance)
        {
            Destroy(gameObject);
        }
    }
}