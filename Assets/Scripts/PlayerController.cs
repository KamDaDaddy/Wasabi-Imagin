using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15;
    public float RotateSpeed;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Makes plne move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        verticalInput = Input.GetAxis("Vertical");
      
      //Makes plne go up/down 
        transform.Rotate(Vector3.right * Time.deltaTime * RotateSpeed * verticalInput);

        
    }

}
