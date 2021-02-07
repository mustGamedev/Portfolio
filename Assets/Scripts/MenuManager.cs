using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	
	public Text highScore; 
	
	public static int moneyM;
	public Text myMoney; 
	
	
	public string leveltoload;
	public Transform mainMenu, optionsManager;
	
	public void OptionsManager(bool clicked){
		if (clicked == true){
			optionsManager.gameObject.SetActive(clicked);
		} else {
			optionsManager.gameObject.SetActive(clicked);
		}
	}
	
   
	public void StartGame(){
		SceneManager.LoadScene(leveltoload);
	}
	
	
	public void QuitGame(){
		Application.Quit();
		Debug.Log("Quiting game");
	}
	
	//==================================================
	public void ClearHighscores () //delete from prefs
    {
        PlayerPrefs.DeleteKey("MScore");
        highScore.text = "Scores clear";
    }
	
	public void ClearMoney () //delete from prefs
    {
        PlayerPrefs.DeleteKey("MMoney");
        myMoney.text = "Money cleared";
    }
	
	//===================================================
	
	
	public static void AddMoney()
	{
		moneyM+=500;
		PlayerPrefs.SetInt("MMoney", moneyM);
	}
	
	
	void Start () 
    {
		
		Application.targetFrameRate = 60;
		
		
		if (PlayerPrefs.HasKey("MMoney") == true) {
            myMoney.text = PlayerPrefs.GetInt("MMoney").ToString();
        }
        else {
			PlayerPrefs.SetInt("MMoney", moneyM);
            
        }
		
		
		
        if (PlayerPrefs.HasKey("MScore") == true) {
            highScore.text = PlayerPrefs.GetInt("MScore").ToString();
        }
        else {
            highScore.text = "0";
        }
    }
	
}