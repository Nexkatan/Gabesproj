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
    public float lifeTime;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoota();
        }
    }


    public void Shoota()
    {
        if (Time.time > fireRate + lastShot)
        {
            Rigidbody bulletInstance = Instantiate(sphereBullet, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.transform.localScale = Vector3.one * 5;
            bulletInstance.AddForce(firePosition.up * bulletSpeed);
            Destroy(bulletInstance.gameObject, lifeTime);
            lastShot = Time.time;
        }
    }

    public void songShoot()
    {

        Rigidbody bulletInstance = Instantiate(sphereBullet, firePosition.position + new Vector3(0, 0, 1), firePosition.rotation) as Rigidbody;
        bulletInstance.AddForce(firePosition.forward * bulletSpeed);

    }
}