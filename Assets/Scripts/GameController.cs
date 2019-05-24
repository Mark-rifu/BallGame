using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

	public Text timeLabel;
	public float timeCount;

	//配列（複数のデータを入れることのできる仕切りのある箱）
	public GameObject[] icons;
	private Ball ballScript;



	// Use this for initialization
	void Start () {
		timeLabel.text = "TIME:" + timeCount;

		// 「Ball」オブジェクトに付いている「Ball」スクリプトにアクセスする。
		ballScript = GameObject.Find("Ball").GetComponent<Ball>();

	}

	
	// Update is called once per frame
	void Update () {


		timeCount -= Time.deltaTime;

		// ToString("0")は小数点を切り捨て
		// 小数点1位まで表示するにはToString("n1")
		// 小数点2位まで表示するにはToString("n2")
		timeLabel.text = "TIME:" + timeCount.ToString("0");

		if (timeCount < 0) {
			SceneManager.LoadScene("GameOver");
		}

		UpdateCoin (ballScript.Coin ());



	}

	// コインアイコンを表示するメソッド

	void UpdateCoin(int coin){

		for (int i = 0; i < icons.Length; i++) {

			if(coin <= i){

				// コインアイコンを表示状態にする。
			icons [i].SetActive (true);
		}else{
				// コインアイコンを非表示状態にする。
			icons[i].SetActive(false);


		}
	}
}

}
