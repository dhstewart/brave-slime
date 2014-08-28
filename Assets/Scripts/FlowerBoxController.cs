using UnityEngine;
using System.Collections;

public class FlowerBoxController : MonoBehaviour {

	private Transform frontCheck;
	Animator anim;

	void Awake ()
	{
	frontCheck = transform.Find("frontCheck").transform;
	}

	bool broken = true;



	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame

	public void Break ()
	{  
		anim.SetBool("Broken", broken);
	}

}
