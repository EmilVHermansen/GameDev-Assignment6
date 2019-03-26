using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 250f));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            Destroy(gameObject);
            Instantiate(gameObject, new Vector3(-11f, 0.2f, -10f), Quaternion.identity);
            gameObject.AddComponent<Rigidbody2D>();
        }


    }
   
}
