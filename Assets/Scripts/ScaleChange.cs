using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour {


	public Vector3 scale;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void OnTriggerEnter(Collider other){

		other.gameObject.transform.localScale = new Vector3 (scale.x, scale.y, scale.z);
	}
}