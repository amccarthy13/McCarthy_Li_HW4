using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleBehavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 5;
    public float shootSpeed = 20f;
    
    private float fbInput;
    private float lrInput;
    
    private Rigidbody _rb;

    public Vector3 jump;
    public float jumpForce = 20.0f;

    public GameObject Projectile;

    public bool isGrounded = true;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        if(collision.game)
    }

    void Update()
    {

        fbInput = Input.GetAxis("Vertical") * moveSpeed;
        lrInput = Input.GetAxis("Horizontal") * rotateSpeed;
    
        this.transform.Translate(Vector3.forward * fbInput * 
        Time.deltaTime);
        this.transform.Rotate(Vector3.up * lrInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject instProjectile = Instantiate(Projectile, this.transform.position, this.transform.rotation);
            instProjectile.transform.position = this.transform.position + this.transform.forward;
            Rigidbody instProjectileRB = instProjectile.GetComponent<Rigidbody>();
            instProjectileRB.AddForce(this.transform.forward * shootSpeed);
        }
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
