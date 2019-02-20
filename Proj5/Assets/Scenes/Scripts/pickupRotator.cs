using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupRotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(15, 50, 20) * Time.deltaTime);
    }
}
