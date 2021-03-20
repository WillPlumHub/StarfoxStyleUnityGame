using UnityEngine;
using System.Collections;

public class addScore : MonoBehaviour {

    public int pointValue = 100;

    void OnTriggerEnter()
    {
            scoremanager.Instance.score += pointValue;
    }
}