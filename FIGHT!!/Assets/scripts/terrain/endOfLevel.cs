using UnityEngine;
using System.Collections;

public class endOfLevel : MonoBehaviour {

    public string level;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel(level);
        }
    }
}
