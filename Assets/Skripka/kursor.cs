using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursor : MonoBehaviour {
	public AudioSource skanasAvots;
	public AudioClip skana;
	// Use this for initialization
	public void nobiditsUzAttela () {
		skanasAvots.PlayOneShot (skana);

}
	public void nobiditsPromNoAttela ()
	{
		skanasAvots.Stop();
	}
}