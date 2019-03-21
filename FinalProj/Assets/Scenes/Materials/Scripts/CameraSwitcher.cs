using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
  public Camera CameraOn;
  public Camera CameraOff;

    public void OnTriggerEnter(Collider trigger) {
      if(trigger.gameObject.CompareTag("Player")) {
      CameraOn.enabled = true;
      CameraOff.enabled = false; }
    }
}
