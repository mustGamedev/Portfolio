using UnityEngine;
using System.Collections;


public class MExplode : MonoBehaviour {

	public Explodable _explodable;

	public void DoExplode()
	{
		_explodable.explode();
		ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
		ef.doExplosion(transform.position);
	}
}