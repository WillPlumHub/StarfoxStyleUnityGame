using UnityEngine;
using System.Collections;

public class GibOnTrigger : MonoBehaviour {

    public string[] tags;
    public GameObject Gib;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {
        foreach(string tag in tags) {
            if (col.tag == tag)
            {
                Instantiate(Gib, transform.position, Random.rotation);
                Destroy(gameObject);
            }
        }
    }
}
