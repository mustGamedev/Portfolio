using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throw : MonoBehaviour //set on  main spawner
{
	public float bowForce;
	
	[Header("Place selected arrows here")]
	[SerializeField]
	private GameObject crossbowClone; //prefabs spawn clone
	public GameObject crossbowPrefab;
	
	
	

    void Start()
    {
        crossbowClone = Instantiate(crossbowPrefab, transform); //transform.parent
		
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
		{
			GetComponent<ScoreCount>().AddScore(); // +1 to score
			GetComponent<ScoreCount>().SetScore(); // save score in prefs
			GetComponent<UICounter>().DecrementArrow();
			Debug.Log("Mouse clicked");
			crossbowClone.transform.parent = null; //null Clone out of spawner before throw
			crossbowClone.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bowForce, ForceMode2D.Impulse);
			crossbowClone = Instantiate(crossbowPrefab, transform); //create new CLone after throw
		}
    }
}