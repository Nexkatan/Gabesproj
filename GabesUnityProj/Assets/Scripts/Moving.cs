using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 50f;

    void Update()
    {
        Move();
        Rotate();
    }

   void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
    void Rotate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }
}
