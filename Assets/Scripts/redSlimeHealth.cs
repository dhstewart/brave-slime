using UnityEngine;
using System.Collections;

public class redSlimeHealth : MonoBehaviour {


	public float hp = 15f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  if(hp <= 0f)
	  {
			Destroy (gameObject);
		}
	}

	public void TakeDamage (float dam)
	{
		hp -= dam;
	}
}
