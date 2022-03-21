using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguDirections : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody rb;
    public Camera cam;
    private Animator anim;

    Vector3 movement;
    Vector3 mousePos;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f)) - transform.position;
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        Animate();
    }

    void FixedUpdate() 
    {
        //Look at mouse
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector3 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.z, lookDir.x) * Mathf.Rad2Deg - 90f; //this makes it a bit more smooth I think
        //rb.rotation = angle;    
        
    }

    private void Animate()
    {
        anim.SetFloat("MouseX", mousePos.x); //movement.x works, but it's movement
        anim.SetFloat("MouseZ", mousePos.z); //movement.z works, but it's for movement
    }

}
