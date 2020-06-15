using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public Transform[] points;

    private int num;
    private float current;  // от 0.0 до 1.0
    private float dir;

    // Start is called before the first frame update
    void Start()
    {
        current = 0.0f;
        dir = 1.0f;
        num = 0;
    }

    void Update()
    {
        current += dir * speed * Time.deltaTime;
        if (current > 1.0f)
        {
            if (num < points.Length - 2) {
                num++;
                current = 0.0f;
            }
            else {
                current = 1.0f;
                dir = -1.0f;
            }

        }
        else if (current < 0.0f)
        {
            if (num > 0) {
                num--;
                current = 1.0f;
            }
            else {
                current = 0.0f;
                dir = 1.0f;
            }
        }

        transform.position = Vector3.Lerp(points[num].position, points[num + 1].position, current);
        
    }
}
