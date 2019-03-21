using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2Controller : MonoBehaviour
{
  //public Transform follow;
  //public GameObject player;      //Public variable to store a reference to the player game object
  public Transform player;    //Private variable to store the offset distance between the player and camera

  // Use this for initialization
  void Start ()
  {
    //player = GameObject.Find("player");
  }

  void Update() {
     Vector3 targetPosition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
     transform.LookAt(targetPosition);
  }

}
