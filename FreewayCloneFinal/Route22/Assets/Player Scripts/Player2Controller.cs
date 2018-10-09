using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Controller : MonoBehaviour
{

	
	private float count1;
	public float Speed;
	private float BackSpace = 0.80f;
	private int y;
	
	public Text CountText1;

	// Use this for initialization
	void Start () {
		
		count1 = 0;
		SetCountText1();
		
		Debug.Log("Screen Width : " + Screen.width);
		Debug.Log("Screen Height : " + Screen.height);

		
	}



	void FixedUpdate()
	{
		//float moveHorizontal = Input.GetAxis("Horizontal");
	
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector2.up * Speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector2.down * Speed * Time.deltaTime);
		}

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		
	if (col.collider.tag == "Finish")
		{
			transform.position = new Vector2(2.48f, -4.69f);
					
			//For an OnTriggerEnter2D for score count
			count1 = count1 + 1;
			SetCountText1();

		}

		if (col.collider.tag == "GameObject")
		{
			transform.Translate(Vector3.down * BackSpace);
			
			
			
			FindObjectOfType<AudioManager>().Play("ChickenSound");
		}
		
	}

	

	void SetCountText1()
	{
		CountText1.text = "Player Two: " + count1.ToString();
	}
	
}
