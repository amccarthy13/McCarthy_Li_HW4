using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleBehavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 5;
    
    private float fbInput;
    private float lrInput;
    
    private Rigidbody _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        fbInput = Input.GetAxis("Vertical") * moveSpeed;
        lrInput = Input.GetAxis("Horizontal") * rotateSpeed;
    
        this.transform.Translate(Vector3.forward * fbInput * 
        Time.deltaTime);
        this.transform.Rotate(Vector3.up * lrInput * Time.deltaTime);
    }
    
    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * lrInput;

        Quaternion angleRot = Quaternion.Euler(rotation *
            Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position +
            this.transform.forward * fbInput * Time.fixedDeltaTime);

         _rb.MoveRotation(_rb.rotation * angleRot);
    }
    
}
