using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string newSceneLevel;
   public void NewSceneBtn( string newSCeneLevel){

          SceneManager.LoadScene(newSCeneLevel);
		}

		
        public void ExitExprience(){
			Application.Quit();
		}
}
