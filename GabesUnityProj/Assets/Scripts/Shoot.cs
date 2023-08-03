using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody sphereBullet;
    public Transform firePosition;
    public float bulletSpeed;
    public float rotateSpeed;
    public float fireRate;
    private float lastShot;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoota();
            Debug.Log(gameObject.GetComponent<Renderer>().material.color);
        }
    }


    public void Shoota()
    {
        if (Time.time > fireRate + lastShot)
        {
            Rigidbody bulletInstance = Instantiate(sphereBullet, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.up * bulletSpeed);
            Destroy(bulletInstance.gameObject, 5);
            lastShot = Time.time;
        }
    }

    public void songShoot()
    {

        Rigidbody bulletInstance = Instantiate(sphereBullet, firePosition.position + new Vector3(0, 0, 1), firePosition.rotation) as Rigidbody;
        bulletInstance.AddForce(firePosition.forward * bulletSpeed);

    }
}