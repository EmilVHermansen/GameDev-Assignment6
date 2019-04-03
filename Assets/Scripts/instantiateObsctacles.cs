using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateObsctacles : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacleSquare;
    public GameObject obstacleFly;
    private bool playing = false;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, new Vector3(-11f, 0.2f, -10f), Quaternion.identity);
        playing = true;
        StartCoroutine(Wave());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Wave()
    {
        yield return new WaitForSeconds(1f);
        while(playing)
        {

            yield return new WaitForSeconds(2f);
            int number = Random.Range(0, 2);
            float speed = Random.Range(0.2f, 0.6f);
            print(number);
            if (number > 0)
            {
                Instantiate(obstacleSquare, new Vector2(11f, speed), Quaternion.identity);
            }
            else
            {
                Instantiate(obstacleFly, new Vector2(11f, speed), Quaternion.identity);
            }
            yield return null;
        }
    }


}
