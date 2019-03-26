using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinscript : MonoBehaviour
{

    private TMP_Text m_TextComponent;
    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            score += 1;
            incrementPoints();
        }


    }

    void incrementPoints()
    {
        m_TextComponent = GetComponent<TMP_Text>();
        m_TextComponent.text = "Points: " + score.ToString();

    }


}
