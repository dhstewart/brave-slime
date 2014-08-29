using UnityEngine;
using System.Collections;

public class slimeFootController : MonoBehaviour {


	float dam = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		
		if(col.gameObject.tag == "enemy")
		{
			col.gameObject.GetComponent<redSlimeHealth>().TakeDamage(dam);;
		}
	}
			
}
