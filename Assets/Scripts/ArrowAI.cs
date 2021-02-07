using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAI : MonoBehaviour
{
    public Rigidbody2D arrowRb;
	public bool isFixed;
	
	public static bool lastHit; // static do not touch
	
	
	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Center")
		{
			GetComponent<ParticleSystem>().Play();
			Debug.Log("HIIITTTTTT");
			arrowRb.velocity = Vector2.zero; //stop Arrow force on wood
			transform.parent = other.transform;
			isFixed = true;
			
			StartCoroutine(LastChance());
			
			
			///ADD VIBRATION
			
			Vibration.Init();
			Vibration.Vibrate(100); 
			/// VIBRATION
		}
		
		if(other.gameObject.tag == "Arrow")
		{
			if(other.gameObject.GetComponent<ArrowAI>().isFixed == true)
			{
			arrowRb.velocity = Vector2.zero; //stop Arrow force on wood
			arrowRb.gravityScale = 2;
			Debug.LogError("YOU Lost");
			StartCoroutine(TestCoroutine());
			
			
			
			///ADD VIBRATION
			
			Vibration.Init();
			Vibration.Vibrate(100); 
			/// VIBRATION
			
			
			
			}
		}
		
		IEnumerator TestCoroutine()
		{
			yield return new WaitForSeconds(0.5f);
			PaueseMenuUI.isFinish = true;
		}

		IEnumerator LastChance()
		{
			lastHit = true;
			yield return new WaitForSeconds(0.5f);
			lastHit = false;
		}
		
		if(other.gameObject.tag == "Apple")
		{
			other.transform.parent = null; //unglue apple from wood 
			other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
			
			MenuManager.AddMoney();
		}
	}
	
	
}