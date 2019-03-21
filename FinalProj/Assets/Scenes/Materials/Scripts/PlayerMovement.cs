using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
      public float speed;
      public Text countText;
      private int count;

      private Rigidbody rb;

      void Start ()
      {
          rb = GetComponent<Rigidbody>();
          count = 0;
          SetCountText();
      }

      void FixedUpdate ()
      {
          float moveHorizontal = Input.GetAxis ("Horizontal");
          float moveVertical = Input.GetAxis ("Vertical");

          Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
          if(Input.GetKeyDown(KeyCode.Space)) {
            movement.y = speed;
            //movement += Vector3.up * jumpStrength;
          }

          rb.AddForce (movement * speed);
      }

      void OnCollisionEnter(Collision other) {
          if(other.gameObject.CompareTag("Pick Up")) {
              Destroy(other.gameObject);//other.gameObject.SetActive(false);
              count = count + 1;
              SetCountText();
          }
      }

      void SetCountText () {
          countText.text = "Points: " + count.ToString();
      }
}
