using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class jump : MonoBehaviour
{
    public float jumpForce = 200f;
    private bool isGrounded = false;
    private bool jumpAllowed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isGrounded)
            jumpAllowed = true;
    }

    private void FixedUpdate()
    {
        if (jumpAllowed)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
            jumpAllowed = false;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (other.gameObject.tag == "ground")
        {
            isGrounded = true;
        }

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGrounded = false;
        }
    }

}
