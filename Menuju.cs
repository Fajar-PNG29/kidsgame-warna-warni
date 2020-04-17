using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuju : MonoBehaviour {

	/*public void Kemana(int yangDituju){

		Application.LoadLevel (yangDituju);
	}*/

	public void tujuan(string x){
		SceneManager.LoadScene (x);
	}
}