using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float _horizontalInput;
    private float _verticalInput;
    
    private const float Speed = 15.0f;
    private const float TurnSpeed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");
        
        // Moves vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * _verticalInput);
        // Rotates vehicle based on horizontal input
        transform.Rotate(Vector3.up, TurnSpeed * _horizontalInput * Time.deltaTime);
    }
}
