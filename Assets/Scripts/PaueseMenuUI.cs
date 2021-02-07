using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaueseMenuUI : MonoBehaviour
{
	
	public static bool isFinish; // do not touch this
	
	
	
	public GameObject woodObject;
	public GameObject arrowObject;
	
	
    public Transform optionsManager;

	
	void Update()
	{
		
		if(isFinish == true)
		{
			ShowResult();
		}
		
	}
	
	public void ShowResult()
	{
		isFinish = true;
		optionsManager.gameObject.SetActive(true);
		woodObject.SetActive(false);
		arrowObject.SetActive(false);
		Debug.Log("RESULT");
	}
	
	public void RestartButton()
	{
		SceneManager.LoadScene("SampleScene"); //load first scene
		isFinish = false;
		ScoreCount.scoreAmount = 0;
		
		
	}
	
	
	public void HomeButton(string leveltoload)
	{
		SceneManager.LoadScene(leveltoload);
		isFinish = false;
	}
	
	
}