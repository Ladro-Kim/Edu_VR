using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    float mX, mY;
    float rotSpeed = 200;

    void Update()
    {
        float xInput = Input.GetAxis("Mouse X");
        float yInput = Input.GetAxis("Mouse Y");
        mX += xInput * rotSpeed * Time.deltaTime;
        mY += yInput * rotSpeed * Time.deltaTime;

        mY = Mathf.Clamp(mY, -90, 90);
        Vector3 rot = new Vector3(-mY, mX, 0);

        transform.eulerAngles = rot;
    }
}
