using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15;
    float vertical;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes it move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        vertical = Input.GetAxis("Vertical");

    }

    public void FixedUpdate()
    {
    Vector3 position = GetComponent<Rigidbody>().position;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
    }


}
