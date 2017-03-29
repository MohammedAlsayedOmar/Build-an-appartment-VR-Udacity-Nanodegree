using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Input.gyro.enabled = true; //activate the gyro on the phone
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion att = Input.gyro.attitude; //get the gyro data
        att = Quaternion.Euler(90f, 0f, 0f) * new Quaternion(att.x, att.y, -att.z, -att.w); //reorient the gyro data with the display
        transform.rotation = att; //assign the new rotation to the camera
    }
}
