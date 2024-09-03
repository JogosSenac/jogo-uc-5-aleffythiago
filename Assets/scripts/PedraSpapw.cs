using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedraSpapw : MonoBehaviour
{
 [SerializeField][Range(0,2)] private float velocidade;

    void Update()
    {
        
            
        transform.position += new Vector3(Time.deltaTime * velocidade * -1,  0, 0);
        

       
    }
}    
