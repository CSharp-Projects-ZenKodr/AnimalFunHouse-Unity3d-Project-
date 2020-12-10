using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDispaly : MonoBehaviour {

	public GameObject OpenQuiz;

	float wait40secs = 40.0F;
	float mycounter  = 0.0F;
	

	// Use this for initialization
	void Start () {

		

		if(mycounter<= wait40secs){
			OpenQuiz.SetActive(false);
		}else{
			OpenQuiz.SetActive(true);
		}
	mycounter += Time.deltaTime;
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
