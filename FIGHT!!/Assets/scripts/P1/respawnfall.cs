using UnityEngine;
using System.Collections;

public class respawnfall : MonoBehaviour
{
    public Transform spawnPoint;
    public float minHeightForDeath;
    public GameObject player;

    void Update()
    {
        if (player.transform.position.y < minHeightForDeath)
            player.transform.position = spawnPoint.position;
            
    }
}