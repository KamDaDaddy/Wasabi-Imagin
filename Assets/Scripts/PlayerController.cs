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
        //Makes it move forward
        Vec = transform.localPosition;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Vec.y += Input.GetAxis("Vertical") * Time.deltaTime * speed;
    }

}
