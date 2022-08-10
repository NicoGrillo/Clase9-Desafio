using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] [Range(1f, 10f)] float speed = 1f;
    [SerializeField] [Range(0.1f, 2f)] float rotateSpeed = 1f;
    [SerializeField] [Range(1f, 10f)] float rotateSmooth = 7f;

    float cameraAxisX = 0;

    // Update is called once per frame
    void Update()
    {
        Rotation();
        Move();
    }

    private void Move()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(ejeHorizontal, 0, ejeVertical) * speed * Time.deltaTime);
    }

    private void Rotation()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        //transform.rotation = Quaternion.Euler(0, cameraAxisX * rotateSpeed, 0);
        Quaternion newRotation = Quaternion.Euler(0, cameraAxisX * rotateSpeed, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotateSmooth * Time.deltaTime);
    }
}
