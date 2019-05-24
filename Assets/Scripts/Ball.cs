using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody rb;
	public AudioClip coinGet;
	public float jumpSpeed;

	// ★★改良（空中ジャンプ禁止）
	// boolは「真偽型」と呼ばれ「true」か「false」の２つの値を扱うことができます。
	private bool isJumping = false;
	private int coinCount = 0;

	public GameObject target;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {


		float moveH = -Input.GetAxis ("Horizontal");
		float moveV = -Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveH, 0, moveV);
		rb.AddForce(movement * moveSpeed);

		if (Input.GetButtonDown ("Jump")&& isJumping == false) {
			rb.velocity = Vector3.up * jumpSpeed;


			isJumping = true;
		}

	}

	void OnTriggerEnter(Collider other){
		if (other.CompareTag("Coin")==true){
			Destroy (other.gameObject);

			AudioSource.PlayClipAtPoint (coinGet, transform.position);

			// コインを１枚取得するごとに「coinCount」を１ずつ増加させる。
			coinCount += 1;

		
			if (coinCount == 2) {

				// （ポイント）
				// SetActive()メソッドはオブジェクトをアクティブ／非アクティブ状態にすることができる。
				target.SetActive (true);


			}

			if(coinCount == 4)

				SceneManager.LoadScene("GameClear");



		}

		if (other.CompareTag ("Enemy") == true) {
			SceneManager.LoadScene ("GameOver");

		}
	}






	public int Coin(){
		return coinCount;


	}


		void OnCollisionEnter(Collision other){
			if(other.gameObject.CompareTag("Floor")){
				isJumping = false;

			}

		}
}
