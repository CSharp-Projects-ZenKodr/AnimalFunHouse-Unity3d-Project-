using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideQuizButtonAWhile : MonoBehaviour {

	public GameObject CanvasBeginQuestions;

	// public float delay = 30;
	public float startTime;
	
	// Use this for initialization
	void Start () {	
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		float show = Time.time - startTime;

		if (show > 25){
			CanvasBeginQuestions.SetActive(true);
			
		}else{

			CanvasBeginQuestions.SetActive(false);	
	   }
	
	}		
}
