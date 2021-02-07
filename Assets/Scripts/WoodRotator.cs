using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodRotator : MonoBehaviour
{
    public float circleSpeed;
	
    void FixedUpdate()
    {
        transform.Rotate(0, 0, circleSpeed);
    }
}
