using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kembali : MonoBehaviour {
	public string x;
	void Start () {
		
	}

	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			SceneManager.LoadScene (x);
		}
	}
}
 