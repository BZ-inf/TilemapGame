using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerW : MonoBehaviour
{
    public float PlayerWSpeed = 1;
    public float PlayerWJump = 1;
    private float Hdir;
    private float Vdir;
    private Rigidbody2D fx;
    private bool jump = false;
    void Start()
    {
        fx = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Hdir = Input.GetAxisRaw("Horizontal");
        Vdir = Input.GetAxisRaw("Vertical");
        // transform.position += new Vector3 (Hdir, Vdir, 0)*Time.deltaTime ;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        fx.velocity = new Vector2(Hdir * PlayerWSpeed, fx.velocity.y);
        if (jump)
        {
            fx.AddForce(Vector2.up * PlayerWJump, ForceMode2D.Impulse);
            jump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D win)
    {
        if (win.gameObject.tag == "Acorn")
        {
            Destroy(win.gameObject);
        }
    }
}




