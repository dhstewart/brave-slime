using UnityEngine;
using System.Collections;

public class SlimeHealth : MonoBehaviour {

	public float hp = 3f;
	public Heart1 heart1;
	public Heart2 heart2;
	public Heart3 heart3;

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
			hp -= 1f;

			if(heart1 != null && hp < 3f)
			{
				heart1.RemoveHeart();
			}

			else if(heart2 != null && hp < 2f)
			{
				heart2.RemoveHeart();
			}

			else if(heart3 != null && hp < 1f)
			{
				heart3.RemoveHeart();
			}
		}
	}
}
















