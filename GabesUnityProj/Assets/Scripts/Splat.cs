using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Splat : MonoBehaviour
{
    public Rigidbody splatOnWall;
    public Transform bulletSplatPosition;
    public Vector3 offset = Vector3.up;
    public float lifeTime;

    private Vector3 initialVelocity;
    private float minVelocity = 10f;
    private Vector3 lastFrameVelocity;
    private Rigidbody rb;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialVelocity;
    }

    private void Update()
    {
        lastFrameVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Wall")
        {
            if (gameObject.GetComponent<Renderer>().material.color == other.gameObject.GetComponent<Renderer>().material.color)
            {
                Rigidbody bulletInstance = Instantiate(splatOnWall, bulletSplatPosition.position + offset, Quaternion.LookRotation(other.contacts[0].normal) * Quaternion.Euler(90f, 0f, 0f)) as Rigidbody;
                Destroy(bulletInstance.gameObject, lifeTime);
                Destroy(gameObject);
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = other.gameObject.GetComponent<Renderer>().material.color;
                Bounce(other.contacts[0].normal);
            }
        }
        if (other.gameObject.tag == "Ball")
        {
            Bounce(other.contacts[0].normal);
        }
    }
    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }
}