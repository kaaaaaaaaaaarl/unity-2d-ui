using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonskripka : MonoBehaviour {
	public string teksts;

	// Use this for initialization
	public GameObject tekstlauk;
	public GameObject tekstlauklauk;
	public void darbatext(){
		teksts = tekstlauk.GetComponent<Text> ().text;
		tekstlauklauk.GetComponent<Text> ().text = "sveiks" + teksts.ToUpper () + "!";
	}
}

