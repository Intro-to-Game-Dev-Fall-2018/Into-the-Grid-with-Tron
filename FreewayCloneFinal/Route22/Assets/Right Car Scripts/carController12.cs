using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController12 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
		
		transform.Translate(Vector2.left * .1f, Space.World);
		
		
	}
	
	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "LeftTrigger")
		{
			Debug.Log("yuh");
			transform.position = new Vector2(11.65f, -1.38f);
			
			
			//For an OnTriggerEnter2D for score count
			//count1 = count1 + 1;
			//SetCountText1();

		}
	}
	
}

