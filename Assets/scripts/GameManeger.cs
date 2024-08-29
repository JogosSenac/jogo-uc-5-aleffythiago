using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public float bgspeed = 1;
    public float ObstaculosSpeed = 1;
    public bool gamePlaying;

    public GameObject Player;
    public GameObject ObstaculoSpawer;

   public GameObject começar;
    public GameObject perdeu;
   public GameObject Pontos;
    
   public void Começar()
    {
        //gamePlaying = true;
        Pontos.SetActive(true);
        ObstaculoSpawer.SetActive(true);
        Player.GetComponent<Rigidbody2D>().gravityScale =1;
        começar.SetActive(false);
    }
    
    public void GameOver()
    {
        perdeu.SetActive(true);
        gamePlaying = false;
        bgspeed = 0;
        ObstaculosSpeed = 0;

    }

}


