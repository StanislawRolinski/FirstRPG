using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;

  
    void Start()
    {
        
    }


    void Update()
    {
        
        float moveX = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(moveX, moveY, 0f);
    }
}
