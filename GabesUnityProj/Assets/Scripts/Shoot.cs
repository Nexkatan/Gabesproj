using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody sphereBullet;
    public Transform firePosition;
    public float bulletSpeed;
    public float rotateSpeed;

    void Update()
    {
        Shoota();
    }


    public void Shoota()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody bulletInstance = Instantiate(sphereBullet, firePosition.position + new Vector3(0, 0, 1), firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.up * bulletSpeed);
        }

    }

    public void songShoot()
    {

        Rigidbody bulletInstance = Instantiate(sphereBullet, firePosition.position + new Vector3(0, 0, 1), firePosition.rotation) as Rigidbody;
        bulletInstance.AddForce(firePosition.forward * bulletSpeed);

    }
}