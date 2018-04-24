using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_PlayerScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){

		//if it collides with portal
		if (col.gameObject.tag == "Portal")
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
