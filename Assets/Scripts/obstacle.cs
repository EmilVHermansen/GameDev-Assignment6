using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class obstacle : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counter;
    public int score = 0;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(-8f * Time.deltaTime, 0f, 0f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "roof")
        {
            Destroy(gameObject);
            score += 1;
        }


    }

    void counterText()
    {
        counter.text = "Score: " + score.ToString();
        

    }



}

