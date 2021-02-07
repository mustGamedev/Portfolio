using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	
	public Text highScore; //highscore text
	
	public int moneyM; //our money
	public Text myMoney; //money displayed text
	
	
	public string leveltoload;
	public Transform mainMenu, optionsManager;
	
	public void OptionsManager(bool clicked){
		if (clicked == true){
			optionsManager.gameObject.SetActive(clicked);
			//mainMenu.gameObject.SetActive(false);
		} else {
			optionsManager.gameObject.SetActive(clicked);
			//mainMenu.gameObject.SetActive(true);
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
	
	
	public void AddMoney()
	{
		
		moneyM+=500;
		PlayerPrefs.SetInt("MMoney", moneyM);
		myMoney.text = PlayerPrefs.GetInt("MMoney").ToString();
	}
	
	
	void Start () 
    {
		
		Application.targetFrameRate = 60;
		
		
		//on start event
		if (PlayerPrefs.HasKey("MMoney") == true) {
            myMoney.text = PlayerPrefs.GetInt("MMoney").ToString();
        }
        else {
			PlayerPrefs.SetInt("MMoney", moneyM);
            //myMoney.text = "No money";
        }
		
		
		
		
        if (PlayerPrefs.HasKey("MScore") == true) {
            highScore.text = PlayerPrefs.GetInt("MScore").ToString();
        }
        else {
            highScore.text = "0";
        }
    }
	
	
	
	
	
	
	
	
	
	
	//Down Panel ==============================
	
	public void DownButton1(){ //power ups
		Debug.Log("111");
	}
	
	public void DownButton2(){ //social network
		Debug.Log("222");
	}
	
	public void DownButton3(){ //Shop
		Debug.Log("333");
	}
	
	public void DownButton4(){ //scoreboard
		Debug.Log("444");
	}
	
	public void DownButton5(){ //cheat give 5000 coins
		Debug.Log("555");
	}
	
	//Down Panel END ==============================
	
}