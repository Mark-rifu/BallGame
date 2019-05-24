using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour {


	private Vector3 pos;


	// Use this for initialization
	void Start () {

	
		// MoveFloorオブジェクトの位置情報をposの中に代入する。
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		// （ポイント）
		// Mathf.PingPong(float t, float length);
		// tの値を0からlengthの範囲内で行ったりきたりさせる。
		//上下にピストン運動させるのにシンプルな関数としてPingPong関数が使える。
		//Mathf.PingPong(時間,上下値)。今回は0〜5。

		this.gameObject.transform.position = new Vector3 (pos.x, pos.y + Mathf.PingPong (Time.time, 5), pos.z);
	}
}
