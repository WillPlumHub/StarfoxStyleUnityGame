using UnityEngine;
using System.Collections;

public class castleArea : MonoBehaviour {

    public Transform target;
    public Transform target2;
    public float speed;
    public float speed2;
    public float timer;

    void Update()
    {
        timer -= Time.deltaTime;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (timer <= 0)
        {
            float step2 = speed2 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step2);
        }
    }
}