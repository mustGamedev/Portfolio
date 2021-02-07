using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
	
	public string levelNext;
	public string level25Chance;
	
	[Header("Chance settings here")]
	public float chancePercent = 0.25f;
	
	
	public void LoadNextLevel()
	{
		if(Random.value <= chancePercent)
		{
			Debug.LogError("Spawn chance is 25");
			SceneManager.LoadScene(level25Chance);
			
		} else
		{
			Debug.LogError("Chance BIGGER than 25");
			SceneManager.LoadScene(levelNext);
		}
	}
	
	
}