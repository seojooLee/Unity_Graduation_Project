using UnityEngine;
using System.Collections;

public class upanddown : MonoBehaviour
{
    public AnimationCurve myCurve;
    //adjust this to change speed
    float speed = 5f;
    //adjust this to change how high it goes
    float height = 0.5f;
    public int maxSpeed;

  private Vector3 startPosition;

    void Start()
    {
        maxSpeed = 3;
        startPosition = transform.position;
    }

    void Update()
    {
        MoveVertical();
    }

    //void Update()
    //{
    //    //get the objects current position and put it in a variable so we can access it later with less code
    //    Vector3 pos = transform.position;
    //    //calculate what the new Y position will be
    //   // float newY = Mathf.Sin(Time.time * speed);
    //    //set the object's Y to the new calculated Y
    //    transform.position = new Vector3(0, startPosition.y + Mathf.Sin(Time.time * maxSpeed), 0);
    //}

    void MoveVertical()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        if (transform.position.y > 1.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        else if (transform.position.y < -1.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }


}
