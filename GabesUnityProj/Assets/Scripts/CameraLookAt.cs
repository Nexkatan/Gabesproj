using UnityEngine;
using System.Collections;
using TMPro;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothTime = 0.25f;
    Vector3 currentVelocity;
    public float rotateSpeed = 50f;


    private void Start()
    {
        Vector3 targetPosition = target.position + (transform.position - target.position).normalized * 3 + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);
    }
    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(target.position, new Vector3(0.0f, 1.0f, 0.0f), rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(target.position, new Vector3(0.0f, 1.0f, 0.0f), rotateSpeed * Time.deltaTime);
        }
        transform.LookAt(target);
    }
}