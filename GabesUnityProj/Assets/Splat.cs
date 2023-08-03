using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Splat : MonoBehaviour
{
    public Rigidbody splatOnWall;
    public Transform bulletSplatPosition;
    public Vector3 offset = Vector3.up;

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Wall")
        {
            Rigidbody bulletInstance = Instantiate(splatOnWall, bulletSplatPosition.position + offset, Quaternion.LookRotation(other.contacts[0].normal) * Quaternion.Euler(90f ,0f, 0f)) as Rigidbody;
            Destroy(bulletInstance.gameObject, 5);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}