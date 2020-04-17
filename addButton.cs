using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addButton : MonoBehaviour {

	[SerializeField]
	private Transform KPuzzel;
	[SerializeField]
	private GameObject tmbl;


	void Awake() {
		for (int i = 0; i < 6; i++) {
			GameObject tombol = Instantiate (tmbl);
			tombol.name = "" + i;
			tombol.transform.SetParent (KPuzzel, false);
		}
	}

}
