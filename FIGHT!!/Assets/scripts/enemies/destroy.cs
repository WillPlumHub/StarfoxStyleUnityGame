using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
