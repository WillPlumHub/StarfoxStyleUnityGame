using UnityEngine;
using System.Collections;

public class moveForward : MonoBehaviour {

    public float speed = -1.0f;
    
	void Update () {
        transform.position += transform.forward*speed*Time.deltaTime;
	}
}