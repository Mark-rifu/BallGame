using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameOverFloor : MonoBehaviour {



	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag ("Player")) {
			SceneManager.LoadScene ("GameOver");



		}
	}
}

	// Use this for initialization
	