using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

    public Rigidbody bullet;
    public float velocity = 10.0f;

    void Update () {
       if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody newBullet = Instantiate(bullet,transform.position,transform.rotation) as Rigidbody;
            newBullet.AddForce(transform.forward*velocity,ForceMode.VelocityChange);
        }
    }
}