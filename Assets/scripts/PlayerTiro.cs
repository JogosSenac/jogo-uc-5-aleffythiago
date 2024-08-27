using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTiro : MonoBehaviour
{
    public GameObject tiro;
    public GameObject mira;
    public float moveH;
    public bool dirPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        
        if(Input.GetKeyDown(KeyCode.A))
        {
            dirPlayer = false;
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            dirPlayer = true;
        }
        if(Input.GetMouseButtonDown(0))
        {
            
            Atira(dirPlayer);
        }
    }
    private void Atira(bool direcao)
    {
        if(direcao)
        {
            Instantiate(tiro, mira.transform.position, Quaternion.Euler(0, 0, -90)); 
        }
        else
        {
            Instantiate(tiro, mira.transform.position, Quaternion.Euler(0, 0, 90)).GetComponent<Tiro>().DirecaoTiro(-1);
        }
    }
}
