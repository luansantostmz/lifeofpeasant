using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField] float speed;
	[SerializeField] Animator anim;

	Vector3 direction;
	private void Start()
	{
		
	}
	private void Update()
	{
		Move();
	}
	private void FixedUpdate()
	{
		transform.position += direction * speed * Time.deltaTime; // move player
	}

	public void Move() 
	{
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");

		direction = new Vector3(horizontal, vertical);

		AnimateMovement(direction);		
	}

	 void AnimateMovement(Vector3 direction)
	{
		if(anim != null) 
		{
			if(direction.magnitude > 0) 
			{
				anim.SetBool("isMoving", true);

				anim.SetFloat("horizontal", direction.x);
				anim.SetFloat("vertical", direction.y);
			}
			else 
			{
				anim.SetBool("isMoving", false);
			}
		}


	}
}
