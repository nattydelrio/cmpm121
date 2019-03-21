using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 10;
    public float gravity = 30;
    public float jumpStrength = 40;
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;

    private Rigidbody rb;
    CharacterController controller;
    Vector3 movement = Vector3.zero;

	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody>();
        //controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
/*	void Update () {

      float moveHorizontal = Input.GetAxis("Horizontal");
      float moveVertical = Input.GetAxis("Vertical");

      if(controller.isGrounded) {
        movement = new Vector3(moveHorizontal, 0, moveVertical);
        movement = transform.TransformDirection(movement);
        movement = movement * speed;
        if(Input.GetKeyDown(KeyCode.Space)) {
          movement.y = jumpStrength;
          //movement += Vector3.up * jumpStrength;
        }
      }
      else {
        movement += new Vector3(0, -gravity, 0);
      }
      movement.y = movement.y - (gravity * Time.deltaTime);
      controller.Move(movement * Time.deltaTime);
      //transform.position += movement * Time.deltaTime;

      //rb.AddForce(movement * speed);

    } */

    public void MovePlayer() {
      if (Input.GetKey(KeyCode.W)){
        controller.Move(Camera.main.transform.forward * speed);
      }
      if (Input.GetKey(KeyCode.S)) {
        controller.Move(Camera.main.transform.forward * -1 * speed);
      }
      if (Input.GetKey(KeyCode.A)) {
        controller.Move(Camera.main.transform.right * -1 * speed);
      }
      if (Input.GetKey(KeyCode.D)) {
        controller.Move(Camera.main.transform.right * speed);
      }
    } 
}
