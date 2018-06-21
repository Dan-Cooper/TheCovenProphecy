using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public GameObject Player;//<--
	public float Gravity;//<-- may not be needed.
	public float Speed;//at witch player accelerates to max speed;
	public float MaxSpeed;//the max travle speed;
	public float Jump;
	private Vector2 _forceToBeAdded;
	private bool _grounded;
	private bool _facingRight;
	private bool _idle;
	private bool _jumpRequest;
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Jump"))
			
			_jumpRequest = true;
		Move();
	}
	
	//Called for base movment 
	private void Move()
	{
		float h = Input.GetAxis("Horizontal");
		if (h * Player.GetComponent<Rigidbody2D>().velocity.x < MaxSpeed && h != 0)
			Player.GetComponent<Rigidbody2D>().AddForce(Vector2.right * h * Speed );
		if (h * Player.GetComponent<Rigidbody2D>().velocity.x > MaxSpeed && h != 0)
			Player.GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(Player.GetComponent<Rigidbody2D>().velocity.x) * MaxSpeed, Player.GetComponent<Rigidbody2D>().velocity.y);

		if (h == 0)
		{
			
		}
		
		if (h > 0 && !_facingRight)
			Flip();
		if(h<0 && _facingRight)
			Flip();
		if (_jumpRequest)
		{
			Player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, Jump), ForceMode2D.Impulse);
			_jumpRequest = false;
		}
	}
	
	//Used for Animation
	//Flips the Sprite and the bool
	private void Flip()
	{
		_facingRight = !_facingRight;
	}
	
	//Returns wether the player is grounded to outside methods;
	public bool IsGrounded()
	{
		return _grounded;
	}

	private void Idle()
	{
		_idle = true;
	}
}
