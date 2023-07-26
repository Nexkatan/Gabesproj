using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Update()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}