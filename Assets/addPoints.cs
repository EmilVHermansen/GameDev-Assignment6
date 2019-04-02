using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class addPoints : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counter;
    int countAmount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Destroy(collision.gameObject);
            incrementPoint();
        }
    }

    private void incrementPoint()
    {
        countAmount++;
        UpdateText();
    }

    private void UpdateText()
    {
        counter.text = "Score " + countAmount;
    }
}