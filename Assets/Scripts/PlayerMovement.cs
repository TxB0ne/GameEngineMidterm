using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float moveSpeed;

    [SerializeField]
    float maxPos;

    void Start()
    {

    }


    void Update()
    {


    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;
    }

}
