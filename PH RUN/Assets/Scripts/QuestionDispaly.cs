using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionDispaly : MonoBehaviour {

	public GameObject CanvasQuestionOne;
	public GameObject CanvasQuestionTwo;
	public GameObject CanvasQuestionThree;
	public GameObject CanvasQuestionFour;
	public GameObject CanvasQuestionFive;
			

	public bool showCanvas = false;

	// Use this for initialization
	void Start () {
		CanvasQuestionOne.SetActive(true);
	
		CanvasQuestionTwo.SetActive(false);
		CanvasQuestionThree.SetActive(false);
		CanvasQuestionFour.SetActive(false);
		CanvasQuestionFive.SetActive(false);
		
	}

	public void Question2 (){

		CanvasQuestionOne.SetActive(false);
		// showCanvas= true;
		CanvasQuestionTwo.SetActive(true);
		CanvasQuestionThree.SetActive(false);
		CanvasQuestionFour.SetActive(false);
		CanvasQuestionFive.SetActive(false);
	

		// if (showCanvas = !showCanvas){
		// 	CanvasQuestionTwo.SetActive(false);
		// }   
}

public void Question3 (){

		CanvasQuestionTwo.SetActive(false);
		// showCanvas= true;
		CanvasQuestionThree.SetActive(true);
		CanvasQuestionOne.SetActive(false);
		CanvasQuestionFour.SetActive(false);
		CanvasQuestionFive.SetActive(false);
		
}

public void Question4 (){

		CanvasQuestionThree.SetActive(false);
		// showCanvas= true;
		CanvasQuestionFour.SetActive(true);
		CanvasQuestionOne.SetActive(false);
		CanvasQuestionTwo.SetActive(false);
		CanvasQuestionFive.SetActive(false);
		
}

public void Question5 (){

		CanvasQuestionFour.SetActive(false);
		// showCanvas= true;
		CanvasQuestionFive.SetActive(true);
		CanvasQuestionOne.SetActive(false);
		CanvasQuestionTwo.SetActive(false);
		CanvasQuestionThree.SetActive(false);
		
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
