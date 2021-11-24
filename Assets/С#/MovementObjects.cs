using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObjects : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x <= -1.31f)
        {
            speed = -speed;
        }
        if (transform.position.x >= 0f)
        {
            speed = 2;
        }
    }
}
