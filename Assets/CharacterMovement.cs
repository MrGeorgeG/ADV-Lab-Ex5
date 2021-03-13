using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 10;
    
    public Rigidbody2D RB;
    Vector2 movementVector;

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector.y = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        RB.MovePosition(RB.position + movementVector * speed);
    }
}
