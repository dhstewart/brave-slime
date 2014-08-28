using UnityEngine;
using System.Collections;

public class slimeHeadController : MonoBehaviour {
	



	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Physics2D.IgnoreLayerCollision(8, 11); // 8 = Player, 11 = slimeHead
	}

	void OnCollisionEnter2D (Collision2D col)
	{

		if(col.gameObject.tag == "flowerBox")
		{
			col.gameObject.GetComponent<FlowerBoxController>().Break();
			Destroy (col.gameObject, 2);
		}
	}
}