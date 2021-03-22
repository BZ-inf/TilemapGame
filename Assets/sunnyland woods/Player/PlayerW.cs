using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerW : MonoBehaviour
{
    public float PlayerSpeed = 1;
    public float PlayerJump = 1;
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
        fx.velocity = new Vector2(Hdir * PlayerSpeed, fx.velocity.y);
        if (jump)
        {
            fx.AddForce(Vector2.up * PlayerJump, ForceMode2D.Impulse);
            jump = false;
        }
    }


}







