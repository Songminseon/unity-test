using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");  

        moveDirection = new Vector3(x, y, 0);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;      
    }
}
