using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour
{
	public float speed  = 10.0f;
	private int count;
	//public GameObject sparkle;
	public Animator anim;
	public GameObject bigBoy;

		void Start() {
			count = 0;
			Cursor.lockState = CursorLockMode.Locked;
			anim = GetComponent<Animator>();
			//sparkle = GetComponent<ParticleSystem>();
			bigBoy.GetComponent<GameObject>().SetActive(false);
		}

    void Update()
    {
			float translation = Input.GetAxis("Vertical") * speed;
			float straffe = Input.GetAxis("Horizontal") * speed;
			translation *= Time.deltaTime;
			straffe *= Time.deltaTime;
			transform.Translate(straffe, 0, translation);

			if(Input.GetKeyDown("escape")) {
				Cursor.lockState = CursorLockMode.None;
			}

			if(Input.GetKeyDown(KeyCode.W)) {
				anim.Play("WALK00_F", -1, 0f);
			}

			if(count == 5) {
				bigBoy.gameObject.SetActive(true);
			}
			if(count >= 6) {
				SceneManager.LoadScene("title", LoadSceneMode.Single);
			}
    }

		void OnTriggerEnter(Collider other) {
			if(other.gameObject.CompareTag("Pick Up")) {
				other.gameObject.SetActive(false);
				count = count + 1;
			}

			if(other.gameObject.CompareTag("BigBoy")) {
				other.gameObject.SetActive(false);
				count = count + 1;
				SceneManager.LoadScene("title", LoadSceneMode.Single);
			}
		}
}
