using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Portal : MonoBehaviour {

	public Rigidbody2D rb;

	//Rotation Speed
	public float rotSpeed = 1f; 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.transform.Rotate (0,0,rotSpeed);
	}
}
