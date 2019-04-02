using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class obstacle : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(-8f * Time.deltaTime, 0f, 0f);
    }
}

