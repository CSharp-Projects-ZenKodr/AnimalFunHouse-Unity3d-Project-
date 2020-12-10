using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPlanetInfo : MonoBehaviour {
	
	// public GameObject PopupMessageCanvas;
	public GameObject CanvasInfoMars;
	public GameObject CanvasInfoVenus;
	public GameObject CanvasInfoMercury;
	public GameObject CanvasInfoEarth;
	public GameObject CanvasInfoJupiter;
	public GameObject CanvasInfoSaturn;
	public GameObject CanvasInfoUranus;
	public GameObject CanvasInfoNeptune;

	public bool showCanvas = false;

	// Use this for initialization
	void Start () {
		// PopupMessageCanvas.SetActive(false);
		CanvasInfoMars.SetActive(false);
		CanvasInfoVenus.SetActive(false);
		CanvasInfoMercury.SetActive(false);
		CanvasInfoEarth.SetActive(false);
		CanvasInfoJupiter.SetActive(false);
		CanvasInfoSaturn.SetActive(false);
		CanvasInfoUranus.SetActive(false);
		CanvasInfoNeptune.SetActive(false);	

	}

public void MarsInfo (){

		CanvasInfoMars.SetActive(true);
		showCanvas= true;
		CanvasInfoVenus.SetActive(false);
		CanvasInfoMercury.SetActive(false);
		CanvasInfoEarth.SetActive(false);
		CanvasInfoJupiter.SetActive(false);
		CanvasInfoSaturn.SetActive(false);
		CanvasInfoUranus.SetActive(false);
		CanvasInfoNeptune.SetActive(false);	


		if (showCanvas = !showCanvas){
			CanvasInfoMars.SetActive(false);
		}   
		
}

public void VenusInfo (){

		CanvasInfoVenus.SetActive(true);
		showCanvas= true;
		CanvasInfoMars.SetActive(false);
		CanvasInfoMercury.SetActive(false);
		CanvasInfoEarth.SetActive(false);
		CanvasInfoJupiter.SetActive(false);
		CanvasInfoSaturn.SetActive(false);
		CanvasInfoUranus.SetActive(false);
		CanvasInfoNeptune.SetActive(false);

		if (showCanvas = !showCanvas){
			CanvasInfoVenus.SetActive(false);
		}   
		
}

public void MercuryInfo (){

		CanvasInfoMercury.SetActive(true);
		showCanvas = true;
		
		CanvasInfoMars.SetActive(false);
		CanvasInfoVenus.SetActive(false);
		CanvasInfoEarth.SetActive(false);
		CanvasInfoJupiter.SetActive(false);
		CanvasInfoSaturn.SetActive(false);
		CanvasInfoUranus.SetActive(false);
		CanvasInfoNeptune.SetActive(false);

		if (showCanvas = !showCanvas){
			CanvasInfoMercury.SetActive(false);
		}   
		
}
public void EarthInfo (){

		CanvasInfoEarth.SetActive(true);
		showCanvas = true;

		CanvasInfoMars.SetActive(false);
		CanvasInfoVenus.SetActive(false);
		CanvasInfoMercury.SetActive(false);
		CanvasInfoJupiter.SetActive(false);
		CanvasInfoSaturn.SetActive(false);
		CanvasInfoUranus.SetActive(false);
		CanvasInfoNeptune.SetActive(false);

		if (showCanvas = !showCanvas){
			CanvasInfoEarth.SetActive(false);
		}   
		
}

public void jupiterInfo (){

		CanvasInfoJupiter.SetActive(true);
		showCanvas = true;

		CanvasInfoMars.SetActive(false);
		CanvasInfoVenus.SetActive(false);
		CanvasInfoMercury.SetActive(false);
		CanvasInfoEarth.SetActive(false);
		CanvasInfoSaturn.SetActive(false);
		CanvasInfoUranus.SetActive(false);
		CanvasInfoNeptune.SetActive(false);

		if (showCanvas = !showCanvas){
			CanvasInfoJupiter.SetActive(false);
		}   
		
}

public void SaturnInfo (){

		CanvasInfoSaturn.SetActive(true);
		showCanvas = true;

		CanvasInfoMars.SetActive(false);
		CanvasInfoVenus.SetActive(false);
		CanvasInfoMercury.SetActive(false);
		CanvasInfoEarth.SetActive(false);
		CanvasInfoJupiter.SetActive(false);
		CanvasInfoUranus.SetActive(false);
		CanvasInfoNeptune.SetActive(false);
	

		if (showCanvas = !showCanvas){
			CanvasInfoSaturn.SetActive(false);
		}   
		
}

public void UranusInfo (){

		CanvasInfoUranus.SetActive(true);
		showCanvas = true;

		CanvasInfoMars.SetActive(false);
		CanvasInfoVenus.SetActive(false);
		CanvasInfoMercury.SetActive(false);
		CanvasInfoEarth.SetActive(false);
		CanvasInfoJupiter.SetActive(false);
		CanvasInfoSaturn.SetActive(false);
		CanvasInfoNeptune.SetActive(false);
		

		if (showCanvas = !showCanvas){
			CanvasInfoUranus.SetActive(false);
		}   
		
}

public void NeptuneInfo (){

		CanvasInfoNeptune.SetActive(true);
		showCanvas = true;

		CanvasInfoMars.SetActive(false);
		CanvasInfoVenus.SetActive(false);
		CanvasInfoMercury.SetActive(false);
		CanvasInfoEarth.SetActive(false);
		CanvasInfoJupiter.SetActive(false);
		CanvasInfoSaturn.SetActive(false);
		CanvasInfoUranus.SetActive(false);
		

		if (showCanvas = !showCanvas){
			CanvasInfoNeptune.SetActive(false);
		}   
		
}


    void Update () {}
}
