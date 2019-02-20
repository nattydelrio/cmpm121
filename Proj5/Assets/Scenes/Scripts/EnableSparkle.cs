using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableSparkle : MonoBehaviour {

	public GameObject sparkle;
	//public GameObject pickup;

	// Update is called once per frame
	void Update () {
				sparkle.GetComponent<GameObject>().SetActive(false);
				//sparkle = this.transform.parent.gameObject;
        //gameObject.transform.Rotate(new Vector3(15, 50, 20) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Player")) {
			gameObject.SetActive(false);
			sparkle.gameObject.SetActive(true);
		}
	}
}
