using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class movieControll : MonoBehaviour {

	void Start () {
        MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
        movie.Play();
	}
	
	void Update () {
	
	}
}
