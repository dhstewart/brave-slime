using UnityEngine;
using System.Collections;

public class SlimeHealth : MonoBehaviour {

	float dam = 1f;
	public float hp = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TakeDamage (float dam)
	{
		hp -= dam;
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		
		if(col.gameObject.tag == "enemy")
		{
			TakeDamage (dam);
		}
	}
}
