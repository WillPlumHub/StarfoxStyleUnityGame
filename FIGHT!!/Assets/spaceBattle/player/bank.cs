using UnityEngine;
using System.Collections;

public class bank : MonoBehaviour {

	void Update () {
        Vector3 newRotationEuler = transform.rotation.eulerAngles;
        newRotationEuler.z = -90 * Input.GetAxis("Bank");
        Quaternion newQuat = Quaternion.identity;
        newQuat.eulerAngles = newRotationEuler;
        transform.rotation = newQuat;
	}
}