using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform leftHand;
    public GameObject teleportCrosshair;
    public GameObject gunCrosshair;

    void Start()
    {
        GameObject go = (GameObject)Resources.Load("Prefabs/teleportCrosshair");
        teleportCrosshair = Instantiate(go);
        teleportCrosshair.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            teleportCrosshair.SetActive(true);
            gunCrosshair.SetActive(false);
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            teleportCrosshair.SetActive(false);
            gunCrosshair.SetActive(true);
        }

        //Ray ray = new Ray(leftHand.transform.position, leftHand.transform.forward);
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit))
        //{
        //    if (Input.GetMouseButton(1))
        //    {
        //        teleportCrosshair.transform.position = hit.point;
        //        teleportCrosshair.transform.LookAt(transform.position);
        //    }
        //    if (Input.GetMouseButtonUp(1))
        //    {

        //        gunCrosshair.transform.position = hit.point;
        //        teleportCrosshair.transform.LookAt(transform.position);
        //    }
        //}
    }
}
