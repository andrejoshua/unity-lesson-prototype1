using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBehaviour : MonoBehaviour
{
    
    private const float Speed = 25.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
