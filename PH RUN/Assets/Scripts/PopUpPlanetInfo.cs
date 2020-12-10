using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpInfo : MonoBehaviour {

	public GameObject PopupMessage;

	// Use this for initialization
	void Start () {}

	public void DisplayPlanetInfo (){
		PopupMessage.SetActive(true);
		PopupMessage.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {}

}
