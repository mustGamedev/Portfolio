using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCount : MonoBehaviour
{
    
	public Text score, finalScore;
	
	public static int scoreAmount;
	
	public Text myMoneys;
	
	
    void Start()
    {
        
		if (SceneManager.GetActiveScene().name == "SampleScene")
		{
                 scoreAmount = 0;
				 myMoneys.text = PlayerPrefs.GetInt("MMoney").ToString();
		} else{
				 myMoneys.text = PlayerPrefs.GetInt("MMoney").ToString();
			   }
		
    }
	
	public void SetScore () 
    {
        PlayerPrefs.SetInt("MScore", scoreAmount);
		Debug.Log("SCORE SET!!!");
    }
	
	
    void Update()
    {
        score.text = scoreAmount.ToString();
		finalScore.text = scoreAmount.ToString();
		myMoneys.text = PlayerPrefs.GetInt("MMoney").ToString();
    }
	
	public void AddScore()
	{
		scoreAmount +=1;
	}
	
}