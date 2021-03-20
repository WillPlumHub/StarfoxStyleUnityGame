using UnityEngine;
using System.Collections;

public class scaleovertime : MonoBehaviour {

    public Vector3 goalScale = Vector3.one;
    public float time = 60.0f;
    private Vector3 initialScale;

	void Start () {
        initialScale = transform.localScale;
        StartCoroutine(ScaleCoroutine());
    }
	
	IEnumerator ScaleCoroutine()
    {
        float t = 0.0f;
        while(t < time)
        {
            transform.localScale = Vector3.Lerp(initialScale, goalScale, t / time);
            t += Time.deltaTime;
            yield return null;
        }
        transform.localScale = goalScale;
	}
}
