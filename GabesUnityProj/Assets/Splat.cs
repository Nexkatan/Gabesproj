using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splat : MonoBehaviour
{
    public Rigidbody splatOnWall;
    public Transform bulletSplatPosition;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Rigidbody bulletInstance = Instantiate(splatOnWall, bulletSplatPosition.position, bulletSplatPosition.rotation) as Rigidbody;
            Destroy(gameObject);
        }
    }
}