using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour{
    // Start is called before the first frame update
    

    [SerializeField] private Text healthText;
    [SerializeField] private PlayerController myPlayerControllerScript;
    [SerializeField] private GameObject restartUI;
    [SerializeField] private string myLevel;
    public int playerHealth;


    private void Start(){

        UpdateHealth();
    }

    public void UpdateHealth(){
        
        healthText.text = playerHealth.ToString("0");

        if(playerHealth <= 0){

            myPlayerControllerScript.enabled = false;
            // Show player dead display 
            restartUI.SetActive(true);
        }

    }

    public void RestartButton(){
        SceneManager.LoadScene(myLevel);
    }
}
