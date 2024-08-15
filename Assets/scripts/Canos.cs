using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canos : MonoBehaviour
{
    public float speed;
    private GameManeger gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManeger>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed * gm.Obstaculospeed;
    }
}
