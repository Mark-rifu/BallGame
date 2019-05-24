using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class Chase : MonoBehaviour {


	public GameObject target;
	private NavMeshAgent agent;


	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		// 敵の目的地にターゲットの位置を設定する。
		agent.destination = target.transform.position;
		//destinationは、旅行先という意味。
		
	}
}
