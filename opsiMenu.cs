using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opsiMenu : MonoBehaviour {

	public GameObject OpsiKeluar;
	void Start () {
		
	}
	

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			//OpsiKeluar.gameObject.SetActive (true);
			OpsiKeluar.gameObject.SetActive (!OpsiKeluar.gameObject.activeSelf);
		
	}
}
