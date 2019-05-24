using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBlock : MonoBehaviour {

	// Use this for initialization

	private Rigidbody rb;


	void Start () {

		rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame

	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag ("Player")) {


			// （ポイント）Invoke("呼び出すメソッド名", 呼び出すまでの時間)
			// Fallという名前のメソッドを２秒後に呼び出す。

			Invoke("Fall", 2);
		}

	}


	void Fall(){

		// （ポイント）isKinematicを無効化する
		rb.isKinematic = false;
	}
}

