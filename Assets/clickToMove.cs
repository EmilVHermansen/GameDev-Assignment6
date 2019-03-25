using UnityEngine;

public class clickToMove : MonoBehaviour
{
    public int playerSpeed = 25;
    public float moveSpeed = 10000.0f;
    // Update is called once per frame
    void Update()
    {
        //rotate player
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //transform.LookAt(ray.GetPoint(0), Vector3.forward);
        //Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);

        //click to move
        if (Input.GetMouseButtonDown(0))
        {
            var pos = Input.mousePosition;
            pos.z = transform.position.z - Camera.main.transform.position.z;
            pos = Camera.main.ScreenToWorldPoint(pos);
            transform.position = Vector2.Lerp(transform.position, pos, moveSpeed * Time.deltaTime);

        }
    }
}