using UnityEngine;
using System.Collections;

public class takeDamage : MonoBehaviour {

    public float damageAmount = 1.0f;
    public float coolDownTime = 1.0f;

    private bool inCoolDown = false;

    void OnCollisionEnter()
    {
        if (!inCoolDown)
        {
         //   healthManage.Instance.DamagePlayer(damageAmount);
            inCoolDown = true;
            Invoke("Uncool", coolDownTime);
        }
    }
    void Uncool() {
        inCoolDown = false;
    }
}