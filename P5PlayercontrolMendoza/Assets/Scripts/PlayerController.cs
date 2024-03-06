using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    private float horizontalInput;
    private float forwardInput;
    public Camera hoodCamera;
    public Camera mainCamera;
    public KeyCode switchKey;
    // Start is called before the first frame update
   
    
        
    

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput );
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime );

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
