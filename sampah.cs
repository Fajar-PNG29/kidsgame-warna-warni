using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampah : MonoBehaviour {

	public GameObject sm1, sm2, sk1, sk2, sk3, sh1, sh2, sh3, merah, kuning, hijau, Opsilagi;
	Vector3 posm1, posm2, posk1, posk2, posk3, posh1, posh2, posh3;
	private int benar, semua;
	public AudioSource source;
	public AudioClip drop;
	public AudioClip salah;

	void Start () {
		posm1 = sm1.transform.position;	
		posm2 = sm2.transform.position;	
		posk1 = sk1.transform.position;	
		posk2 = sk2.transform.position;	
		posk3 = sk3.transform.position;	
		posh1 = sh1.transform.position;	
		posh2 = sh2.transform.position;	
		posh3 = sh3.transform.position;

		semua = 8;

	}

	void Update () {
	}

	public void DragSm1(){
		sm1.transform.position = Input.mousePosition;
	}
	public void DragSm2(){
		sm2.transform.position = Input.mousePosition;
	}
	public void DragSk1(){
		sk1.transform.position = Input.mousePosition;
	}
	public void DragSk2(){
		sk2.transform.position = Input.mousePosition;
	}
	public void DragSk3(){
		sk3.transform.position = Input.mousePosition;
	}
	public void DragSh1(){
		sh1.transform.position = Input.mousePosition;
	}
	public void DragSh2(){
		sh2.transform.position = Input.mousePosition;
	}
	public void DragSh3(){
		sh3.transform.position = Input.mousePosition;
	}
		
	public void DropSm1(){
		float Distance = Vector3.Distance(sm1.transform.position, merah.transform.position);

		if (Distance < 70) {
			//sm1.transform.localScale = merah.transform.localScale;
			//sm1.transform.position = merah.transform.position;

			sm1.gameObject.SetActive (false);

			cocok ();

			source.clip = drop;
			source.Play();
		} else {
			sm1.transform.position = posm1;

			source.clip = salah;
			source.Play();
		}
	}
	public void DropSm2(){
		float Distance = Vector3.Distance(sm2.transform.position, merah.transform.position);

		if (Distance < 70) {
			//sm2.transform.localScale = merah.transform.localScale;
			//sm2.transform.position = merah.transform.position;

			sm2.gameObject.SetActive (false);//menghilangkan objek

			cocok ();

			source.clip = drop;
			source.Play();
		} else {
			sm2.transform.position = posm2;

			source.clip = salah;
			source.Play();
		}
	}
	public void DropSk1(){
		float Distance = Vector3.Distance(sk1.transform.position, kuning.transform.position);

		if (Distance < 70) {
			//sk1.transform.localScale = kuning.transform.localScale;
			//sk1.transform.position = kuning.transform.position;

			sk1.gameObject.SetActive (false);
			//kuning.gameObject.SetActive (false);
			//kun.gameObject.SetActive (true);

			cocok ();

			source.clip = drop;
			source.Play();
		} else {
			sk1.transform.position = posk1;

			source.clip = salah;
			source.Play();
		}
	}
	public void DropSk2(){
		float Distance = Vector3.Distance(sk2.transform.position, kuning.transform.position);

		if (Distance < 70) {
			//sk2.transform.localScale = kuning.transform.localScale;
			//sk2.transform.position = kuning.transform.position;

			sk2.gameObject.SetActive (false);

			cocok ();

			source.clip = drop;
			source.Play();
		} else {
			sk2.transform.position = posk2;

			source.clip = salah;
			source.Play();
		}
	}
	public void DropSk3(){
		float Distance = Vector3.Distance(sk3.transform.position, kuning.transform.position);

		if (Distance < 70) {
			//sk3.transform.localScale = kuning.transform.localScale;
			//sk3.transform.position = kuning.transform.position;

			sk3.gameObject.SetActive (false);

			cocok ();

			source.clip = drop;
			source.Play();
		} else {
			sk3.transform.position = posk3;

			source.clip = salah;
			source.Play();
		}
	}
	public void DropSh1(){
		float Distance = Vector3.Distance(sh1.transform.position, hijau.transform.position);

		if (Distance < 70) {
			//sh1.transform.localScale = hijau.transform.localScale;
			//sh1.transform.position = hijau.transform.position;

			sh1.gameObject.SetActive (false);

			cocok ();

			source.clip = drop;
			source.Play();
		} else {
			sh1.transform.position = posh1;

			source.clip = salah;
			source.Play();
		}
	}
	public void DropSh2(){
		float Distance = Vector3.Distance(sh2.transform.position, hijau.transform.position);

		if (Distance < 70) {
			//sh2.transform.localScale = hijau.transform.localScale;
			//sh2.transform.position = hijau.transform.position;

			sh2.gameObject.SetActive (false);

			cocok ();

			source.clip = drop;
			source.Play();
		} else {
			sh2.transform.position = posh2;

			source.clip = salah;
			source.Play();
		}
	}
	public void DropSh3(){
		float Distance = Vector3.Distance(sh3.transform.position, hijau.transform.position);

		if (Distance < 70) {
			//sh3.transform.localScale = hijau.transform.localScale;
			//sh3.transform.position = hijau.transform.position;

			sh3.gameObject.SetActive (false);

			cocok ();

			source.clip = drop;
			source.Play();
		} else {
			sh3.transform.position = posh3;

			source.clip = salah;
			source.Play();
		}
	}
	void cocok(){
		benar++;

		if(benar == semua){
			Opsilagi.gameObject.SetActive(true);
		}
	}
}
