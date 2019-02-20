using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
  void Update() {
    if(Input.anyKey) {
      Debug.Log("Any key has been pressed");
      SceneManager.LoadScene("mainscene", LoadSceneMode.Single);
    }
  }
}
