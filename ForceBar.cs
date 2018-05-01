using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceBar : MonoBehaviour 
{
	Rigidbody2D rb2D;

	void Start () 
	{	rb2D = GetComponent<Rigidbody2D>(); }
	

	void Update () 
	{
		if (Input.GetKeyDown("space"))
		{
			rb2D.AddForce(new Vector3(0, 500, 0)); 
		}
	}
}
