using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrigger1 : MonoBehaviour{

    // Variables declared private are not visible from unity and other scripts
    // Variables declared public are visible for use from unity and other scripts
    // Variables with SerializedField in bracket before  private are visibly are visible for use in unity but not visible from other scripts

[SerializeField] private GameObject  blockageWall;


    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other){

        if(other.CompareTag("Player")){

           blockageWall.SetActive(false);
        //    gameObject.SetActive(false);

        }
    }
    
    

}
