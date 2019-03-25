using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateObsctacles : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacleSquare;
    public GameObject obstacleFly;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, new Vector3(-11f, 0.2f, -10f), Quaternion.identity);
        StartCoroutine(Wave());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Wave()
    {
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < 100; i++)
        {

            yield return new WaitForSeconds(2f);
            int number = Random.Range(0, 2);
            print(number);
            if (number > 0)
            {
                Instantiate(obstacleSquare, new Vector2(11f, 0.2f), Quaternion.identity);
            }
            else
            {
                Instantiate(obstacleFly, new Vector2(11f, 0.4f), Quaternion.identity);
            }
            yield return null;
        }
    }


}
