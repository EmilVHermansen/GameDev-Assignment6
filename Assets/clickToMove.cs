using System.Collections;
using UnityEngine;

public class clickToMove : MonoBehaviour
{
    public float moveSpeed = 1f;
    // Update is called once per frame
    void Update()
    {
        //rotate player
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.LookAt(ray.GetPoint(0), Vector3.forward);
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);

        //click to move
        if (Input.GetMouseButtonDown(0))
        {
            var pos = Input.mousePosition;
            pos.z = transform.position.z - Camera.main.transform.position.z;
            pos = Camera.main.ScreenToWorldPoint(pos);
            transform.position = Vector2.Lerp(transform.position, pos, moveSpeed * Time.deltaTime);

        }
    }

    //void Clicked()
    //{
    //    // Get the target position
    //    Vector3 relativeLocation = new Vector3(0, -10, 0);
    //    Vector3 targetLocation = transform.position + relativeLocation;
    //    float timeDelta = 0.05f;

    //    // Start your coroutine
    //    this.StartCoroutine(SmoothMove(targetLocation, timeDelta));
    //}

    //IEnumerator SmoothMove(Vector3 target, float delta)
    //{
    //    // Will need to perform some of this process and yield until next frames
    //    float closeEnough = 0.2f;
    //    float distance = (transform.position - target).magnitude;

    //    // GC will trigger unless we define this ahead of time
    //    WaitForEndOfFrame wait = new WaitForEndOfFrame();

    //    // Continue until we're there
    //    while (distance >= closeEnough)
    //    {
    //        // Confirm that it's moving
    //        Debug.Log("Executing Movement");

    //        // Move a bit then  wait until next  frame
    //        transform.position = Vector3.Slerp(transform.position, target, delta);
    //        yield return wait;

    //        // Check if we should repeat
    //        distance = (transform.position - target).magnitude;
    //    }

    //    // Complete the motion to prevent negligible sliding
    //    transform.position = target;

    //    // Confirm  it's ended
    //    Debug.Log("Movement Complete");
    //}
}