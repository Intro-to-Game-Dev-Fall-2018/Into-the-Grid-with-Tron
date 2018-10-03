using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class carController9 : MonoBehaviour
{

	//private Transform carPrefab;	
	
	// Use this for initialization
	void Start () {
		//Transform car = Instantiate(carPrefab) as Transform;
		//Physics2D.IgnoreCollision(car.GetComponent<Collider2D>(),GetComponent<Collider2D>());
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
			transform.position = new Vector2(11.65f, 3.52f);
			
			
			//For an OnTriggerEnter2D for score count
			//count1 = count1 + 1;
			//SetCountText1();

		}

//		if (collisionInfo.gameObject.tag == "RightTrigger")
//		{
//			
//			Physics2D.IgnoreCollision(carPrefab.GetComponent<Collider2D>(),collisionInfo.gameObject.GetComponent<Collider2D>());
//		}
//		
		
	}
	
}
