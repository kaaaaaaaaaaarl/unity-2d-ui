using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tick : MonoBehaviour {

	public GameObject bins;
	public GameObject teddy;
	public GameObject tan;
	public GameObject car;
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

}
