using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadSceneOnClick : MonoBehaviour
{
    public Button playGame;
    // Start is called before the first frame update
    void Start()
    {
        playGame.onClick.AddListener(LoadScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("InfiniteRunner");
    }
}
