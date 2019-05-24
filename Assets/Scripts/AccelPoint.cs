using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelPoint : MonoBehaviour {



	void OnTriggerEnter(Collider other){
		other.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 10, 30), ForceMode.VelocityChange);
	}

	//AddForce関数
	//AddForce(Vector3,ForceMode);
	//rigidbodyに力を加える関数。ForceModeにはいくつか種類がある。

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
