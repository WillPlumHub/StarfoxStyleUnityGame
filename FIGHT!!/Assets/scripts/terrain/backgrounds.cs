using UnityEngine;
using System.Collections;

public class backgrounds : MonoBehaviour {

    public Transform target;
    public float speed;
    public float timer;

    void Start()
    {
        speed = GetComponent<float>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (timer <= 0)
        {

        }
    }
}
