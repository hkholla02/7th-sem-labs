using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Button -> onClick -> GameObject -> Scenemanager
//GameObject -> Target scene name

public class six : MonoBehaviour
{    
	public string SceneName; 
       
	public void ChangeToScene()    
	{        
		SceneManager.LoadScene(SceneName);    
	}
}
