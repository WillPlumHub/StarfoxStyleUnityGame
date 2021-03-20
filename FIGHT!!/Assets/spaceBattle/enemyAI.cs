using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {

    public float targetDistance = 10.0f;
    public float enemySpeed = 10.0f;

	void Start () {
        
    }

	void LateUpdate ()
    {
        GameObject plane = GameObject.FindGameObjectWithTag("GameplayPlane");
        if(transform.position.z - plane.transform.position.z <= targetDistance)
        {
            Vector3 newPosition = transform.position;
            newPosition.z = plane.transform.position.z + targetDistance;
            transform.position = newPosition;
        }
        else
        {
            transform.position = (transform.forward * -1) * enemySpeed * Time.deltaTime;
        }
	}
}
