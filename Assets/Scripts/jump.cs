using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class jump : MonoBehaviour
{
    public float jumpForce = 275f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


    }
   
}
