using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 targetOffset;
    [SerializeField] float movementSpeed;
    [SerializeField] float rotationSpeed;

    void Start()
    {
        
    }

    void Update()
    {
       MoveCamera();
       RotateCamera();
    }

    void MoveCamera()
    {
	transform.position = Vector3.Lerp(transform.position, target.position + targetOffset, movementSpeed * Time.deltaTime);
    }

    void RotateCamera()
    {
	transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
    }
}
