using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCarController1 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
		
		transform.Translate(Vector2.left * -0.2f, Space.World);
		
		
	}
	
	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "RightTrigger")
		{
			Debug.Log("yuh");
			transform.position = new Vector2(-15.04f, -0.37f);
			
			
			//For an OnTriggerEnter2D for score count
			//count1 = count1 + 1;
			//SetCountText1();

		}
	}
	
}
