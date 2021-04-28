using UnityEngine;
using System.Collections;

public class code : MonoBehaviour 
{
	public float  growscale = 1.2f;
	public float  max = 14;
	// Use this for initialization
	void   Start() 
	{
		if (growscale < 1)
		{
			print("The ball is too small");

		}

	}
	
	void OnMouseDown()
	{
		transform.localScale *= growscale;
		if(transform.localScale.x >= max) 
		{
			Destroy(gameObject) ;
		}
	

	}
}
