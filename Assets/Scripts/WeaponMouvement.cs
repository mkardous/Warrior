using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponMouvement: MonoBehaviour
{

    public Transform myPosition;
    public float linearSpeed = 5f;
    public float maxDistance = 10f;
    private float myDistance = 0f;
    // Use this for initialization

    void Awake()
    {
        myPosition = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myPosition.Translate(Vector3.up * Time.deltaTime * linearSpeed);

        myDistance += Time.deltaTime * linearSpeed;

        if (myDistance > maxDistance)
        {
            Destroy(gameObject);
        }
    }
}