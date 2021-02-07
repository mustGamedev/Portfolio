using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UICounter : MonoBehaviour
{
	public int numArrows; //main value count of the arrows
	public int currentArrows; // current values arrows under namArrows
	
	public Image[] arrows; //arrows array list
	public Sprite normalArrow;
	public Sprite blackArrow;
	
	//public GameObject gmSpawner;
	
	
	
	void Update()
	{
		for (int i =0; i < arrows.Length; i++)
		{
			if(i < numArrows)
			{
				arrows[i].enabled = true;
			} else
			{
				arrows[i].enabled = false;
			}
			
			if(i < currentArrows)
			{
				arrows[i].sprite = normalArrow;
			} else 
			{
				arrows[i].sprite = blackArrow;
			}
			
		}
		
		
		if(currentArrows == 0 && ArrowAI.lastHit == true)
		{
			
			///ADD VIBRATION
			
			Vibration.Init();
			Vibration.Vibrate(300); 
			/// VIBRATION
			
			Debug.Log("ARROWS 000");
			//NEXT CLONE LEVEL
			StartCoroutine(Test2Coroutine());
			
			GetComponent<Throw>().enabled = false;
			//gmSpawner.SetActive(false);
		}
		
	}
	
	IEnumerator Test2Coroutine()
		{
			//gmSpawner.SetActive(false);
			yield return new WaitForSeconds(0.5f);
			GetComponent<MExplode>().DoExplode();
			yield return new WaitForSeconds(0.7f);
			
			GetComponent<LevelGenerator>().LoadNextLevel();
			
		}

	
	public void DecrementArrow()
	{
		currentArrows--;
	}
	
}