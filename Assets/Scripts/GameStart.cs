using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;


public class GameStart: MonoBehaviour {


	public void OnStartButtonClicked (){
		SceneManager.LoadScene ("Main");
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
