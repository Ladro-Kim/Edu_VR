using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    GameObject[] pool_bullet;
    public GameObject prefab_bullet;
    public GameObject bulletEffect;
    public Transform rightHandPos;

    int maxBullet;
    int curBullet;

    void Start()
    {
        MakeBulletPool(10);
        curBullet = maxBullet;
    }

    void Update()
    {
        Ray ray = new Ray(rightHandPos.position, rightHandPos.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 0.1f);
            if (Input.GetButtonDown("Fire1"))
            {
                if (curBullet <= 0)
                    return;

                curBullet--;
                GameObject temp = pool_bullet[curBullet];
                temp.SetActive(true); ;
                temp.transform.position = hit.point;
                temp.transform.LookAt(hit.normal);
                temp.GetComponent<ParticleSystem>().Play();
            }
        }
    }

    void MakeBulletPool(int i)
    {
        maxBullet = i;
        pool_bullet = new GameObject[maxBullet];
        for (int k = 0; k < pool_bullet.Length; k++)
        {
            GameObject temp = Instantiate(bulletEffect);
            temp.SetActive(false);
            pool_bullet[k] = temp;
        }
    }

}
