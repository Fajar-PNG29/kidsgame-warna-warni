using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balon : MonoBehaviour {

	public GameObject suara;
	private float time;
	public float jeda;

	void Start (){
		time = jeda;
	}

	void Update () {
		if (time > 0) {
			time -= Time.deltaTime;
		}
		else{
			suara.gameObject.SetActive (true);
		}
	}

}
