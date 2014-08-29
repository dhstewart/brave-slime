using UnityEngine;
using System.Collections;

public class SlimeHealth : MonoBehaviour {


	public Heart1 heart1;

	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
	

	void OnCollisionEnter2D (Collision2D col)
	{
		
		if(col.gameObject.tag == "enemy")
		{
			if(heart1 != null)
			{
				heart1.RemoveHeart();
			}
		}
	}
}
