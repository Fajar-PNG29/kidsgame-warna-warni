using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameContrler : MonoBehaviour {
	
	[SerializeField]
	private Sprite bgimage;
	public GameObject OpsiLagi;
	public Sprite[] puzzels;
	private List<Sprite> gamePuzzel = new List<Sprite>();
	private List<Button> btns = new List<Button> ();
	private bool coba1, coba2;
	private int TotCoba,Benar, gameCoba;
	private int kartu1, kartu2;
	private int coba1index, coba2index;
	private string cobakartu1, cobakartu2;
	public AudioSource source;
	public AudioClip betul;
	void Awake(){
	}

	void Start(){
		GetTombol ();
		addLicener ();
		addPuzzel ();
		acak (gamePuzzel);
		gameCoba = 3;
	}
	void GetTombol(){
		GameObject[] objek = GameObject.FindGameObjectsWithTag ("kartu");

		for (int i = 0; i < objek.Length; i++) {
			btns.Add (objek[i].GetComponent<Button>());
			btns [i].image.sprite = bgimage;
		}
	}
	void addPuzzel(){
		int looper = btns.Count;
		int index = 0;

		for (int i = 0; i < looper; i++) {
			if(index==looper / 2){
				index = 0;
			}
			gamePuzzel.Add(puzzels[index]);

			index++;
		}
	}
	void addLicener(){
		foreach (Button tmbl in btns) {
			tmbl.onClick.AddListener (() => pickupCard());
		}
	}

	public void pickupCard(){
		if (!coba1) {
			coba1 = true;
			coba1index = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			cobakartu1 = gamePuzzel [coba1index].name;
			btns[coba1index].image.sprite = gamePuzzel[coba1index];
		} else if (!coba2) {
			coba2 = true;
			coba2index = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			cobakartu2 = gamePuzzel [coba2index].name;
			TotCoba++;
			btns[coba2index].image.sprite = gamePuzzel[coba2index];

			if (cobakartu1 == cobakartu2)
				StartCoroutine (cekKartu ());
			if(cobakartu1 != cobakartu2)
				StartCoroutine (Gsama ());
		}
	}
	IEnumerator cekKartu(){
		yield return new WaitForSeconds (.3f);

		if (cobakartu1 == cobakartu2 && coba1index != coba2index) {
			yield return new WaitForSeconds (.5f);
			btns [coba1index].interactable = false;
			btns [coba2index].interactable = false;

			btns [coba1index].image.color = new Color (0, 0, 0, 0);
			btns [coba2index].image.color = new Color (0, 0, 0, 0);

			source.clip = betul;
			source.Play();

			cocok ();
		} else{
			yield return new WaitForSeconds (.3f);

			btns [coba1index].image.sprite = bgimage;
			btns [coba2index].image.sprite = bgimage;
		}
		yield return new WaitForSeconds (.5f);
		coba1 = coba2 = false;
	}

	IEnumerator Gsama(){
		yield return new WaitForSeconds (.3f);
		if (cobakartu1 != cobakartu2) {
			yield return new WaitForSeconds (.3f);
			btns [coba1index].image.sprite = bgimage;
			btns [coba2index].image.sprite = bgimage;
		}
		yield return new WaitForSeconds (.5f);
		coba1 = coba2 = false;
	}

	void cocok(){
		Benar++;

		if (Benar == gameCoba)
			OpsiLagi.gameObject.SetActive (!OpsiLagi.gameObject.activeSelf);
	}
	void acak(List<Sprite> list){
		for (int i = 0; i < list.Count; i++) {
			Sprite tem = list [i];
			int random = Random.Range (0, list.Count);
			list [i] = list [random];
			list [random] = tem;
		}
	}
}
