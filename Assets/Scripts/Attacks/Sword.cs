using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

    private Transform position;

    private float rotationSpeed = 500f;

	// Use this for initialization
	void Awake ()
    {
        position = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        position.Rotate(0, 0, rotationSpeed * 1 / Time.deltaTime);
    }
}
