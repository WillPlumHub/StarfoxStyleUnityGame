using UnityEngine;
using System.Collections;

public class swimmer : MonoBehaviour {

    // Use this for initialization
    void Start () {
        RenderSettings.fog = false;
        RenderSettings.fogColor = new Color(0.09f, 0.09f, 0.09f, 0.09f);
        RenderSettings.fogDensity = 0.004f;

    }

    bool IsUnderWater()
    {
        return gameObject.transform.position.y < 732;
    }
	
	// Update is called once per frame
	void Update () {
        RenderSettings.fog = IsUnderWater();
    }
}
