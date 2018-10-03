using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Player1Controller : MonoBehaviour
{

	
	private float count1;
	private Rigidbody2D rb2d;
	public float Speed = 0.01f;
	private int y; 
	private float BackSpace = 0.80f;

	public Text CountText1;
	
	
	// Use this for initialization
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();

		count1 = 0;
		SetCountText1();
	}
	
	void FixedUpdate()
	{
		//float moveHorizontal = Input.GetAxis("Horizontal");


		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector2.up * Speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector2.down * Speed * Time.deltaTime);
		}
		
		
//		
//		float moveVertical = Input.GetAxisRaw("Vertical2");
//
//		Vector2 movement = new Vector2(0, moveVertical);
//
//		rb2d.AddForce(movement * Speed);

	}
	
	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Finish")
		{
			Debug.Log("yuh");
			transform.position = new Vector2(-2.8f, -4.69f);
			
			//For an OnTriggerEnter2D for score count
			count1 = count1 + 1;
			SetCountText1();

		}
		
		if (collisionInfo.gameObject.tag == "GameObject")
		{
			transform.Translate(Vector3.down * BackSpace);
		}
	}

	void SetCountText1()
	{
		CountText1.text = "Player One: " + count1.ToString();
	}
	
	
}