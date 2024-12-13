using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;

public class UIscript : MonoBehaviour
{
    public GameManeger gm;
    public GameObject startpanel;
    public GameObject overpanel;

    void Start()
    {
        overpanel.SetActive(false);
        startpanel.SetActive(true);
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startpanel.SetActive(false);
        }
        


    }

    public void GameOverPanel()
    {
        overpanel.SetActive(true);
    }

}   