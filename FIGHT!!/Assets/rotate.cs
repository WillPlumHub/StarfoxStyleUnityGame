using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

    public float rotationSpeed = 30.0f;
    public Vector3 axis = Vector3.forward;

	void Start () {
	
	}

    void Update () {
        transform.RotateAround(axis, rotationSpeed * Mathf.Deg2Rad * Time.deltaTime);
	}
}
