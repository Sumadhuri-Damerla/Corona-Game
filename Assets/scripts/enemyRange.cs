using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRange : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (target.position.x,target.position.y,target.position.z);
	}

	void OnTriggerEnter2D(Collider2D col)
	{

		if (col.gameObject.tag.Equals ("uninfected")) {
			Debug.Log ("infected");
		}
	}
}
