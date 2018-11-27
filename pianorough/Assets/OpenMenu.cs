using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}

	public void LoadMenu() {
		SceneManager.LoadScene("United");
	}

	public void LoadPiano() {
		SceneManager.LoadScene("SampleScene");
	}
}
