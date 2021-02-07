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
        crossbowClone = Instantiate(crossbowPrefab, transform);
		
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
		{
			GetComponent<ScoreCount>().AddScore(); 
			GetComponent<ScoreCount>().SetScore();
			GetComponent<UICounter>().DecrementArrow();
			Debug.Log("Mouse clicked");
			crossbowClone.transform.parent = null; //null Clone out of spawner before throw
			crossbowClone.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bowForce, ForceMode2D.Impulse);
			crossbowClone = Instantiate(crossbowPrefab, transform); //create new CLone after throw
		}
    }
}