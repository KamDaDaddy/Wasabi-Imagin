using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 Vec;
    public float speed = 15;
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes plne move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Vec = transform.localPosition;
      
      //Makes plne go up
       if (Input.GetKey(KeyCode.W)) 
       {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
       }
        
      //Makes plne go down
       if (Input.GetKey(KeyCode.S))
       {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
       }
        
    }

}
