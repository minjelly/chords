using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayC : MonoBehaviour {

	public void StartPlay() {

        AudioSource audio = GetComponent<AudioSource>();

        float note = 0;
        float halfstep = 12;
        if (Input.GetKeyDown("a"))
        {
            audio.pitch = Mathf.Pow(2, note / halfstep);
            audio.Play();
        }
        
    }
}
