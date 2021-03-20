using UnityEngine;
using System.Collections;

public class moveShip : MonoBehaviour
{
    public float movementSpeed = 1.0f;
    public int invert = -1;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal,invert*vertical, 0);
        Vector3 finalDirection = new Vector3(horizontal,invert*vertical,10.0f);

        transform.position += direction*movementSpeed*Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(finalDirection),Mathf.Deg2Rad*100.0f);
    }

    void LevelChanged(int newLevel)
    {
        Debug.Log("Done" + newLevel);
    }
}