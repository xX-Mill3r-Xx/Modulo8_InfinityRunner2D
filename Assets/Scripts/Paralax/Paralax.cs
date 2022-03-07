using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    private float length;
    private float startPos;

    public Transform cam;
    public float speedParalax;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float repos = cam.transform.position.x * (1- speedParalax);
        if(repos > startPos + length)
        {
            startPos += length;
        }

        float distance = cam.transform.position.x * speedParalax;
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
    }
}
