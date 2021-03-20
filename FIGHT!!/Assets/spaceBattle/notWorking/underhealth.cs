using UnityEngine;
using System.Collections;

public class underhealth : MonoBehaviour
{
    public int curHealth = 100;

    void Update()
    {
        if (curHealth <= 0) // If stats class' health var <= 0, destroy enemy object
            Destroy(this.gameObject);
    }
}

public class Stats
// New class to store variables about your enemy
{
    public int health; // Health variable
}