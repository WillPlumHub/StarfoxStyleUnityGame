using UnityEngine;
using System.Collections;

public class instantKillLava : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject player;
    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "lava")
        {
            player.transform.position = spawnPoint.position;
            health eH = (health)target.GetComponent("health");
            eH.AddjustCurentHealth(-10);
        }
    }
}
