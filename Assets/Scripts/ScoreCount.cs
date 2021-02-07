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
        //scoreAmount = 0;
		if (SceneManager.GetActiveScene().name == "SampleScene")
		{
                 scoreAmount = 0;
				 myMoneys.text = PlayerPrefs.GetInt("MMoney").ToString();
		} else{
                 //SceneManager.LoadScene("scene1");
				 myMoneys.text = PlayerPrefs.GetInt("MMoney").ToString();
			   }
		
    }
	
	public void SetScore () 
    {
        PlayerPrefs.SetInt("MScore", scoreAmount);
        //score.text = PlayerPrefs.GetInt("MScore").ToString();
		Debug.Log("SCORE SET!!!");
    }
	
	

    // Update is called once per frame
    void Update()
    {
		
		
		
		
        score.text = scoreAmount.ToString();
		finalScore.text = scoreAmount.ToString();
    }
	
	public void AddScore()
	{
		scoreAmount +=1;
	}
	
}
