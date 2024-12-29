using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField] GameObject finishPoint;
    [SerializeField] float speed;
    [SerializeField] int state;
    [SerializeField] bool leftMove;
    float startPoint;
    void Start()
    {
         startPoint=gameObject.GetComponent<Transform>().position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (leftMove)
        {
            if (gameObject.transform.position.x <= finishPoint.transform.position.x)
            {
                state = 1;
            }
            else if (gameObject.transform.position.x >= startPoint)
            {
                state = 2;
            }
        }
        else
        {
            if (gameObject.transform.position.x >= finishPoint.transform.position.x)
            {
                state = 2;
            }
            else if (gameObject.transform.position.x <= startPoint)
            {
                state = 1;
            }
        }

        switch(state)
        {
            case 1:
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
                break;
            case 2:
                transform.Translate(Vector3.back * Time.deltaTime * speed);
                break;
        }
    }
}
