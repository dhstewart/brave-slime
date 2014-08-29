using UnityEngine;
using System.Collections;

public class Heart1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RemoveHeart ()
	{
		Destroy (gameObject);
	}
}
