using UnityEngine;
using System.Collections;

public class bossControll : MonoBehaviour {

    public Rigidbody bullet;
    public float velocity = 10.0f;
    public float timer = 5.0f;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer == 0)
        {
            Rigidbody newBullet = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            newBullet.AddForce(transform.forward * velocity, ForceMode.VelocityChange);
            timer -= 5.0f;
        }
    }
}