using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tick : MonoBehaviour {

	public GameObject bins;
	public GameObject teddy;
	public GameObject tan;
	public GameObject car;
	public GameObject attTur;
	public GameObject slidor;
	public Sprite[] atteluMasivs;

	public void pretBin(bool ver){
		bins.SetActive (ver);
	}
	public void pretTed(bool ver){
		teddy.SetActive (ver);
	}
	public void prettan(bool ver){
		tan.SetActive (ver);
	}
	public void pretCar(bool ver){
		car.SetActive (ver);
	}
	public void beanLeft(bool ver){
		bins.transform.localScale = new Vector2 (-1, 1);
	}
	public void beanRight(bool ver){
		bins.transform.localScale = new Vector2 (1, 1);
	}
	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			attTur.GetComponent<Image> ().sprite = atteluMasivs [0];
		else if (skaitlis == 1)
			attTur.GetComponent<Image> ().sprite = atteluMasivs [1];
		else if (skaitlis == 2)
			attTur.GetComponent<Image> ().sprite = atteluMasivs [2];
	}
	public void sliide(int skaitlis){
		float pasreizejaVer = slidor.GetComponent<Slider> ().value;
		attTur.transform.localScale = new Vector2 (1F * pasreizejaVer, 1F * pasreizejaVer);
	}



}
