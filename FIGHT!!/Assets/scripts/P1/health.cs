using UnityEngine;
using System.Collections;

public class health : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth = 100;

    public float healthBarlength;

    // Use this for initialization
    void Start()
    {
        healthBarlength = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        AddjustCurentHealth(0);
        if (curHealth == 0)
        {
            transform.position = new Vector3(12.191f, 1.98f, 1.98f);
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(90, 10, healthBarlength, 20), curHealth + "/" + maxHealth);
    }

    public void AddjustCurentHealth(int adj)
    {
        curHealth += adj;

        if (curHealth < 0)
            curHealth = 0;

        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (maxHealth < 1)
            maxHealth = 1;

        healthBarlength = (Screen.width / 7) * (curHealth / (float)maxHealth);
    }
}
