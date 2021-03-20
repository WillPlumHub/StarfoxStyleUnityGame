using UnityEngine;
using System.Collections;

public class followRedicule : MonoBehaviour
{
    public GameObject target;

    void FollowTargetWitouthRotation(Transform target, float distanceToStop, float speed)
    {
        var direction = Vector3.zero;
        if (Vector3.Distance(transform.position, target.position) > distanceToStop)
        {
            direction = target.position - transform.position;
            GetComponent<Rigidbody>().AddRelativeForce(direction.normalized * speed, ForceMode.Force);
        }
    }
}