﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour {

	public Vector3 pos;

	void OnTriggerEnter(Collider other){
		
		//（考え方）触れた瞬間にボールに新しい位置情報をセットする。
		// 「0.5f」のように「小数」を使用する場合には必ず「f」を書くこと（ポイント）
		// 「f」は「float（浮動小数点）」の略

		other.gameObject.transform.position = new Vector3 (pos.x, pos.y,pos.z);

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
