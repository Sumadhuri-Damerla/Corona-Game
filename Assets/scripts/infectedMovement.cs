using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infectedMovement : MonoBehaviour {

	float movementSpeed = 0.1f;
	Vector2 speed; 
	Rigidbody2D infPerson;
	float maxtimer = 1f;
	float timer;
	float dirX = 1;
	float dirY = 0;
	bool collided = false;


	// Use this for initialization
	void Start () {
		infPerson = GetComponent <Rigidbody2D> ();
		timer = maxtimer;
		speed = new Vector2(movementSpeed,movementSpeed);
	}
	
	// Update is called once per frame
	void Update () {


		timer -= 1*Time.deltaTime;

		if(timer < 0) {

			if (!collided) {
				dirX = Random.Range (-1, 2);
				dirY = Random.Range (-1, 2);

				if(dirX == 0 && dirY == 0) {
					dirX = 1f;
				}

			}

			timer = maxtimer;
			collided = false;

			speed = new Vector2(dirX * movementSpeed , dirY * movementSpeed);


		}

		transform.Translate(speed);
				
	}


	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.tag.Equals ("boundary")) {

			if(col.gameObject.name.Equals("rightBound")) {
				dirX = -1;
			//	dirY = Random.Range (-1,2);
				timer = -1;
			//	Debug.Log (infPerson.transform.position.x);
			} 
			if (col.gameObject.name.Equals("leftBound")) {
				dirX = 1;
			//	dirY = Random.Range (-1,2);
				timer = -1;
			}
			if (col.gameObject.name.Equals("upperBound")) {
				dirY = -1;
			//	dirX = Random.Range (-1,2);
				timer = -1;
			}

			if (col.gameObject.name.Equals("lowerBound")) {
				dirY = 1;
		//		dirX = Random.Range (-1,2);
				timer = -1;
			}

			collided = true;
	
		}
	}

}
