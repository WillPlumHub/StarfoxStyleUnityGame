using UnityEngine;
using System.Collections;

public class scrollGround : MonoBehaviour {

    public Vector2 scrollspeed = Vector2.one;
    private Material mat;

	void Start () {
        mat = GetComponent<Renderer>().material;
	}
	
	void Update () {
        mat.mainTextureOffset += scrollspeed*Time.deltaTime;
	}
}
