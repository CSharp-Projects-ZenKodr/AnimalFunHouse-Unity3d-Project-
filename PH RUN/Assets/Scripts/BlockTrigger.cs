using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrigger : MonoBehaviour{

    // Variables declared private are not visible from unity and other scripts
    // Variables declared public are visible for use from unity and other scripts
    // Variables with SerializedField in bracket before  private are visibly are visible for use in unity but not visible from other scripts

[SerializeField] private  HealthController  myHealthController;
[SerializeField] private  PlayerController  myPlayerController;

[SerializeField] private int damage;
[SerializeField] private int heal;
[SerializeField] private bool damageBool;
[SerializeField] private bool healBool;

[SerializeField] private bool speedBoost;
[SerializeField] private bool jumpBoost;

[SerializeField] private int boostedSpeed;
[SerializeField] private int boostedJump;

[SerializeField] private int delay;

    // Start is called before the first frame update
    
    IEnumerator OnTriggerEnter(Collider other){

        if(other.CompareTag("Player") && damageBool){

            myHealthController.playerHealth = myHealthController.playerHealth - damage;
            myHealthController.UpdateHealth();

        }
        
         else if (other.CompareTag("Player") && healBool){

            myHealthController.playerHealth = myHealthController.playerHealth + heal;
            myHealthController.UpdateHealth();
        }
        else if (other.CompareTag("Player")&& speedBoost){

            myPlayerController.speed = boostedSpeed;
            yield return new WaitForSeconds(delay);
            myPlayerController.speed = myPlayerController.normSpeed;
            this.gameObject.SetActive(false);
        }

        else if (other.CompareTag("Player")&&  jumpBoost){

            myPlayerController.jumpForce = boostedJump;
            yield return new WaitForSeconds(delay);
            myPlayerController.jumpForce = myPlayerController.normJumpForce;
            this.gameObject.SetActive(false);
        }
    }
    
    
    
    
    
    // void Start(){

    //     Debug.Log("Hello world");
    //     HelloWorldMethod();
    // }

    // // Update is called once per frame
    // void Update(){
        
    //      Debug.Log("I AM HERE"); 
    // }

    // private void HelloWorldMethod(){

    //     Debug.Log("MY CUSTOM METHOD");
    // }
}
