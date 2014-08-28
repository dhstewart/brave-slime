using UnityEngine;
using System.Collections;

public class redSlimeGo : MonoBehaviour {


	public float moveSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate (-Vector2.right * moveSpeed);
	}
}
