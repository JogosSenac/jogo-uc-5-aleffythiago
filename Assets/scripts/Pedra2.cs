using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedra2 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
