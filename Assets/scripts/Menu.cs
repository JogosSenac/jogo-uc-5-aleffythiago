using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameManeger gm;
    public GameObject Começar;
    public GameObject Perdeu;
    private void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if(Começar.activeInHierarchy)
            //gm.Começar();
            
            if(Perdeu.activeInHierarchy)
             SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
        }
    #if UNITY_EDITOR   
        
        if(Input.GetMouseButtonDown(0))
        {
            
            if(Começar.activeInHierarchy)
            //gm.Começar();
            
            if(Perdeu.activeInHierarchy)
             SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
        }
        
        
    
    #endif
}
    
}
