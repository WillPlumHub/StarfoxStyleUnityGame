using UnityEngine;
using System.Collections;

public class ontrigger : MonoBehaviour {

    public float damageAmount = 1.0f;
    public float coolDownTime = 1.0f;
    public string collisionTag = "Player";

    private bool inCoolDown = false;

    void OnTriggerEnter(Collider col)
    {
        if (!inCoolDown)
        {
            if (col.tag == collisionTag)
            {
     //           healthManage.Instance.DamagePlayer(damageAmount);
                inCoolDown = true;
                Invoke("Uncool", coolDownTime);
            }
        }
    }
    void Uncool()
    {
        inCoolDown = false;
    }
}