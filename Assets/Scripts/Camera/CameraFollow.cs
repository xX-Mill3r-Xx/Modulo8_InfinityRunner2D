using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    public float camSpeed;
    public float offSet;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        //LateUpdate é chamado mais suave que o Updade;
        Vector3 newCamPos = new Vector3(player.position.x + offSet, 0f, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, newCamPos, camSpeed * Time.deltaTime);
    }
}
