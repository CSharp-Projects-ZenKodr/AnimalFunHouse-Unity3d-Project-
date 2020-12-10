using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelaySceneTransition : MonoBehaviour {

	public float delay = 10;
	public string NewLevel = "CongratulatoryScene";
	// public GameObject CongratulatoryScene;

	// Use this for initialization
	void Start () {
	}

	public void LoadDelayedScene () 
	{

		StartCoroutine(LoadLevelAfterDelay(delay));	
	}


	IEnumerator LoadLevelAfterDelay (float delay)
	{
		yield return new WaitForSeconds(delay);
		SceneManager.LoadScene(NewLevel);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
