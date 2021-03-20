using UnityEngine;
using System.Collections;

public class instantDamage : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject player;
    public GameObject target;

    void OnTriggerEnter (Collider other) {
	if (other.tag == "enemy") {
            player.transform.position = spawnPoint.position;
            health eH = (health)target.GetComponent("health");
            eH.AddjustCurentHealth(-10);
        }
	}
}
