using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrow : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
	{
		
		if(other.gameObject.tag == "Arrow")
		{
			Destroy(other.gameObject);
		}
		
	}
}