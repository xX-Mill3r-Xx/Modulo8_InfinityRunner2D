using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataforms : MonoBehaviour
{
    private List<Transform> currentPlataforms = new List<Transform>();
    private Transform player;
    private Transform currentPlataformPoint;
    private int PlataformIndex;

    public List<GameObject> plataforms = new List<GameObject>();
    public float offSet;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        for(int i = 0; i < plataforms.Count; i++)
        {
            Transform p = Instantiate(plataforms[i], new Vector2(i * 30f, -4.5f), transform.rotation).transform;
            currentPlataforms.Add(p);
            offSet += 30f;
        }

        currentPlataformPoint = currentPlataforms[PlataformIndex].GetComponent<Plataform>().final_Point;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float distance = player.position.x - currentPlataformPoint.position.x;
        if(distance >= 2)
        {
            Recycle(currentPlataforms[PlataformIndex].gameObject);
            PlataformIndex++;

            if (PlataformIndex > currentPlataforms.Count - 1)
            {
                PlataformIndex = 0;
            }

            currentPlataformPoint = currentPlataforms[PlataformIndex].GetComponent<Plataform>().final_Point;
        }
    }

    public void Recycle(GameObject plataform)
    {
        plataform.transform.position = new Vector2(offSet, -4.5f);
        if(plataform.GetComponent<Plataform>().spawnObj != null)
        {
            plataform.GetComponent<Plataform>().spawnObj.SpawnEnemyCreate();
        }
        offSet += 30f;
    }
}
