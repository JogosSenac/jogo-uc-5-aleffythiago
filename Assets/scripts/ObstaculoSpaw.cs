using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoSpaw : MonoBehaviour
{
    public GameObject ObstaculosPrefab;
    public float minHeight, maxHeight, initXSpawn, spaceBetween;
    private GameObject lastObject;
    private List<GameObject>obstaculo;
    void Start()
    {
        obstaculo = new List<GameObject>();
        lastObject = GetObstaculo();
        lastObject.transform.position = new Vector2(initXSpawn,Random.Range(minHeight, maxHeight));
    }

    // Update is called once per frame
    void Update()
    {
        if(lastObject.transform.position.x <=initXSpawn - spaceBetween )
        {
            lastObject = GetObstaculo();
            lastObject.transform.position = new Vector2(initXSpawn,Random.Range(minHeight, maxHeight));
        }
    }
    GameObject GetObstaculo()
    {
        for (int i = 0; i < obstaculo.Count; i++)
        {
            if(!obstaculo[i].activeInHierarchy)
            {
                obstaculo[i].SetActive(true);
                return obstaculo[i];
            }
        
        }

       GameObject obstaculos = Instantiate(ObstaculosPrefab, this.gameObject.transform);
       obstaculos.transform.parent = transform;
       obstaculo.Add(obstaculos);
       return obstaculos;
    }
    
    
}
